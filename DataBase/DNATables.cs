using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Windows.Forms;

namespace DataBase
{
    public class DigimonTemp
    {
        public DigimonTemp(string nameRus, string nameEng, string sourceCode, string resultCode, Rank rank)
        {
            NameRus = nameRus;
            NameEng = nameEng;
            SourceCode = sourceCode;
            ResultCode = resultCode;
            Rank = rank;
        }

        public string NameRus { get; set; }

        public string NameEng { get; set; }

        public string SourceCode { get; set; }

        public string ResultCode { get; set; }

        public Rank Rank { get; set; }

        public Digimon Digimon { get; set; }

        public override string ToString()
        {
            return $"new DigimonTemp(\"{NameRus}\", \"{NameEng}\", \"{SourceCode}\", \"{ResultCode}\", Rank.{Rank.ToString()}),";
        }
    }

    public class DNATables
    {

        public static List<DigivolveDNA> GetAllOptions(string childName)
        {
            var result = new List<DigivolveDNA>();
            //находим дигимона в списке 
            var digimon = DBStatic.Digimons.FirstOrDefault(x => x.NameEng == childName);
            var digimonTable = DigimonTemps.FirstOrDefault(x => x.NameEng == childName);
            if (digimonTable == null)
                return result;
            var digimonTableCode = digimonTable.ResultCode;
            var dic = new Dictionary<string, List<string>>();
            var digimonTemps = new List<DigimonTemp>();
            var rank = Rank.Champion;
            switch (digimon.Rank)
            {
                case Rank.Rookie:
                    dic = ChampTableDictionary;
                    digimonTemps = DigimonTemps.Where(x => x.Rank == Rank.Champion).ToList();
                    rank = Rank.Champion;
                    break;
                case Rank.Champion:
                    dic = UltimaTableDictionary;
                    digimonTemps = DigimonTemps.Where(x => x.Rank == Rank.Ultimate).ToList();
                    rank = Rank.Ultimate;
                    break;
                case Rank.Ultimate:
                    dic = MegaTableDictionary;
                    digimonTemps = DigimonTemps.Where(x => x.Rank == Rank.Mega).ToList();
                    rank = Rank.Mega;
                    break;
                case Rank.Mega:
                    return result;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            var temp = dic.FirstOrDefault(x => x.Value.Contains(digimonTableCode));

            if (temp.Key == null)
            {
                // MessageBox.Show($"Не найдено соотвествие в таблице для {childName} код {digimonTableCode}");
                return result;
            }


            var firstDigimonCode = temp.Key;
            var index = temp.Value.IndexOf(digimonTableCode);
            var secondDigimonCode = dic.ToList()[index].Key;


            var digimonTempsFirst = digimonTemps.Where(x => x.SourceCode == firstDigimonCode).ToList();
            var digimonTempsSecond = digimonTemps.Where(x => x.SourceCode == secondDigimonCode).ToList();

            var digimonWithBrotherFirst = digimonTempsFirst.SelectMany(x => DigimonWithOlderBrother(x.NameEng)).Distinct().ToList();
            var digimonWithBrotherSecond = digimonTempsSecond.SelectMany(x => DigimonWithOlderBrother(x.NameEng)).Distinct().ToList();

            foreach (var digimon1 in digimonWithBrotherFirst)
            {
                foreach (var digimon2 in digimonWithBrotherSecond)
                {
                    var exist = result.Any(x => (x.DigimonParent1Id == digimon1 && x.DigimonParent2Id == digimon2)
                                                || (x.DigimonParent1Id == digimon2 && x.DigimonParent2Id == digimon1));
                    if (!exist && (DBStatic.GetRank(digimon1) == rank || DBStatic.GetRank(digimon2) == rank))
                        result.Add(new DigivolveDNA(digimon1, digimon2, childName));
                }
            }

            result.AddRange(GetMutation().Where(x => x.DigimonChildId == childName));



            return result;
        }


        public static List<string> DigimonWithOlderBrother(string digimonId)
        {
            var result = new List<string>() { digimonId };
            var list = new List<string>() { digimonId };

            while (list.Any())
            {
                list = DBStatic.Digivolves.Where(x => list.Contains(x.DigimonFromId)).Select(x => x.DigimonToId).ToList();
                result.AddRange(list);
            }

            return result;
        }


        /// <summ;ary>
        /// Считает все варианты DNA
        /// </summary>
        public static void CalculateAllDNAOptions()
        {
            //ищем английские имена
            foreach (var digimon in DNATables.DigimonTemps)
            {
                var firstOrDefault = DataBase.DBStatic.Digimons.FirstOrDefault(x => x.NameRus.ToLower() == digimon.NameRus.ToLower());
                if (firstOrDefault != null)
                {
                    digimon.NameEng = firstOrDefault.NameEng;
                    digimon.Digimon = firstOrDefault;
                }
                else
                {
                    Console.WriteLine(digimon.NameRus);
                }
                Console.WriteLine(digimon);
            }

            foreach (var parent1 in DNATables.DigimonTempsNotRookie)
            {
                foreach (var parent2 in DNATables.DigimonTempsNotRookie)
                {
                    var dnaResult = GetChild(parent1.NameEng, parent2.NameEng);

                    if (dnaResult == null) continue;


                    var first = DBStatic.DigivolvesDNA.Any(x => x.DigimonParent1Id == dnaResult.DigimonParent1Id && x.DigimonParent2Id == dnaResult.DigimonParent2Id);

                    var second = DBStatic.DigivolvesDNA.Any(x => x.DigimonParent2Id == dnaResult.DigimonParent1Id && x.DigimonParent1Id == dnaResult.DigimonParent2Id);
                    if (!first && !second)
                        DBStatic.DigivolvesDNA.Add(dnaResult);
                }
            }
        }

        public static DigivolveDNA GetChild(string parent1Str, string parent2Str)
        {
            var parent1 = DNATables.DigimonTempsNotRookie.FirstOrDefault(x => x.NameEng == parent1Str);
            var parent2 = DNATables.DigimonTempsNotRookie.FirstOrDefault(x => x.NameEng == parent2Str);

            var parent11 = parent1;
            var parent22 = parent2;


            if (parent11.Rank != parent22.Rank)
            {
                if (parent11.Rank > parent22.Rank)
                {
                    var tmp = parent11;
                    parent11 = parent22;
                    parent22 = tmp;
                }

                do
                {
                    parent22 = Down(parent22, DNATables.DigimonTempsNotRookie);
                } while (parent11.Rank != parent22.Rank);
            }
            Dictionary<string, List<string>> dic;
            switch (parent11.Rank)
            {
                case Rank.Champion:
                    dic = DNATables.ChampTableDictionary;
                    break;
                case Rank.Ultimate:
                    dic = DNATables.UltimaTableDictionary;
                    break;
                case Rank.Mega:
                    dic = DNATables.MegaTableDictionary;
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            var listDic = dic.ToList();
            //получили строчку с вариантами
            var list = dic[parent11.SourceCode];
            //получаем индекс
            var index22 = listDic.IndexOf(listDic.FirstOrDefault(x => x.Key == parent22.SourceCode));

            var strResult = list[index22];


            DigimonTemp result;

            switch (parent11.Rank)
            {
                case Rank.Champion:
                    result = DNATables.DigimonTemps.FirstOrDefault(x => x.Rank == Rank.Rookie && x.ResultCode == strResult);
                    break;
                case Rank.Ultimate:
                    result = DNATables.DigimonTemps.FirstOrDefault(x => x.Rank == Rank.Champion && x.ResultCode == strResult);
                    break;
                case Rank.Mega:
                    result = DNATables.DigimonTemps.FirstOrDefault(x => x.Rank == Rank.Ultimate && x.ResultCode == strResult);
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }

            if (result == null
                //                        && !DB.DigivolvesDNA.Any(
                //                            x => x.DigimonParent1Id == parent1.NameEng && x.DigimonParent2Id == parent2.NameEng)
                //                        && !DB.DigivolvesDNA.Any(
                //                            x => x.DigimonParent2Id == parent1.NameEng && x.DigimonParent1Id == parent2.NameEng)
                //&& strResult != "МУ"
                )
            {
                if (strResult == "МУ")
                {
                    var mutations = GetMutation();


                    if (!Enumerable.Any<DigivolveDNA>(mutations, x => x.DigimonParent1Id == parent1.NameEng && x.DigimonParent2Id == parent2.NameEng) && !Enumerable.Any<DigivolveDNA>(mutations, x => x.DigimonParent2Id == parent1.NameEng && x.DigimonParent1Id == parent2.NameEng))
                    {
                        throw new ApplicationException("В таблице мутаций нет этого сочетания");
                    }
                }

                Console.WriteLine("Parent1={0}(Rank={4})\tParent2={1}(Rank={5})\tParent11={2}(Rank={6})\tParent22={3}(Rank={7})", parent1.NameEng, parent2.NameEng, parent11.NameEng, parent22.NameEng, parent1.Rank, parent2.Rank, parent11.Rank, parent22.Rank);

                return null;
            }

            var dnaResult = new DigivolveDNA(parent1.NameEng, parent2.NameEng, result.NameEng);
            return dnaResult;
        }


        private static List<DigivolveDNA> GetMutation()
        {
            var tempDna = new List<DigivolveDNA>();
            Dictionary<KeyValuePair<string, string>, string> Mutation = new Dictionary<KeyValuePair<string, string>, string>()
            {
                {new KeyValuePair<string, string>("Черримон", "Зудомон"), "Вадемон"}, {new KeyValuePair<string, string>("Черримон", "МастерТираномон"), "Вадемон"}, {new KeyValuePair<string, string>("Черримон", "МеталГреймон"), "Вадемон"}, {new KeyValuePair<string, string>("Черримон", "Увамон"), "Вадемон"}, {new KeyValuePair<string, string>("ГеркулкесКабутеримон", "Грифонмон"), "Янмамон"}, {new KeyValuePair<string, string>("ГеркулкесКабутеримон", "Роземон"), "Янмамон"}, {new KeyValuePair<string, string>("ГеркулкесКабутеримон", "Баихумон"), "СэндЯнмамон"}, {new KeyValuePair<string, string>("ГеркулкесКабутеримон", "МеталГарурумон"), "СэндЯнмамон"}, {new KeyValuePair<string, string>("ГеркулкесКабутеримон", "ПринцМамемон"), "СэндЯнмамон"}, {new KeyValuePair<string, string>("ГеркулкесКабутеримон", "СаберЛеомон"), "СэндЯнмамон"},
                //хз может неправильно
                {new KeyValuePair<string, string>("Паппетмон", "Зудомон"), "Вадемон"}, {new KeyValuePair<string, string>("Паппетмон", "МастерТираномон"), "Вадемон"}, {new KeyValuePair<string, string>("Паппетмон", "МеталГреймон"), "Вадемон"}, {new KeyValuePair<string, string>("Паппетмон", "Увамон"), "Вадемон"}, {new KeyValuePair<string, string>("Черримон", "БойГреймон"), "Вадемон"}, {new KeyValuePair<string, string>("Черримон", "МаринеАнгемон"), "Вадемон"}, {new KeyValuePair<string, string>("Черримон", "Омнимон"), "Вадемон"}, {new KeyValuePair<string, string>("Черримон", "Пречиомон"), "Вадемон"},
            };
            Dictionary<KeyValuePair<string, string>, string> MutationEng = new Dictionary<KeyValuePair<string, string>, string>();

            foreach (var mutation in Mutation)
            {
                MutationEng.Add(new KeyValuePair<string, string>(DBStatic.Digimons.FirstOrDefault(x => x.NameRus == mutation.Key.Key).NameEng, DBStatic.Digimons.FirstOrDefault(x => x.NameRus == mutation.Key.Value).NameEng), DBStatic.Digimons.FirstOrDefault(x => x.NameRus == mutation.Value).NameEng);
            }

            foreach (var mutationEng in MutationEng)
            {
                tempDna.Add(new DigivolveDNA(mutationEng.Key.Key, mutationEng.Key.Value, mutationEng.Value, true));
            }

            return tempDna;
        }


        public static DigimonTemp Down(DigimonTemp temp, List<DigimonTemp> list)
        {
            var down = DataBase.DBStatic.Digivolves.FirstOrDefault(x => x.DigimonToId == temp.NameEng);
            if (down == null)
                throw new ApplicationException();
            var digimonTemp = list.FirstOrDefault(x => x.NameEng == down.DigimonFromId);
            if (digimonTemp == null)
                throw new ApplicationException();
            return digimonTemp;
        }


        public static new List<DigimonTemp> DigimonTempsNotRookie
        {
            get { return DigimonTemps.Where(x => x.Rank != Rank.Rookie).ToList(); }
        }

        public static new List<DigimonTemp> DigimonTemps = new List<DigimonTemp>()
        {
            new DigimonTemp("Агумон", "Agumon", "", "ВА", Rank.Rookie), new DigimonTemp("Виимон", "Veemon", "", "ВЖ", Rank.Rookie), new DigimonTemp("Гомамон", "Gomamon", "", "ВД", Rank.Rookie), new DigimonTemp("КлирАгумон", "ClearAgumon", "", "ВЦ", Rank.Rookie), new DigimonTemp("Бийомон", "Biyomon", "", "ВБ", Rank.Rookie), new DigimonTemp("Пингвимон", "Penguinmon", "", "ВЕ", Rank.Rookie), new DigimonTemp("СноуАгумон", "SnowAgumon", "", "ВФ", Rank.Rookie), new DigimonTemp("Тапирмон", "Tapirmon", "", "ВГ", Rank.Rookie), new DigimonTemp("Тентомон", "Tentomon", "", "ВХ", Rank.Rookie), new DigimonTemp("ТойАгумон", "ToyAgumon", "", "ВИ", Rank.Rookie), new DigimonTemp("Габумон", "Gabumon", "", "ДЕ", Rank.Rookie), new DigimonTemp("Гоцумон", "Gotsumon", "", "ДФ", Rank.Rookie), new DigimonTemp("Кандмон", "Candlemon", "", "ДА", Rank.Rookie), new DigimonTemp("Крабмон", "Crabmon", "", "ДБ", Rank.Rookie), new DigimonTemp("Палмон", "Palmon", "", "ДГ", Rank.Rookie), new DigimonTemp("Патамон", "Patamon", "", "ДХ", Rank.Rookie), new DigimonTemp("Флорамон", "Floramon", "", "ДД", Rank.Rookie), new DigimonTemp("Элекмон", "Elecmon", "", "ДЦ", Rank.Rookie), new DigimonTemp("Бетамон", "Betamon", "", "РА", Rank.Rookie), new DigimonTemp("Газимон", "Gazimon", "", "РД", Rank.Rookie), new DigimonTemp("Гизамон", "Gizamon", "", "РЕ", Rank.Rookie), new DigimonTemp("Гобуримон", "Goburimon", "", "РФ", Rank.Rookie), new DigimonTemp("ДемиДевимон", "DemiDevimon", "", "РБ", Rank.Rookie), new DigimonTemp("Докунемон", "Dokunemon", "", "РЦ", Rank.Rookie), new DigimonTemp("Кунемон", "Kunemon", "", "РХ", Rank.Rookie), new DigimonTemp("Машрумон", "Mushroomon", "", "РИ", Rank.Rookie), new DigimonTemp("Отамамон", "Otamamon", "", "РЖ", Rank.Rookie), new DigimonTemp("Сиякомон", "Syakomon", "", "РЛ", Rank.Rookie), new DigimonTemp("СноуГобуримон", "SnowGoburimon", "", "РК", Rank.Rookie), new DigimonTemp("Хагурумон", "Hagurumon", "", "РГ", Rank.Rookie), new DigimonTemp("Цукаимон", "Tsukaimon", "", "РМ", Rank.Rookie), new DigimonTemp("Аирдрамон", "Airdramon", "Б", "ВА", Rank.Champion), new DigimonTemp("Ангемон", "Angemon", "Ц", "ВБ", Rank.Champion), new DigimonTemp("Бёрдрамон", "Birdramon", "Б", "ВД", Rank.Champion), new DigimonTemp("Виидрамон", "Veedramon", "Б", "ВУ", Rank.Champion), new DigimonTemp("Гарурумон", "Garurumon", "Е", "ВХ", Rank.Champion), new DigimonTemp("Гатомон", "Gatomon", "Ц", "ВИ", Rank.Champion), new DigimonTemp("Греймон", "Greymon", "А", "ВЖ", Rank.Champion), new DigimonTemp("Гурурумон", "Gururumon", "Е", "ВК", Rank.Champion), new DigimonTemp("Дольфмон", "Dolphmon", "Д", "ВЕ", Rank.Champion), new DigimonTemp("Иккакумон", "Ikkakumon", "Д", "ВЛ", Rank.Champion), new DigimonTemp("Кабутеримон", "Kabuterimon", "Ф", "ВМ", Rank.Champion), new DigimonTemp("Леомон", "Leomon", "Ц", "ВН", Rank.Champion), new DigimonTemp("Моджамон", "Mojyamon", "Е", "ВО", Rank.Champion), new DigimonTemp("Пиддомон", "Piddomon", "Ц", "ВП", Rank.Champion), new DigimonTemp("Сабердрамон", "Saberdramon", "Б", "ВЗ", Rank.Champion), new DigimonTemp("Тортомон", "Tortomon", "Д", "ВС", Rank.Champion), new DigimonTemp("Унимон", "Unimon", "Е", "ВТ", Rank.Champion), new DigimonTemp("Флеймдрамон", "Flamedramon", "Б", "ВФ", Rank.Champion), new DigimonTemp("Фригимон", "Frigimon", "Е", "ВГ", Rank.Champion), new DigimonTemp("ШимаУнимон", "ShimaUnimon", "Е", "ВР", Rank.Champion), new DigimonTemp("Эйпмон", "Apemon", "Е", "ВЦ", Rank.Champion), new DigimonTemp("Айсмон", "Icemon", "К", "ДГ", Rank.Champion), new DigimonTemp("Акаторимон", "Akatorimon", "Х", "ДА", Rank.Champion), new DigimonTemp("Визардмон", "Wizardmon", "И", "ДШ", Rank.Champion), new DigimonTemp("Дримогемон", "Drimogemon", "К", "ДЕ", Rank.Champion), new DigimonTemp("Ж-Моджамон", "JungleMojyamon", "К", "ДХ", Rank.Champion), new DigimonTemp("Кентарумон", "Centarumon", "К", "ДБ", Rank.Champion), new DigimonTemp("Кивимон", "Kiwimon", "Х", "ДИ", Rank.Champion), new DigimonTemp("Клокмон", "Clockmon", "М", "ДЦ", Rank.Champion), new DigimonTemp("Коеламон", "Coelamon", "Ж", "ДД", Rank.Champion), new DigimonTemp("Кокаторимон", "Kokatorimon", "Х", "ДЖ", Rank.Champion), new DigimonTemp("Мерамон", "Meramon", "М", "ДК", Rank.Champion), new DigimonTemp("Монохромон", "Monochromon", "Г", "ДЛ", Rank.Champion), new DigimonTemp("МориШеллмон", "MoriShellmon", "Ж", "ДМ", Rank.Champion), new DigimonTemp("МудФригимон", "MudFrigimon", "К", "ДН", Rank.Champion), new DigimonTemp("НайсДримогемон", "NiseDrimogemon", "К", "ДП", Rank.Champion), new DigimonTemp("Нинидзямон", "Ninjamon", "И", "ДО", Rank.Champion), new DigimonTemp("Сидрамон", "Seadramon", "Ж", "ДР", Rank.Champion), new DigimonTemp("Стармон", "Starmon", "И", "ДТ", Rank.Champion), new DigimonTemp("СэндЯнмамон", "SandYanmamon", "Л", "ДЗ", Rank.Champion), new DigimonTemp("Танкмон", "Tankmon", "М", "ДУ", Rank.Champion), new DigimonTemp("Тираномон", "Tyrannomon", "Г", "ДЮ", Rank.Champion), new DigimonTemp("Тогемон", "Togemon", "Н", "ДВ", Rank.Champion), new DigimonTemp("ФлареРизамон", "FlareLizardmon", "Г", "ДФ", Rank.Champion), new DigimonTemp("Шеллмон", "Shellmon", "Ж", "ДС", Rank.Champion), new DigimonTemp("Янмамон", "Yanmamon", "Л", "ДЯ", Rank.Champion), new DigimonTemp("АйсДевимон", "IceDevimon", "П", "РМ", Rank.Champion), new DigimonTemp("Бакемон", "Bakemon", "П", "РА", Rank.Champion), new DigimonTemp("Вегиемон", "Vegiemon", "У", "РЯ", Rank.Champion), new DigimonTemp("Вудмон", "Woodmon", "У", "РЩ", Rank.Champion), new DigimonTemp("Гвардромон", "Guardromon", "Т", "РК", Rank.Champion), new DigimonTemp("Гекомон", "Gekomon", "З", "РИ", Rank.Champion), new DigimonTemp("Гесомон", "Gesomon", "З", "РЖ", Rank.Champion), new DigimonTemp("ДаркРизамон", "DarkLizardmon", "О", "РЦ", Rank.Champion), new DigimonTemp("ДаркТираномон", "DarkTyrannomon", "О", "РД", Rank.Champion), new DigimonTemp("Девидрамон", "Devidramon", "О", "РФ", Rank.Champion), new DigimonTemp("Девимон", "Devimon", "П", "РГ", Rank.Champion), new DigimonTemp("Дельтамон", "Deltamon", "О", "РЕ", Rank.Champion), new DigimonTemp("Кувагамон", "Kuwagamon", "С", "РН", Rank.Champion), new DigimonTemp("Нанимон", "Nanimon", "П", "РО", Rank.Champion), new DigimonTemp("Нумемон", "Numemon", "Т", "РП", Rank.Champion), new DigimonTemp("Огремон", "Ogremon", "Р", "РР", Rank.Champion), new DigimonTemp("Октомон", "Octomon", "З", "РЗ", Rank.Champion), new DigimonTemp("П-Сукамон", "PlatinumSukamon", "Т", "РС", Rank.Champion), new DigimonTemp("Раремон", "Raremon", "Т", "РТ", Rank.Champion), new DigimonTemp("РедВегиемон", "RedVegiemon", "У", "РУ", Rank.Champion), new DigimonTemp("Соулмон", "Soulmon", "П", "РВ", Rank.Champion), new DigimonTemp("Сукамон", "Sukamon", "Т", "РЮ", Rank.Champion), new DigimonTemp("Таскмон", "Tuskmon", "О", "РШ", Rank.Champion), new DigimonTemp("Флимон", "Flymon", "С", "РХ", Rank.Champion), new DigimonTemp("Хёгамон", "Hyogamon", "Р", "РЛ", Rank.Champion), new DigimonTemp("Циклонемон", "Cyclonemon", "О", "РБ", Rank.Champion), new DigimonTemp("Ангевомон", "Angewomon", "Б", "ВЦ", Rank.Ultimate), new DigimonTemp("Андромон", "Andromon", "Б", "ВБ", Rank.Ultimate), new DigimonTemp("АэроВиидрамон", "AeroVeedramon", "А", "ВА", Rank.Ultimate), new DigimonTemp("ВереГарурумон", "WereGarurumon", "Ц", "ВН", Rank.Ultimate), new DigimonTemp("Гарудамон", "Garudamon", "А", "ВД", Rank.Ultimate), new DigimonTemp("Гиромон", "Giromon", "Б", "ВЕ", Rank.Ultimate), new DigimonTemp("Зудомон", "Zudomon", "Ф", "ВП", Rank.Ultimate), new DigimonTemp("МагнаАнгемон", "MagnaAngemon", "Б", "ВФ", Rank.Ultimate), new DigimonTemp("Мамонтмон", "Mammothmon", "Ц", "ВГ", Rank.Ultimate), new DigimonTemp("МастерТираномон", "MasterTyrannomon", "Д", "ВХ", Rank.Ultimate), new DigimonTemp("МегаКабутеримон", "MegaKabuterimon", "Е", "ВИ", Rank.Ultimate), new DigimonTemp("МеталГреймон", "MetalGreymon", "Д", "ВЖ", Rank.Ultimate), new DigimonTemp("Монзаемон", "Monzaemon", "Ц", "ВК", Rank.Ultimate), new DigimonTemp("Панджамон", "Panjyamon", "Б", "ВЛ", Rank.Ultimate), new DigimonTemp("Раидрамон", "Raidramon", "А", "ВМ", Rank.Ultimate), new DigimonTemp("Увамон", "Whamon", "Ф", "ВО", Rank.Ultimate), new DigimonTemp("Блоссомон", "Blossomon", "Г", "ДА", Rank.Ultimate), new DigimonTemp("БлюзМерамон", "BlueMeramon", "Х", "ДБ", Rank.Ultimate), new DigimonTemp("Вермилимон", "Vermilimon", "М", "ДП", Rank.Ultimate), new DigimonTemp("Дерамон", "Deramon", "И", "ДЦ", Rank.Ultimate), new DigimonTemp("Дигитамамон", "Digitamamon", "Ж", "ДД", Rank.Ultimate), new DigimonTemp("Лилимон", "Lillymon", "Г", "ДЕ", Rank.Ultimate), new DigimonTemp("Мамемон", "Mamemon", "Ж", "ДФ", Rank.Ultimate), new DigimonTemp("МегаСидрамон", "MegaSeadramon", "К", "ДГ", Rank.Ultimate), new DigimonTemp("МеталМамемон", "MetalMamemon", "Ж", "ДХ", Rank.Ultimate), new DigimonTemp("Метеормон", "Meteormon", "Л", "ДИ", Rank.Ultimate), new DigimonTemp("Пиксимон", "Piximon", "И", "ДЖ", Rank.Ultimate), new DigimonTemp("Скорпиомон", "Scorpiomon", "К", "ДЛ", Rank.Ultimate), new DigimonTemp("Тинмон", "Tinmon", "Х", "ДН", Rank.Ultimate), new DigimonTemp("Трицерамон", "Triceramon", "М", "ДО", Rank.Ultimate), new DigimonTemp("Тыквинмон", "Pumpkinmon", "Г", "ДК", Rank.Ultimate), new DigimonTemp("ЧерепМерамон", "SkullMeramon", "Х", "ДМ", Rank.Ultimate), new DigimonTemp("Вадемон", "Vademon", "О", "РЗ", Rank.Ultimate), new DigimonTemp("ВаруМонзаемон", "WaruMonzaemon", "З", "РР", Rank.Ultimate), new DigimonTemp("ВаруСидрамон", "WaruSeadramon", "П", "РС", Rank.Ultimate), new DigimonTemp("Гарбамон", "Garbagemon", "О", "РФ", Rank.Ultimate), new DigimonTemp("Гигадрамон", "Gigadramon", "Р", "РГ", Rank.Ultimate), new DigimonTemp("Датамон", "Datamon", "О", "РБ", Rank.Ultimate), new DigimonTemp("Драгомон", "Dragomon", "П", "РЦ", Rank.Ultimate), new DigimonTemp("МаринеДевимон", "MarineDevimon", "П", "РФ", Rank.Ultimate), new DigimonTemp("Мегадрамон", "Megadramon", "Р", "РИ", Rank.Ultimate), new DigimonTemp("МеталТираномон", "MetalTyrannomon", "Р", "РЖ", Rank.Ultimate), new DigimonTemp("Миотисмон", "Myotismon", "С", "РК", Rank.Ultimate), new DigimonTemp("Окувамон", "Okuwamon", "Т", "РЛ", Rank.Ultimate), new DigimonTemp("Теккамон", "Tekkamon", "С", "РП", Rank.Ultimate), new DigimonTemp("Фантомон", "Phantomon", "С", "РМ", Rank.Ultimate), new DigimonTemp("ЧерепоГреймон", "SkullGreymon", "Р", "РО", Rank.Ultimate), new DigimonTemp("Черримон", "Cherrymon", "Н", "РА", Rank.Ultimate), new DigimonTemp("ШоганГекомон", "ShogunGekomon", "П", "РН", Rank.Ultimate), new DigimonTemp("ЭксТираномон", "ExTyrannomon", "Р", "РЕ", Rank.Ultimate), new DigimonTemp("Этемон", "Etemon", "З", "РД", Rank.Ultimate), new DigimonTemp("Баихумон", "Baihumon", "Б", "", Rank.Mega), new DigimonTemp("БойГреймон", "WarGreymon", "Ф", "", Rank.Mega), new DigimonTemp("Болтмон", "Boltmon", "Х", "", Rank.Mega), new DigimonTemp("ВеномМиотисмон", "VenomMyotismon", "П", "", Rank.Mega), new DigimonTemp("ГеркулкесКабутеримон", "HerculesKabuterimon", "А", "", Rank.Mega), new DigimonTemp("ГранКувагамон", "GranKuwagamon", "М", "", Rank.Mega), new DigimonTemp("Грифонмон", "Gryphonmon", "И", "", Rank.Mega), new DigimonTemp("Диаборомон", "Diaboromon", "М", "", Rank.Mega), new DigimonTemp("Жижимон", "Jijimon", "Ц", "", Rank.Mega), new DigimonTemp("Империалдрамон", "Imperialdramon", "Б", "", Rank.Mega), new DigimonTemp("Магнадрамон", "Magnadramon", "Д", "", Rank.Mega), new DigimonTemp("МаринеАнгемон", "MarineAngemon", "Е", "", Rank.Mega), new DigimonTemp("Машинедрамон", "Machinedramon", "Н", "", Rank.Mega), new DigimonTemp("МеталГарурумон", "MetalGarurumon", "Г", "", Rank.Mega), new DigimonTemp("МеталСидрамон", "MetalSeadramon", "Ж", "", Rank.Mega), new DigimonTemp("МеталЭтемон", "MetalEtemon", "О", "", Rank.Mega), new DigimonTemp("Омнимон", "Omnimon", "Ф", "", Rank.Mega), new DigimonTemp("Паппетмон", "Puppetmon", "Р", "", Rank.Mega), new DigimonTemp("Пречиомон", "Preciomon", "Ж", "", Rank.Mega), new DigimonTemp("ПринцМамемон", "PrinceMamemon", "К", "", Rank.Mega), new DigimonTemp("Пукумон", "Pukumon", "З", "", Rank.Mega), new DigimonTemp("Пьерротмон", "Pierrotmon", "П", "", Rank.Mega), new DigimonTemp("Роземон", "Rosemon", "Л", "", Rank.Mega), new DigimonTemp("СаберЛеомон", "SaberLeomon", "К", "", Rank.Mega), new DigimonTemp("Серафимон", "Seraphimon", "Д", "", Rank.Mega), new DigimonTemp("СкуллМамонтмон", "SkullMammothmon", "Ц", "", Rank.Mega), new DigimonTemp("Фениксмон", "Phoenixmon", "Б", "", Rank.Mega),
        };


        public static Dictionary<string, List<string>> ChampTableDictionary = new Dictionary<string, List<string>>()
        {
            {
                "А", new List<string>
                {
                    "ВА", "ВЖ", "ДЦ", "ВА", "ВФ", "ДЦ", "ВА", "ДХ", "ДЕ", "ДД", "ДЦ", "ДБ", "ВА", "ВИ", "ВФ", "ВХ", "ВА", "ВЕ", "ВЖ", "ДД", "ВИ"
                }
            },
            {
                "Б", new List<string>
                {
                    "ВЖ", "ВБ", "ДД", "ВБ", "ВБ", "ДД", "ВБ", "ДД", "ДД", "ДД", "ДД", "ДГ", "ВЖ", "ВБ", "ВБ", "ВХ", "ВБ", "ВХ", "ВХ", "ДД", "ВБ"
                }
            },
            {
                "Г", new List<string>
                {
                    "ДЦ", "ДД", "ДЦ", "ДЦ", "ДД", "ДЦ", "РЕ", "ДХ", "ДЕ", "ДД", "ДЦ", "ДБ", "РА", "РМ", "РФ", "РХ", "РЕ", "РЖ", "ДД", "ДД", "ДХ"
                }
            },
            {
                "Д", new List<string>
                {
                    "ВА", "ВБ", "ДЦ", "ВД", "ВГ", "ДБ", "ВД", "ДБ", "ДФ", "ДБ", "ДБ", "ДБ", "ВА", "ВД", "ВГ", "ВД", "ВЕ", "ВЕ", "ВД", "ДД", "ВИ"
                }
            },
            {
                "Е", new List<string>
                {
                    "ВФ", "ВБ", "ДД", "ВГ", "ВГ", "ДФ", "ВГ", "ДХ", "ДЕ", "ДД", "ДФ", "ДЕ", "ВФ", "ВИ", "ВГ", "ВХ", "ВФ", "ВГ", "ВХ", "ДД", "ВИ"
                }
            },
            {
                "Ж", new List<string>
                {
                    "ДЦ", "ДД", "ДЦ", "ДБ", "ДФ", "ДД", "РЛ", "ДБ", "ДФ", "ДБ", "ДБ", "ДБ", "РЕ", "РЖ", "РК", "РЛ", "РЛ", "РЖ", "ДБ", "ДД", "ДБ"
                }
            },
            {
                "З", new List<string>
                {
                    "ВА", "ВБ", "РЕ", "ВД", "ВГ", "РЛ", "РЖ", "РЖ", "РК", "РЛ", "РЛ", "РЖ", "РЕ", "РЖ", "РД", "РЛ", "РК", "РИ", "ВД", "РЛ", "ВД"
                }
            },
            {
                "И", new List<string>
                {
                    "ДХ", "ДД", "ДХ", "ДБ", "ДХ", "ДБ", "РЖ", "ДХ", "ДХ", "ДД", "ДФ", "ДГ", "РМ", "РБ", "РД", "РХ", "РК", "РИ", "ДД", "ДД", "ДХ"
                }
            },
            {
                "К", new List<string>
                {
                    "ДЕ", "ДД", "ДЕ", "ДФ", "ДЕ", "ДФ", "РК", "ДХ", "ДЕ", "ДД", "ДФ", "ДЕ", "РФ", "РД", "РФ", "РХ", "РК", "РФ", "ДД", "ДД", "ДХ"
                }
            },
            {
                "Л", new List<string>
                {
                    "ДД", "ДД", "ДД", "ДБ", "ДД", "ДБ", "РЛ", "ДД", "ДД", "ДД", "ДА", "ДД", "РХ", "РХ", "РХ", "РХ", "РГ", "РХ", "ДД", "ДД", "ДД"
                }
            },
            {
                "М", new List<string>
                {
                    "ДЦ", "ДД", "ДЦ", "ДБ", "ДФ", "ДБ", "РЛ", "ДФ", "ДФ", "ДА", "ДА", "ДА", "РЕ", "РК", "РК", "РГ", "РГ", "РГ", "ДБ", "ДД", "ДФ"
                }
            },
            {
                "Н", new List<string>
                {
                    "ДБ", "ДГ", "ДБ", "ДБ", "ДЕ", "ДБ", "РЖ", "ДГ", "ДЕ", "ДД", "ДА", "ДГ", "РЖ", "РИ", "РФ", "РХ", "РГ", "РИ", "ДД", "ДГ", "ДГ"
                }
            },
            {
                "О", new List<string>
                {
                    "ВА", "ВЖ", "РА", "ВА", "ВФ", "РЕ", "РЕ", "РМ", "РФ", "РХ", "РЕ", "РЖ", "РА", "РМ", "РФ", "РХ", "РЖ", "РЕ", "ВХ", "РЦ", "ВИ"
                }
            },
            {
                "П", new List<string>
                {
                    "ВИ", "ВБ", "РМ", "ВД", "ВИ", "РЖ", "РЖ", "РБ", "РД", "РХ", "РК", "РИ", "РМ", "РБ", "РД", "РХ", "РК", "РИ", "ВХ", "РЦ", "ВЦ"
                }
            },
            {
                "Р", new List<string>
                {
                    "ВФ", "ВБ", "РФ", "ВГ", "ВГ", "РК", "РД", "РД", "РФ", "РХ", "РК", "РФ", "РФ", "РД", "РФ", "РХ", "РК", "РФ", "ВХ", "РЦ", "ВИ"
                }
            },
            {
                "С", new List<string>
                {
                    "ВХ", "ВХ", "РХ", "ВД", "ВХ", "РЛ", "РЛ", "РХ", "РХ", "РХ", "РГ", "РХ", "РХ", "РХ", "РХ", "РХ", "РГ", "РХ", "ВХ", "РХ", "ВХ"
                }
            },
            {
                "Т", new List<string>
                {
                    "ВА", "ВБ", "РЕ", "ВЕ", "ВФ", "РЛ", "РК", "РК", "РК", "РГ", "РГ", "РГ", "РЕ", "РК", "РК", "РГ", "РГ", "РГ", "ВХ", "РЦ", "ВФ"
                }
            },
            {
                "У", new List<string>
                {
                    "ВЕ", "ВХ", "РЖ", "ВЕ", "ВГ", "РЖ", "РИ", "РИ", "РФ", "РХ", "РГ", "РИ", "РЖ", "РИ", "РФ", "РХ", "РГ", "РИ", "ВХ", "РИ", "ВХ"
                }
            },
            {
                "Ф", new List<string>
                {
                    "ВЖ", "ВХ", "ДД", "ВД", "ВХ", "ДБ", "ВД", "ДД", "ДД", "ДД", "ДА", "ДД", "ВХ", "ВХ", "ВХ", "ВХ", "ВХ", "ВХ", "ВХ", "ДД", "ВХ"
                }
            },
            {
                "Х", new List<string>
                {
                    "ДД", "ДД", "ДД", "ДД", "ДД", "ДД", "РЛ", "ДД", "ДД", "ДД", "ДД", "ДГ", "РЦ", "РЦ", "РЦ", "РХ", "РЦ", "РИ", "ДД", "ДД", "ДД"
                }
            },
            {
                "Ц", new List<string>
                {
                    "ВИ", "ВБ", "ДХ", "ВИ", "ВИ", "ДБ", "ВД", "ДХ", "ДХ", "ДД", "ДФ", "ДГ", "ВИ", "ВЦ", "ВИ", "ВХ", "ВФ", "ВХ", "ВХ", "ДД", "ВЦ"
                }
            },
        };

        public static Dictionary<string, List<string>> UltimaTableDictionary = new Dictionary<string, List<string>>()
        {
            {
                "А", new List<string>
                {
                    "ВД", "ВУ", "ДВ", "ВУ", "ВМ", "ДИ", "ВЗ", "ДЖ", "ДА", "ДЖ", "ДА", "ВМ", "ВА", "ВА", "ВУ", "ВУ", "ВМ", "ВА", "ДИ", "ВЗ"
                }
            },
            {
                "Б", new List<string>
                {
                    "ВУ", "ВБ", "ДВ", "ВИ", "ВМ", "ДТ", "ВН", "ДИ", "ДР", "ДО", "ДШ", "ВМ", "ВГ", "ВЛ", "ВИ", "ВБ", "ВМ", "ВЛ", "ДБ", "ВН"
                }
            },
            {
                "Г", new List<string>
                {
                    "ДВ", "ДВ", "ДВ", "ДМ", "ДЯ", "ДВ", "РР", "ДВ", "ДМ", "ДХ", "ДМ", "РЩ", "РТ", "РК", "РК", "РУ", "РН", "ДМ", "ДЦ", "ДХ"
                }
            },
            {
                "Д", new List<string>
                {
                    "ВУ", "ВИ", "ДМ", "ВЖ", "ВМ", "ДШ", "ВР", "ДА", "ДФ", "ДЕ", "ДЮ", "МУ", "ВЖ", "ВЖ", "ВЖ", "ВИ", "ВМ", "ВР", "ДЛ", "ВР"
                }
            },
            {
                "Е", new List<string>
                {
                    "ВМ", "ВМ", "ДЯ", "ВМ", "ВМ", "ДЗ", "ВМ", "ДЯ", "ДС", "ДЗ", "ДЗ", "ВМ", "ВМ", "ВЕ", "ВМ", "ВМ", "ВМ", "ВЕ", "ДУ", "ВМ"
                }
            },
            {
                "Ж", new List<string>
                {
                    "ДИ", "ДТ", "ДВ", "ДШ", "ДЗ", "ДТ", "РА", "ДИ", "ДР", "ДО", "ДШ", "РУ", "РЛ", "РЖ", "РМ", "РГ", "РН", "ДР", "ДБ", "ДО"
                }
            },
            {
                "З", new List<string>
                {
                    "ВЗ", "ВН", "РР", "ВР", "ВМ", "РА", "РР", "РХ", "РЛ", "РР", "РР", "РР", "РЛ", "РЛ", "РР", "РА", "РН", "ВО", "РЛ", "ВХ"
                }
            },
            {
                "И", new List<string>
                {
                    "ДЖ", "ДИ", "ДВ", "ДА", "ДЯ", "ДИ", "РХ", "ДЖ", "ДИ", "ДИ", "ДА", "РЯ", "РХ", "РХ", "РХ", "РХ", "РН", "ДА", "ДИ", "ДЖ"
                }
            },
            {
                "К", new List<string>
                {
                    "ДА", "ДР", "ДМ", "ДП", "ДФ", "ДР", "РЛ", "ДИ", "ДР", "ДП", "ДФ", "РК", "РЗ", "РЗ", "РЦ", "РЖ", "РЖ", "ДР", "ДС", "ДП"
                }
            },
            {
                "Л", new List<string>
                {
                    "ДЖ", "ДО", "ДХ", "ДЕ", "ДЗ", "ДО", "РР", "ДИ", "ДП", "ДГ", "ДЕ", "РР", "РЛ", "РЛ", "РР", "РА", "РН", "ДП", "ДБ", "ДГ"
                }
            },
            {
                "М", new List<string>
                {
                    "ДА", "ДШ", "ДМ", "ДЮ", "ДЗ", "ДШ", "РР", "ДА", "ДФ", "ДЕ", "ДЮ", "РК", "РБ", "РЦ", "РД", "РМ", "РН", "ДП", "ДЛ", "ДЕ"
                }
            },
            {
                "Н", new List<string>
                {
                    "ВМ", "ВМ", "РЩ", "МУ", "ВМ", "РУ", "РР", "РЯ", "РК", "РР", "РК", "РЩ", "РТ", "РК", "РК", "РУ", "РН", "МУ", "РТ", "ВТ"
                }
            },
            {
                "О", new List<string>
                {
                    "ВА", "ВГ", "РТ", "РЖ", "РМ", "РЛ", "РЛ", "РХ", "РЗ", "РЛ", "РБ", "РТ", "РИ", "РЗ", "РБ", "РЛ", "РС", "ВЕ", "РИ", "ВЦ"
                }
            },
            {
                "П", new List<string>
                {
                    "ВА", "ВЛ", "РК", "ВЖ", "ВЕ", "РЖ", "РЛ", "РХ", "РЗ", "РЛ", "РЦ", "РК", "РЗ", "РЗ", "РЦ", "РЖ", "РЖ", "ВЛ", "РЗ", "ВО"
                }
            },
            {
                "Р", new List<string>
                {
                    "ВУ", "ВИ", "РК", "ВЖ", "ВМ", "РМ", "РР", "РХ", "РЦ", "РР", "РД", "РК", "РБ", "РЦ", "РД", "РМ", "РН", "ВЖ", "РБ", "ВР"
                }
            },
            {
                "С", new List<string>
                {
                    "ВУ", "ВБ", "РУ", "ВИ", "ВМ", "РГ", "РА", "РХ", "РЖ", "РА", "РМ", "РУ", "РЛ", "РЖ", "РМ", "РГ", "РН", "ВЛ", "РЛ", "ВН"
                }
            },
            {
                "Т", new List<string>
                {
                    "ВМ", "ВМ", "РН", "ВМ", "ВМ", "РН", "РН", "РН", "РЖ", "РН", "РН", "РН", "РС", "РЖ", "РН", "РН", "РН", "ВЕ", "РС", "ВМ"
                }
            },
            {
                "Ф", new List<string>
                {
                    "ВА", "ВЛ", "ДМ", "ВР", "ВЕ", "ДР", "ВО", "ДА", "ДР", "ДП", "ДФ", "МУ", "ВЕ", "ВЛ", "ВЖ", "ВЛ", "ВЕ", "ВЛ", "ДС", "ВО"
                }
            },
            {
                "Х", new List<string>
                {
                    "ДИ", "ДБ", "ДЦ", "ДЛ", "ДУ", "ДБ", "РЛ", "ДИ", "ДС", "ДБ", "ДЛ", "РТ", "РИ", "РЗ", "РБ", "РЛ", "РС", "ДС", "ДК", "ДН"
                }
            },
            {
                "Ц", new List<string>
                {
                    "ВЗ", "ВН", "ДХ", "ВР", "ВМ", "ДО", "ВХ", "ДЖ", "ДП", "ДГ", "ДЕ", "ВТ", "ВЦ", "ВО", "ВР", "ВН", "ВМ", "ВО", "ДН", "ВХ"
                }
            },
        };

        public static Dictionary<string, List<string>> MegaTableDictionary = new Dictionary<string, List<string>>()
        {
            {
                "А", new List<string>
                {
                    "ВИ", "ВИ", "МУ", "ВИ", "ВП", "ДГ", "ВП", "МУ", "МУ", "МУ", "ВИ", "ВИ", "ВИ", "ВИ", "ВИ", "ВИ", "ДМ", "ВИ"
                }
            },
            {
                "Б", new List<string>
                {
                    "ВИ", "ВД", "ДЦ", "ВД", "ВА", "ДЦ", "ВА", "ДЦ", "ДЖ", "ДА", "ВИ", "ВА", "ВА", "ВД", "ВИ", "ВА", "ДЖ", "ВА"
                }
            },
            {
                "Г", new List<string>
                {
                    "МУ", "ДЦ", "ДИ", "ДФ", "ДИ", "ДИ", "РР", "ДЦ", "ДФ", "ДИ", "РЛ", "РД", "РД", "РМ", "РД", "ДИ", "ДИ", "ДИ"
                }
            },
            {
                "Д", new List<string>
                {
                    "ВИ", "ВД", "ДФ", "ВФ", "ВП", "ДГ", "ВП", "ДЖ", "ДХ", "ДК", "ВИ", "ВБ", "ВЛ", "ВФ", "ВИ", "ВБ", "ДИ", "ВЛ"
                }
            },
            {
                "Е", new List<string>
                {
                    "ВП", "ВА", "ДИ", "ВП", "ВП", "ДГ", "ВО", "ДЦ", "ДГ", "ДЛ", "ВО", "ВХ", "ВГ", "ВП", "ВП", "ВХ", "ДЛ", "ВГ"
                }
            },
            {
                "Ж", new List<string>
                {
                    "ДГ", "ДЦ", "ДИ", "ДГ", "ДГ", "ДГ", "РЦ", "ДЦ", "ДГ", "ДЛ", "РН", "РО", "РР", "РН", "РХ", "ДП", "ДЛ", "ДИ"
                }
            },
            {
                "З", new List<string>
                {
                    "ВП", "ВА", "РР", "ВП", "ВО", "РЦ", "РЦ", "РЛ", "РН", "РХ", "РН", "РО", "РР", "РН", "РХ", "ВХ", "РС", "ВГ"
                }
            },
            {
                "И", new List<string>
                {
                    "МУ", "ДЦ", "ДЦ", "ДЖ", "ДЦ", "ДЦ", "РЛ", "ДЦ", "ДЖ", "ДА", "РЛ", "РЛ", "РЛ", "РЛ", "РА", "ДЖ", "ДЖ", "ДЦ"
                }
            },
            {
                "К", new List<string>
                {
                    "МУ", "ДЖ", "ДФ", "ДХ", "ДГ", "ДГ", "РН", "ДЖ", "ДХ", "ДК", "РЛ", "РП", "РМ", "РК", "РА", "ДД", "ДИ", "ДФ"
                }
            },
            {
                "Л", new List<string>
                {
                    "МУ", "ДА", "ДИ", "ДК", "ДЛ", "ДЛ", "РХ", "ДА", "ДК", "ДЕ", "РЛ", "РХ", "РД", "РА", "РА", "ДЛ", "ДБ", "ДИ"
                }
            },
            {
                "М", new List<string>
                {
                    "ВИ", "ВИ", "РЛ", "ВИ", "ВО", "РН", "РН", "РЛ", "РЛ", "РЛ", "РЛ", "РЛ", "РЛ", "РЛ", "РЛ", "ВИ", "РЗ", "ВИ"
                }
            },
            {
                "Н", new List<string>
                {
                    "ВИ", "ВА", "РД", "ВБ", "ВХ", "ВО", "РО", "РЛ", "РП", "РХ", "РЛ", "РИ", "РД", "РП", "РХ", "ВЖ", "РЕ", "ВН"
                }
            },
            {
                "О", new List<string>
                {
                    "ВИ", "ВА", "РД", "ВЛ", "ВГ", "РР", "РР", "РЛ", "РМ", "РД", "РЛ", "РД", "РД", "РМ", "РД", "ВР", "РР", "ВР"
                }
            },
            {
                "П", new List<string>
                {
                    "ВИ", "ВД", "РМ", "ВФ", "ВП", "РН", "РН", "РЛ", "РК", "РА", "РЛ", "РП", "РМ", "РК", "РА", "ВБ", "РР", "ВЛ"
                }
            },
            {
                "Р", new List<string>
                {
                    "ВИ", "ВИ", "РД", "ВИ", "ВП", "РХ", "РХ", "РА", "РА", "РА", "РЛ", "РХ", "РД", "РА", "РА", "ВП", "РФ", "ВК"
                }
            },
            {
                "Ф", new List<string>
                {
                    "ВИ", "ВА", "ДИ", "ВБ", "ВХ", "ДП", "ВХ", "ДЖ", "ДД", "ДЛ", "ВИ", "ВЖ", "ВН", "ВБ", "ВП", "ВЖ", "ДО", "ВН"
                }
            },
            {
                "Х", new List<string>
                {
                    "ДМ", "ДЖ", "ДИ", "ДИ", "ДЛ", "ДЛ", "РС", "ДЖ", "ДИ", "ДБ", "РЗ", "РЕ", "РР", "РР", "РФ", "ДО", "ДН", "ДИ"
                }
            },
            {
                "Ц", new List<string>
                {
                    "ВИ", "ВА", "ДИ", "ВЛ", "ВГ", "ДИ", "ВГ", "ДЦ", "ДФ", "ДИ", "ВИ", "ВН", "ВН", "ВЛ", "ВК", "ВН", "ДИ", "ВН"
                }
            },
        };
    }
}
