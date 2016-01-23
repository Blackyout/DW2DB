using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataBase;
using Xunit;


namespace DAO.Test
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
    }





    public class Tests
    {
        [Fact]
        public void EntityTest()
        {

            foreach (var digivolve in DataBase.DB.Digivolves)
            {
                var from = DataBase.DB.Digimons.FirstOrDefault(x => x.Id == digivolve.DigimonFromId);
                var to = DataBase.DB.Digimons.FirstOrDefault(x => x.Id == digivolve.DigimonToId);
                if (from == null)
                {
                    Console.WriteLine(digivolve.DigimonFromId);
                }
                if (to == null)
                {
                    Console.WriteLine(digivolve.DigimonToId);
                }
            }

            
        }

        [Fact]
        public void Fill()
        {
            var rookie = new List<DigimonTemp>()
            {
                new DigimonTemp("Агумон", "", "", "ВА", Rank.Rookie),
                new DigimonTemp("Виимон", "", "", "ВЖ", Rank.Rookie),
                new DigimonTemp("Гомамон", "", "", "ВД", Rank.Rookie),
                new DigimonTemp("КлирАгумон", "", "", "ВЦ", Rank.Rookie),
                new DigimonTemp("Бийомон", "", "", "ВБ", Rank.Rookie),
                new DigimonTemp("Пингвимон", "", "", "ВЕ", Rank.Rookie),
                new DigimonTemp("СноуАгумон", "", "", "ВФ", Rank.Rookie),
                new DigimonTemp("Тапирмон", "", "", "ВГ", Rank.Rookie),
                new DigimonTemp("Тентомон", "", "", "ВХ", Rank.Rookie),
                new DigimonTemp("ТойАгумон", "", "", "ВИ", Rank.Rookie),
                new DigimonTemp("Габумон", "", "", "ДЕ", Rank.Rookie),
                new DigimonTemp("Гоцумон", "", "", "ДФ", Rank.Rookie),
                new DigimonTemp("Кандмон", "", "", "ДА", Rank.Rookie),
                new DigimonTemp("Крабмон", "", "", "ДБ", Rank.Rookie),
                new DigimonTemp("Палмон", "", "", "ДГ", Rank.Rookie),
                new DigimonTemp("Патамон", "", "", "ДХ", Rank.Rookie),
                new DigimonTemp("Флорамон", "", "", "ДД", Rank.Rookie),
                new DigimonTemp("Элекмон", "", "", "ДЦ", Rank.Rookie),
                new DigimonTemp("Бетамон", "", "", "РА", Rank.Rookie),
                new DigimonTemp("Газимон", "", "", "РД", Rank.Rookie),
                new DigimonTemp("Гизамон", "", "", "РЕ", Rank.Rookie),
                new DigimonTemp("Гобуримон", "", "", "РФ", Rank.Rookie),
                new DigimonTemp("ДемиДевимон", "", "", "РБ", Rank.Rookie),
                new DigimonTemp("Докунемон", "", "", "РЦ", Rank.Rookie),
                new DigimonTemp("Кунемон", "", "", "РХ", Rank.Rookie),
                new DigimonTemp("Машрумон", "", "", "РИ", Rank.Rookie),
                new DigimonTemp("Отамамон", "", "", "РЖ", Rank.Rookie),
                new DigimonTemp("Сиякомон", "", "", "РЛ", Rank.Rookie),
                new DigimonTemp("СноуГобуримон", "", "", "РК", Rank.Rookie),
                new DigimonTemp("Хагурумон", "", "", "РГ", Rank.Rookie),
                new DigimonTemp("Цукаимон", "", "", "РМ", Rank.Rookie),
                new DigimonTemp("Аирдрамон", "", "Б", "ВА", Rank.Champion),
                new DigimonTemp("Ангемон", "", "Ц", "ВБ", Rank.Champion),
                new DigimonTemp("Бёрдрамон", "", "Б", "ВД", Rank.Champion),
                new DigimonTemp("Виидрамон", "", "Б", "ВУ", Rank.Champion),
                new DigimonTemp("Гарурумон", "", "Е", "ВХ", Rank.Champion),
                new DigimonTemp("Гатомон", "", "Ц", "ВИ", Rank.Champion),
                new DigimonTemp("Греймон", "", "А", "ВЖ", Rank.Champion),
                new DigimonTemp("Гурурумон", "", "Е", "ВК", Rank.Champion),
                new DigimonTemp("Дольфмон", "", "Д", "ВЕ", Rank.Champion),
                new DigimonTemp("Иккакумон", "", "Д", "ВЛ", Rank.Champion),
                new DigimonTemp("Кабутеримон", "", "Ф", "ВМ", Rank.Champion),
                new DigimonTemp("Леомон", "", "Ц", "ВН", Rank.Champion),
                new DigimonTemp("Моджамон", "", "Е", "ВО", Rank.Champion),
                new DigimonTemp("Пиддомон", "", "Ц", "ВП", Rank.Champion),
                new DigimonTemp("Сабердрамон", "", "Б", "ВЗ", Rank.Champion),
                new DigimonTemp("Тортомон", "", "Д", "ВС", Rank.Champion),
                new DigimonTemp("Унимон", "", "Е", "ВТ", Rank.Champion),
                new DigimonTemp("Флеймдрамон", "", "Б", "ВФ", Rank.Champion),
                new DigimonTemp("Фригимон", "", "Е", "ВГ", Rank.Champion),
                new DigimonTemp("ШимаУнимон", "", "Е", "ВР", Rank.Champion),
                new DigimonTemp("Эйпмон", "", "Е", "ВЦ", Rank.Champion),
                new DigimonTemp("Айсмон", "", "К", "ДГ", Rank.Champion),
                new DigimonTemp("Акаторимон", "", "Х", "ДА", Rank.Champion),
                new DigimonTemp("Визардмон", "", "И", "ДШ", Rank.Champion),
                new DigimonTemp("Дримогемон", "", "К", "ДЕ", Rank.Champion),
                new DigimonTemp("Ж-Моджамон", "", "К", "ДХ", Rank.Champion),
                new DigimonTemp("Кентарумон", "", "К", "ДБ", Rank.Champion),
                new DigimonTemp("Кивимон", "", "Х", "ДИ", Rank.Champion),
                new DigimonTemp("Клокмон", "", "М", "ДЦ", Rank.Champion),
                new DigimonTemp("Коеламон", "", "Ж", "ДД", Rank.Champion),
                new DigimonTemp("Кокаторимон", "", "Х", "ДЖ", Rank.Champion),
                new DigimonTemp("Мерамон", "", "М", "ДК", Rank.Champion),
                new DigimonTemp("Монохромон", "", "Г", "ДЛ", Rank.Champion),
                new DigimonTemp("МориШеллмон", "", "Ж", "ДМ", Rank.Champion),
                new DigimonTemp("МудФригимон", "", "К", "ДН", Rank.Champion),
                new DigimonTemp("НайсДримогемон", "", "К", "ДП", Rank.Champion),
                new DigimonTemp("Нинидзямон", "", "И", "ДО", Rank.Champion),
                new DigimonTemp("Сидрамон", "", "Ж", "ДР", Rank.Champion),
                new DigimonTemp("Стармон", "", "И", "ДТ", Rank.Champion),
                new DigimonTemp("СэндЯнмамон", "", "Л", "ДЗ", Rank.Champion),
                new DigimonTemp("Танкмон", "", "М", "ДУ", Rank.Champion),
                new DigimonTemp("Тираномон", "", "Г", "ДЮ", Rank.Champion),
                new DigimonTemp("Тогемон", "", "Н", "ДВ", Rank.Champion),
                new DigimonTemp("ФлареРизамон", "", "Г", "ДФ", Rank.Champion),
                new DigimonTemp("Шеллмон", "", "Ж", "ДС", Rank.Champion),
                new DigimonTemp("Янмамон", "", "Л", "ДЯ", Rank.Champion),
                new DigimonTemp("АйсДевимон", "", "П", "РМ", Rank.Champion),
                new DigimonTemp("Бакемон", "", "П", "РА", Rank.Champion),
                new DigimonTemp("Вегиемон", "", "У", "РЯ", Rank.Champion),
                new DigimonTemp("Вудмон", "", "У", "РЩ", Rank.Champion),
                new DigimonTemp("Гвардромон", "", "Т", "РК", Rank.Champion),
                new DigimonTemp("Гекомон", "", "З", "РИ", Rank.Champion),
                new DigimonTemp("Гесомон", "", "З", "РЖ", Rank.Champion),
                new DigimonTemp("ДаркРизамон", "", "О", "РЦ", Rank.Champion),
                new DigimonTemp("ДаркТираномон", "", "О", "РД", Rank.Champion),
                new DigimonTemp("Девидрамон", "", "О", "РФ", Rank.Champion),
                new DigimonTemp("Девимон", "", "П", "РГ", Rank.Champion),
                new DigimonTemp("Дельтамон", "", "О", "РЕ", Rank.Champion),
                new DigimonTemp("Кувагамон", "", "С", "РН", Rank.Champion),
                new DigimonTemp("Нанимон", "", "П", "РО", Rank.Champion),
                new DigimonTemp("Нумемон", "", "Т", "РП", Rank.Champion),
                new DigimonTemp("Огремон", "", "Р", "РР", Rank.Champion),
                new DigimonTemp("Октомон", "", "З", "РЗ", Rank.Champion),
                new DigimonTemp("П-Сукамон", "", "Т", "РС", Rank.Champion),
                new DigimonTemp("Раремон", "", "Т", "РТ", Rank.Champion),
                new DigimonTemp("РедВегиемон", "", "У", "РУ", Rank.Champion),
                new DigimonTemp("Соулмон", "", "П", "РВ", Rank.Champion),
                new DigimonTemp("Сукамон", "", "Т", "РЮ", Rank.Champion),
                new DigimonTemp("Таскмон", "", "О", "РШ", Rank.Champion),
                new DigimonTemp("Флимон", "", "С", "РХ", Rank.Champion),
                new DigimonTemp("Хёгамон", "", "Р", "РЛ", Rank.Champion),
                new DigimonTemp("Циклонемон", "", "О", "РБ", Rank.Champion),
                new DigimonTemp("Ангевомон", "", "Б", "ВЦ", Rank.Ultimate),
                new DigimonTemp("Андромон", "", "Б", "ВБ", Rank.Ultimate),
                new DigimonTemp("АэроВиидрамон", "", "А", "ВА", Rank.Ultimate),
                new DigimonTemp("ВереГарурумон", "", "Ц", "ВН", Rank.Ultimate),
                new DigimonTemp("Гарудамон", "", "А", "ВД", Rank.Ultimate),
                new DigimonTemp("Гиромон", "", "Б", "ВЕ", Rank.Ultimate),
                new DigimonTemp("Зудомон", "", "Ф", "ВП", Rank.Ultimate),
                new DigimonTemp("МагнаАнгемон", "", "Б", "ВФ", Rank.Ultimate),
                new DigimonTemp("Мамонтмон", "", "Ц", "ВГ", Rank.Ultimate),
                new DigimonTemp("МастерТираномон", "", "Д", "ВХ", Rank.Ultimate),
                new DigimonTemp("МегаКабутеримон", "", "Е", "ВИ", Rank.Ultimate),
                new DigimonTemp("МеталГреймон", "", "Д", "ВЖ", Rank.Ultimate),
                new DigimonTemp("Монзаемон", "", "Ц", "ВК", Rank.Ultimate),
                new DigimonTemp("Панджамон", "", "Б", "ВЛ", Rank.Ultimate),
                new DigimonTemp("Раидрамон", "", "А", "ВМ", Rank.Ultimate),
                new DigimonTemp("Увамон", "", "Ф", "ВО", Rank.Ultimate),
                new DigimonTemp("Блоссомон", "", "Г", "ДА", Rank.Ultimate),
                new DigimonTemp("БлюзМерамон", "", "Х", "ДБ", Rank.Ultimate),
                new DigimonTemp("Вермилимон", "", "М", "ДП", Rank.Ultimate),
                new DigimonTemp("Дерамон", "", "И", "ДЦ", Rank.Ultimate),
                new DigimonTemp("Дигитамамон", "", "Ж", "ДД", Rank.Ultimate),
                new DigimonTemp("Лилимон", "", "Г", "ДЕ", Rank.Ultimate),
                new DigimonTemp("Мамемон", "", "Ж", "ДФ", Rank.Ultimate),
                new DigimonTemp("МегаСидрамон", "", "К", "ДГ", Rank.Ultimate),
                new DigimonTemp("МеталМамемон", "", "Ж", "ДХ", Rank.Ultimate),
                new DigimonTemp("Метеормон", "", "Л", "ДИ", Rank.Ultimate),
                new DigimonTemp("Пиксимон", "", "И", "ДЖ", Rank.Ultimate),
                new DigimonTemp("Скорпиомон", "", "К", "ДЛ", Rank.Ultimate),
                new DigimonTemp("Тинмон", "", "Х", "ДН", Rank.Ultimate),
                new DigimonTemp("Трицерамон", "", "М", "ДО", Rank.Ultimate),
                new DigimonTemp("Тыквинмон", "", "Г", "ДК", Rank.Ultimate),
                new DigimonTemp("ЧерепМерамон", "", "Х", "ДМ", Rank.Ultimate),
                new DigimonTemp("Вадемон", "", "О", "РЗ", Rank.Ultimate),
                new DigimonTemp("ВаруМонзаемон", "", "З", "РР", Rank.Ultimate),
                new DigimonTemp("ВаруСидрамон", "", "П", "РС", Rank.Ultimate),
                new DigimonTemp("Гарбамон", "", "О", "РФ", Rank.Ultimate),
                new DigimonTemp("Гигадрамон", "", "Р", "РГ", Rank.Ultimate),
                new DigimonTemp("Датамон", "", "О", "РБ", Rank.Ultimate),
                new DigimonTemp("Драгомон", "", "П", "РЦ", Rank.Ultimate),
                new DigimonTemp("МаринеДевимон", "", "П", "РФ", Rank.Ultimate),
                new DigimonTemp("Мегадрамон", "", "Р", "РИ", Rank.Ultimate),
                new DigimonTemp("МеталТираномон", "", "Р", "РЖ", Rank.Ultimate),
                new DigimonTemp("Миотисмон", "", "С", "РК", Rank.Ultimate),
                new DigimonTemp("Окувамон", "", "Т", "РЛ", Rank.Ultimate),
                new DigimonTemp("Теккамон", "", "С", "РП", Rank.Ultimate),
                new DigimonTemp("Фантомон", "", "С", "РМ", Rank.Ultimate),
                new DigimonTemp("ЧерепоГреймон", "", "Р", "РО", Rank.Ultimate),
                new DigimonTemp("Черримон", "", "Н", "РА", Rank.Ultimate),
                new DigimonTemp("ШоганГекомон", "", "П", "РН", Rank.Ultimate),
                new DigimonTemp("ЭксТираномон", "", "Р", "РЕ", Rank.Ultimate),
                new DigimonTemp("Этемон", "", "З", "РД", Rank.Ultimate),
                new DigimonTemp("Баихумон", "", "Б", "", Rank.Mega),
                new DigimonTemp("БойГреймон", "", "Ф", "", Rank.Mega),
                new DigimonTemp("Болтмон", "", "Х", "", Rank.Mega),
                new DigimonTemp("ВеномМиотисмон", "", "П", "", Rank.Mega),
                new DigimonTemp("ГеркулкесКабутеримон", "", "А", "", Rank.Mega),
                new DigimonTemp("ГранКувагамон", "", "М", "", Rank.Mega),
                new DigimonTemp("Грифонмон", "", "И", "", Rank.Mega),
                new DigimonTemp("Диаборомон", "", "М", "", Rank.Mega),
                new DigimonTemp("Жижимон", "", "Ц", "", Rank.Mega),
                new DigimonTemp("Империалдрамон", "", "Б", "", Rank.Mega),
                new DigimonTemp("Магнадрамон", "", "Д", "", Rank.Mega),
                new DigimonTemp("МаринеАнгемон", "", "Е", "", Rank.Mega),
                new DigimonTemp("Машинедрамон", "", "Н", "", Rank.Mega),
                new DigimonTemp("МеталГарурумон", "", "Г", "", Rank.Mega),
                new DigimonTemp("МеталСидрамон", "", "Ж", "", Rank.Mega),
                new DigimonTemp("МеталЭтемон", "", "О", "", Rank.Mega),
                new DigimonTemp("Омнимон", "", "Ф", "", Rank.Mega),
                new DigimonTemp("Паппетмон", "", "Р", "", Rank.Mega),
                new DigimonTemp("Пречиомон", "", "Ж", "", Rank.Mega),
                new DigimonTemp("ПринцМамемон", "", "К", "", Rank.Mega),
                new DigimonTemp("Пукумон", "", "З", "", Rank.Mega),
                new DigimonTemp("Пьерротмон", "", "П", "", Rank.Mega),
                new DigimonTemp("Роземон", "", "Л", "", Rank.Mega),
                new DigimonTemp("СаберЛеомон", "", "К", "", Rank.Mega),
                new DigimonTemp("Серафимон", "", "Д", "", Rank.Mega),
                new DigimonTemp("СкуллМамонтмон", "", "Ц", "", Rank.Mega),
                new DigimonTemp("Фениксмон", "", "Б", "", Rank.Mega),

            };

            Dictionary<string, List<string>> champTableDictionary = new Dictionary<string, List<string>>()
            {
                {
                    "А",
                    new List<string>
                    {
                        "ВА",
                        "ВЖ",
                        "ДЦ",
                        "ВА",
                        "ВФ",
                        "ДЦ",
                        "ВА",
                        "ДХ",
                        "ДЕ",
                        "ДД",
                        "ДЦ",
                        "ДБ",
                        "ВА",
                        "ВИ",
                        "ВФ",
                        "ВХ",
                        "ВА",
                        "ВЕ",
                        "ВЖ",
                        "ДД",
                        "ВИ"
                    }
                },
                {
                    "Б",
                    new List<string>
                    {
                        "ВЖ",
                        "ВБ",
                        "ДД",
                        "ВБ",
                        "ВБ",
                        "ДД",
                        "ВБ",
                        "ДД",
                        "ДД",
                        "ДД",
                        "ДД",
                        "ДГ",
                        "ВЖ",
                        "ВБ",
                        "ВБ",
                        "ВХ",
                        "ВБ",
                        "ВХ",
                        "ВХ",
                        "ДД",
                        "ВБ"
                    }
                },
                {
                    "Г",
                    new List<string>
                    {
                        "ДЦ",
                        "ДД",
                        "ДЦ",
                        "ДЦ",
                        "ДД",
                        "ДЦ",
                        "РЕ",
                        "ДХ",
                        "ДЕ",
                        "ДД",
                        "ДЦ",
                        "ДБ",
                        "РА",
                        "РМ",
                        "РФ",
                        "РХ",
                        "РЕ",
                        "РЖ",
                        "ДД",
                        "ДД",
                        "ДХ"
                    }
                },
                {
                    "Д",
                    new List<string>
                    {
                        "ВА",
                        "ВБ",
                        "ДЦ",
                        "ВД",
                        "ВГ",
                        "ДБ",
                        "ВД",
                        "ДБ",
                        "ДФ",
                        "ДБ",
                        "ДБ",
                        "ДБ",
                        "ВА",
                        "ВД",
                        "ВГ",
                        "ВД",
                        "ВЕ",
                        "ВЕ",
                        "ВД",
                        "ДД",
                        "ВИ"
                    }
                },
                {
                    "Е",
                    new List<string>
                    {
                        "ВФ",
                        "ВБ",
                        "ДД",
                        "ВГ",
                        "ВГ",
                        "ДФ",
                        "ВГ",
                        "ДХ",
                        "ДЕ",
                        "ДД",
                        "ДФ",
                        "ДЕ",
                        "ВФ",
                        "ВИ",
                        "ВГ",
                        "ВХ",
                        "ВФ",
                        "ВГ",
                        "ВХ",
                        "ДД",
                        "ВИ"
                    }
                },
                {
                    "Ж",
                    new List<string>
                    {
                        "ДЦ",
                        "ДД",
                        "ДЦ",
                        "ДБ",
                        "ДФ",
                        "ДД",
                        "РЛ",
                        "ДБ",
                        "ДФ",
                        "ДБ",
                        "ДБ",
                        "ДБ",
                        "РЕ",
                        "РЖ",
                        "РК",
                        "РЛ",
                        "РЛ",
                        "РЖ",
                        "ДБ",
                        "ДД",
                        "ДБ"
                    }
                },
                {
                    "З",
                    new List<string>
                    {
                        "ВА",
                        "ВБ",
                        "РЕ",
                        "ВД",
                        "ВГ",
                        "РЛ",
                        "РЖ",
                        "РЖ",
                        "РК",
                        "РЛ",
                        "РЛ",
                        "РЖ",
                        "РЕ",
                        "РЖ",
                        "РД",
                        "РЛ",
                        "РК",
                        "РИ",
                        "ВД",
                        "РЛ",
                        "ВД"
                    }
                },
                {
                    "И",
                    new List<string>
                    {
                        "ДХ",
                        "ДД",
                        "ДХ",
                        "ДБ",
                        "ДХ",
                        "ДБ",
                        "РЖ",
                        "ДХ",
                        "ДХ",
                        "ДД",
                        "ДФ",
                        "ДГ",
                        "РМ",
                        "РБ",
                        "РД",
                        "РХ",
                        "РК",
                        "РИ",
                        "ДД",
                        "ДД",
                        "ДХ"
                    }
                },
                {
                    "К",
                    new List<string>
                    {
                        "ДЕ",
                        "ДД",
                        "ДЕ",
                        "ДФ",
                        "ДЕ",
                        "ДФ",
                        "РК",
                        "ДХ",
                        "ДЕ",
                        "ДД",
                        "ДФ",
                        "ДЕ",
                        "РФ",
                        "РД",
                        "РФ",
                        "РХ",
                        "РК",
                        "РФ",
                        "ДД",
                        "ДД",
                        "ДХ"
                    }
                },
                {
                    "Л",
                    new List<string>
                    {
                        "ДД",
                        "ДД",
                        "ДД",
                        "ДБ",
                        "ДД",
                        "ДБ",
                        "РЛ",
                        "ДД",
                        "ДД",
                        "ДД",
                        "ДА",
                        "ДД",
                        "РХ",
                        "РХ",
                        "РХ",
                        "РХ",
                        "РГ",
                        "РХ",
                        "ДД",
                        "ДД",
                        "ДД"
                    }
                },
                {
                    "М",
                    new List<string>
                    {
                        "ДЦ",
                        "ДД",
                        "ДЦ",
                        "ДБ",
                        "ДФ",
                        "ДБ",
                        "РЛ",
                        "ДФ",
                        "ДФ",
                        "ДА",
                        "ДА",
                        "ДА",
                        "РЕ",
                        "РК",
                        "РК",
                        "РГ",
                        "РГ",
                        "РГ",
                        "ДБ",
                        "ДД",
                        "ДФ"
                    }
                },
                {
                    "Н",
                    new List<string>
                    {
                        "ДБ",
                        "ДГ",
                        "ДБ",
                        "ДБ",
                        "ДЕ",
                        "ДБ",
                        "РЖ",
                        "ДГ",
                        "ДЕ",
                        "ДД",
                        "ДА",
                        "ДГ",
                        "РЖ",
                        "РИ",
                        "РФ",
                        "РХ",
                        "РГ",
                        "РИ",
                        "ДД",
                        "ДГ",
                        "ДГ"
                    }
                },
                {
                    "О",
                    new List<string>
                    {
                        "ВА",
                        "ВЖ",
                        "РА",
                        "ВА",
                        "ВФ",
                        "РЕ",
                        "РЕ",
                        "РМ",
                        "РФ",
                        "РХ",
                        "РЕ",
                        "РЖ",
                        "РА",
                        "РМ",
                        "РФ",
                        "РХ",
                        "РЖ",
                        "РЕ",
                        "ВХ",
                        "РЦ",
                        "ВИ"
                    }
                },
                {
                    "П",
                    new List<string>
                    {
                        "ВИ",
                        "ВБ",
                        "РМ",
                        "ВД",
                        "ВИ",
                        "РЖ",
                        "РЖ",
                        "РБ",
                        "РД",
                        "РХ",
                        "РК",
                        "РИ",
                        "РМ",
                        "РБ",
                        "РД",
                        "РХ",
                        "РК",
                        "РИ",
                        "ВХ",
                        "РЦ",
                        "ВЦ"
                    }
                },
                {
                    "Р",
                    new List<string>
                    {
                        "ВФ",
                        "ВБ",
                        "РФ",
                        "ВГ",
                        "ВГ",
                        "РК",
                        "РД",
                        "РД",
                        "РФ",
                        "РХ",
                        "РК",
                        "РФ",
                        "РФ",
                        "РД",
                        "РФ",
                        "РХ",
                        "РК",
                        "РФ",
                        "ВХ",
                        "РЦ",
                        "ВИ"
                    }
                },
                {
                    "С",
                    new List<string>
                    {
                        "ВХ",
                        "ВХ",
                        "РХ",
                        "ВД",
                        "ВХ",
                        "РЛ",
                        "РЛ",
                        "РХ",
                        "РХ",
                        "РХ",
                        "РГ",
                        "РХ",
                        "РХ",
                        "РХ",
                        "РХ",
                        "РХ",
                        "РГ",
                        "РХ",
                        "ВХ",
                        "РХ",
                        "ВХ"
                    }
                },
                {
                    "Т",
                    new List<string>
                    {
                        "ВА",
                        "ВБ",
                        "РЕ",
                        "ВЕ",
                        "ВФ",
                        "РЛ",
                        "РК",
                        "РК",
                        "РК",
                        "РГ",
                        "РГ",
                        "РГ",
                        "РЕ",
                        "РК",
                        "РК",
                        "РГ",
                        "РГ",
                        "РГ",
                        "ВХ",
                        "РЦ",
                        "ВФ"
                    }
                },
                {
                    "У",
                    new List<string>
                    {
                        "ВЕ",
                        "ВХ",
                        "РЖ",
                        "ВЕ",
                        "ВГ",
                        "РЖ",
                        "РИ",
                        "РИ",
                        "РФ",
                        "РХ",
                        "РГ",
                        "РИ",
                        "РЖ",
                        "РИ",
                        "РФ",
                        "РХ",
                        "РГ",
                        "РИ",
                        "ВХ",
                        "РИ",
                        "ВХ"
                    }
                },
                {
                    "Ф",
                    new List<string>
                    {
                        "ВЖ",
                        "ВХ",
                        "ДД",
                        "ВД",
                        "ВХ",
                        "ДБ",
                        "ВД",
                        "ДД",
                        "ДД",
                        "ДД",
                        "ДА",
                        "ДД",
                        "ВХ",
                        "ВХ",
                        "ВХ",
                        "ВХ",
                        "ВХ",
                        "ВХ",
                        "ВХ",
                        "ДД",
                        "ВХ"
                    }
                },
                {
                    "Х",
                    new List<string>
                    {
                        "ДД",
                        "ДД",
                        "ДД",
                        "ДД",
                        "ДД",
                        "ДД",
                        "РЛ",
                        "ДД",
                        "ДД",
                        "ДД",
                        "ДД",
                        "ДГ",
                        "РЦ",
                        "РЦ",
                        "РЦ",
                        "РХ",
                        "РЦ",
                        "РИ",
                        "ДД",
                        "ДД",
                        "ДД"
                    }
                },
                {
                    "Ц",
                    new List<string>
                    {
                        "ВИ",
                        "ВБ",
                        "ДХ",
                        "ВИ",
                        "ВИ",
                        "ДБ",
                        "ВД",
                        "ДХ",
                        "ДХ",
                        "ДД",
                        "ДФ",
                        "ДГ",
                        "ВИ",
                        "ВЦ",
                        "ВИ",
                        "ВХ",
                        "ВФ",
                        "ВХ",
                        "ВХ",
                        "ДД",
                        "ВЦ"
                    }
                },
            };
            Dictionary<string, List<string>> ultimaTableDictionary = new Dictionary<string, List<string>>()
            {
                {
                    "А",
                    new List<string>
                    {
                        "ВД",
                        "ВУ",
                        "ДВ",
                        "ВУ",
                        "ВМ",
                        "ДИ",
                        "ВЗ",
                        "ДЖ",
                        "ДА",
                        "ДЖ",
                        "ДА",
                        "ВМ",
                        "ВА",
                        "ВА",
                        "ВУ",
                        "ВУ",
                        "ВМ",
                        "ВА",
                        "ДИ",
                        "ВЗ"
                    }
                },
                {
                    "Б",
                    new List<string>
                    {
                        "ВУ",
                        "ВБ",
                        "ДВ",
                        "ВИ",
                        "ВМ",
                        "ДТ",
                        "ВН",
                        "ДИ",
                        "ДР",
                        "ДО",
                        "ДШ",
                        "ВМ",
                        "ВГ",
                        "ВЛ",
                        "ВИ",
                        "ВБ",
                        "ВМ",
                        "ВЛ",
                        "ДБ",
                        "ВН"
                    }
                },
                {
                    "Г",
                    new List<string>
                    {
                        "ДВ",
                        "ДВ",
                        "ДВ",
                        "ДМ",
                        "ДЯ",
                        "ДВ",
                        "РР",
                        "ДВ",
                        "ДМ",
                        "ДХ",
                        "ДМ",
                        "РЩ",
                        "РТ",
                        "РК",
                        "РК",
                        "РУ",
                        "РН",
                        "ДМ",
                        "ДЦ",
                        "ДХ"
                    }
                },
                {
                    "Д",
                    new List<string>
                    {
                        "ВУ",
                        "ВИ",
                        "ДМ",
                        "ВЖ",
                        "ВМ",
                        "ДШ",
                        "ВР",
                        "ДА",
                        "ДФ",
                        "ДЕ",
                        "ДЮ",
                        "МУ",
                        "ВЖ",
                        "ВЖ",
                        "ВЖ",
                        "ВИ",
                        "ВМ",
                        "ВР",
                        "ДЛ",
                        "ВР"
                    }
                },
                {
                    "Е",
                    new List<string>
                    {
                        "ВМ",
                        "ВМ",
                        "ДЯ",
                        "ВМ",
                        "ВМ",
                        "ДЗ",
                        "ВМ",
                        "ДЯ",
                        "ДС",
                        "ДЗ",
                        "ДЗ",
                        "ВМ",
                        "ВМ",
                        "ВЕ",
                        "ВМ",
                        "ВМ",
                        "ВМ",
                        "ВЕ",
                        "ДУ",
                        "ВМ"
                    }
                },
                {
                    "Ж",
                    new List<string>
                    {
                        "ДИ",
                        "ДТ",
                        "ДВ",
                        "ДШ",
                        "ДЗ",
                        "ДТ",
                        "РА",
                        "ДИ",
                        "ДР",
                        "ДО",
                        "ДШ",
                        "РУ",
                        "РЛ",
                        "РЖ",
                        "РМ",
                        "РГ",
                        "РН",
                        "ДР",
                        "ДБ",
                        "ДО"
                    }
                },
                {
                    "З",
                    new List<string>
                    {
                        "ВЗ",
                        "ВН",
                        "РР",
                        "ВР",
                        "ВМ",
                        "РА",
                        "РР",
                        "РХ",
                        "РЛ",
                        "РР",
                        "РР",
                        "РР",
                        "РЛ",
                        "РЛ",
                        "РР",
                        "РА",
                        "РН",
                        "ВО",
                        "РЛ",
                        "ВХ"
                    }
                },
                {
                    "И",
                    new List<string>
                    {
                        "ДЖ",
                        "ДИ",
                        "ДВ",
                        "ДА",
                        "ДЯ",
                        "ДИ",
                        "РХ",
                        "ДЖ",
                        "ДИ",
                        "ДИ",
                        "ДА",
                        "РЯ",
                        "РХ",
                        "РХ",
                        "РХ",
                        "РХ",
                        "РН",
                        "ДА",
                        "ДИ",
                        "ДЖ"
                    }
                },
                {
                    "К",
                    new List<string>
                    {
                        "ДА",
                        "ДР",
                        "ДМ",
                        "ДП",
                        "ДФ",
                        "ДР",
                        "РЛ",
                        "ДИ",
                        "ДР",
                        "ДП",
                        "ДФ",
                        "РК",
                        "РЗ",
                        "РЗ",
                        "РЦ",
                        "РЖ",
                        "РЖ",
                        "ДР",
                        "ДС",
                        "ДП"
                    }
                },
                {
                    "Л",
                    new List<string>
                    {
                        "ДЖ",
                        "ДО",
                        "ДХ",
                        "ДЕ",
                        "ДЗ",
                        "ДО",
                        "РР",
                        "ДИ",
                        "ДП",
                        "ДГ",
                        "ДЕ",
                        "РР",
                        "РЛ",
                        "РЛ",
                        "РР",
                        "РА",
                        "РН",
                        "ДП",
                        "ДБ",
                        "ДГ"
                    }
                },
                {
                    "М",
                    new List<string>
                    {
                        "ДА",
                        "ДШ",
                        "ДМ",
                        "ДЮ",
                        "ДЗ",
                        "ДШ",
                        "РР",
                        "ДА",
                        "ДФ",
                        "ДЕ",
                        "ДЮ",
                        "РК",
                        "РБ",
                        "РЦ",
                        "РД",
                        "РМ",
                        "РН",
                        "ДП",
                        "ДЛ",
                        "ДЕ"
                    }
                },
                {
                    "Н",
                    new List<string>
                    {
                        "ВМ",
                        "ВМ",
                        "РЩ",
                        "МУ",
                        "ВМ",
                        "РУ",
                        "РР",
                        "РЯ",
                        "РК",
                        "РР",
                        "РК",
                        "РЩ",
                        "РТ",
                        "РК",
                        "РК",
                        "РУ",
                        "РН",
                        "МУ",
                        "РТ",
                        "ВТ"
                    }
                },
                {
                    "О",
                    new List<string>
                    {
                        "ВА",
                        "ВГ",
                        "РТ",
                        "РЖ",
                        "РМ",
                        "РЛ",
                        "РЛ",
                        "РХ",
                        "РЗ",
                        "РЛ",
                        "РБ",
                        "РТ",
                        "РИ",
                        "РЗ",
                        "РБ",
                        "РЛ",
                        "РС",
                        "ВЕ",
                        "РИ",
                        "ВЦ"
                    }
                },
                {
                    "П",
                    new List<string>
                    {
                        "ВА",
                        "ВЛ",
                        "РК",
                        "ВЖ",
                        "ВЕ",
                        "РЖ",
                        "РЛ",
                        "РХ",
                        "РЗ",
                        "РЛ",
                        "РЦ",
                        "РК",
                        "РЗ",
                        "РЗ",
                        "РЦ",
                        "РЖ",
                        "РЖ",
                        "ВЛ",
                        "РЗ",
                        "ВО"
                    }
                },
                {
                    "Р",
                    new List<string>
                    {
                        "ВУ",
                        "ВИ",
                        "РК",
                        "ВЖ",
                        "ВМ",
                        "РМ",
                        "РР",
                        "РХ",
                        "РЦ",
                        "РР",
                        "РД",
                        "РК",
                        "РБ",
                        "РЦ",
                        "РД",
                        "РМ",
                        "РН",
                        "ВЖ",
                        "РБ",
                        "ВР"
                    }
                },
                {
                    "С",
                    new List<string>
                    {
                        "ВУ",
                        "ВБ",
                        "РУ",
                        "ВИ",
                        "ВМ",
                        "РГ",
                        "РА",
                        "РХ",
                        "РЖ",
                        "РА",
                        "РМ",
                        "РУ",
                        "РЛ",
                        "РЖ",
                        "РМ",
                        "РГ",
                        "РН",
                        "ВЛ",
                        "РЛ",
                        "ВН"
                    }
                },
                {
                    "Т",
                    new List<string>
                    {
                        "ВМ",
                        "ВМ",
                        "РН",
                        "ВМ",
                        "ВМ",
                        "РН",
                        "РН",
                        "РН",
                        "РЖ",
                        "РН",
                        "РН",
                        "РН",
                        "РС",
                        "РЖ",
                        "РН",
                        "РН",
                        "РН",
                        "ВЕ",
                        "РС",
                        "ВМ"
                    }
                },
                {
                    "Ф",
                    new List<string>
                    {
                        "ВА",
                        "ВЛ",
                        "ДМ",
                        "ВР",
                        "ВЕ",
                        "ДР",
                        "ВО",
                        "ДА",
                        "ДР",
                        "ДП",
                        "ДФ",
                        "МУ",
                        "ВЕ",
                        "ВЛ",
                        "ВЖ",
                        "ВЛ",
                        "ВЕ",
                        "ВЛ",
                        "ДС",
                        "ВО"
                    }
                },
                {
                    "Х",
                    new List<string>
                    {
                        "ДИ",
                        "ДБ",
                        "ДЦ",
                        "ДЛ",
                        "ДУ",
                        "ДБ",
                        "РЛ",
                        "ДИ",
                        "ДС",
                        "ДБ",
                        "ДЛ",
                        "РТ",
                        "РИ",
                        "РЗ",
                        "РБ",
                        "РЛ",
                        "РС",
                        "ДС",
                        "ДК",
                        "ДН"
                    }
                },
                {
                    "Ц",
                    new List<string>
                    {
                        "ВЗ",
                        "ВН",
                        "ДХ",
                        "ВР",
                        "ВМ",
                        "ДО",
                        "ВХ",
                        "ДЖ",
                        "ДП",
                        "ДГ",
                        "ДЕ",
                        "ВТ",
                        "ВЦ",
                        "ВО",
                        "ВР",
                        "ВН",
                        "ВМ",
                        "ВО",
                        "ДН",
                        "ВХ"
                    }
                },

            };
            Dictionary<string, List<string>> megaTableDictionary = new Dictionary<string, List<string>>()
            {
                {
                    "А",
                    new List<string>
                    {
                        "ВИ",
                        "ВИ",
                        "МУ",
                        "ВИ",
                        "ВП",
                        "ДГ",
                        "ВП",
                        "МУ",
                        "МУ",
                        "МУ",
                        "ВИ",
                        "ВИ",
                        "ВИ",
                        "ВИ",
                        "ВИ",
                        "ВИ",
                        "ДМ",
                        "ВИ"
                    }
                },
                {
                    "Б",
                    new List<string>
                    {
                        "ВИ",
                        "ВД",
                        "ДЦ",
                        "ВД",
                        "ВА",
                        "ДЦ",
                        "ВА",
                        "ДЦ",
                        "ДЖ",
                        "ДА",
                        "ВИ",
                        "ВА",
                        "ВА",
                        "ВД",
                        "ВИ",
                        "ВА",
                        "ДЖ",
                        "ВА"
                    }
                },
                {
                    "Г",
                    new List<string>
                    {
                        "МУ",
                        "ДЦ",
                        "ДИ",
                        "ДФ",
                        "ДИ",
                        "ДИ",
                        "РР",
                        "ДЦ",
                        "ДФ",
                        "ДИ",
                        "РЛ",
                        "РД",
                        "РД",
                        "РМ",
                        "РД",
                        "ДИ",
                        "ДИ",
                        "ДИ"
                    }
                },
                {
                    "Д",
                    new List<string>
                    {
                        "ВИ",
                        "ВД",
                        "ДФ",
                        "ВФ",
                        "ВП",
                        "ДГ",
                        "ВП",
                        "ДЖ",
                        "ДХ",
                        "ДК",
                        "ВИ",
                        "ВБ",
                        "ВЛ",
                        "ВФ",
                        "ВИ",
                        "ВБ",
                        "ДИ",
                        "ВЛ"
                    }
                },
                {
                    "Е",
                    new List<string>
                    {
                        "ВП",
                        "ВА",
                        "ДИ",
                        "ВП",
                        "ВП",
                        "ДГ",
                        "ВО",
                        "ДЦ",
                        "ДГ",
                        "ДЛ",
                        "ВО",
                        "ВХ",
                        "ВГ",
                        "ВП",
                        "ВП",
                        "ВХ",
                        "ДЛ",
                        "ВГ"
                    }
                },
                {
                    "Ж",
                    new List<string>
                    {
                        "ДГ",
                        "ДЦ",
                        "ДИ",
                        "ДГ",
                        "ДГ",
                        "ДГ",
                        "РЦ",
                        "ДЦ",
                        "ДГ",
                        "ДЛ",
                        "РН",
                        "РО",
                        "РР",
                        "РН",
                        "РХ",
                        "ДП",
                        "ДЛ",
                        "ДИ"
                    }
                },
                {
                    "З",
                    new List<string>
                    {
                        "ВП",
                        "ВА",
                        "РР",
                        "ВП",
                        "ВО",
                        "РЦ",
                        "РЦ",
                        "РЛ",
                        "РН",
                        "РХ",
                        "РН",
                        "РО",
                        "РР",
                        "РН",
                        "РХ",
                        "ВХ",
                        "РС",
                        "ВГ"
                    }
                },
                {
                    "И",
                    new List<string>
                    {
                        "МУ",
                        "ДЦ",
                        "ДЦ",
                        "ДЖ",
                        "ДЦ",
                        "ДЦ",
                        "РЛ",
                        "ДЦ",
                        "ДЖ",
                        "ДА",
                        "РЛ",
                        "РЛ",
                        "РЛ",
                        "РЛ",
                        "РА",
                        "ДЖ",
                        "ДЖ",
                        "ДЦ"
                    }
                },
                {
                    "К",
                    new List<string>
                    {
                        "МУ",
                        "ДЖ",
                        "ДФ",
                        "ДХ",
                        "ДГ",
                        "ДГ",
                        "РН",
                        "ДЖ",
                        "ДХ",
                        "ДК",
                        "РЛ",
                        "РП",
                        "РМ",
                        "РК",
                        "РА",
                        "ДД",
                        "ДИ",
                        "ДФ"
                    }
                },
                {
                    "Л",
                    new List<string>
                    {
                        "МУ",
                        "ДА",
                        "ДИ",
                        "ДК",
                        "ДЛ",
                        "ДЛ",
                        "РХ",
                        "ДА",
                        "ДК",
                        "ДЕ",
                        "РЛ",
                        "РХ",
                        "РД",
                        "РА",
                        "РА",
                        "ДЛ",
                        "ДБ",
                        "ДИ"
                    }
                },
                {
                    "М",
                    new List<string>
                    {
                        "ВИ",
                        "ВИ",
                        "РЛ",
                        "ВИ",
                        "ВО",
                        "РН",
                        "РН",
                        "РЛ",
                        "РЛ",
                        "РЛ",
                        "РЛ",
                        "РЛ",
                        "РЛ",
                        "РЛ",
                        "РЛ",
                        "ВИ",
                        "РЗ",
                        "ВИ"
                    }
                },
                {
                    "Н",
                    new List<string>
                    {
                        "ВИ",
                        "ВА",
                        "РД",
                        "ВБ",
                        "ВХ",
                        "ВО",
                        "РО",
                        "РЛ",
                        "РП",
                        "РХ",
                        "РЛ",
                        "РИ",
                        "РД",
                        "РП",
                        "РХ",
                        "ВЖ",
                        "РЕ",
                        "ВН"
                    }
                },
                {
                    "О",
                    new List<string>
                    {
                        "ВИ",
                        "ВА",
                        "РД",
                        "ВЛ",
                        "ВГ",
                        "РР",
                        "РР",
                        "РЛ",
                        "РМ",
                        "РД",
                        "РЛ",
                        "РД",
                        "РД",
                        "РМ",
                        "РД",
                        "ВР",
                        "РР",
                        "ВР"
                    }
                },
                {
                    "П",
                    new List<string>
                    {
                        "ВИ",
                        "ВД",
                        "РМ",
                        "ВФ",
                        "ВП",
                        "РН",
                        "РН",
                        "РЛ",
                        "РК",
                        "РА",
                        "РЛ",
                        "РП",
                        "РМ",
                        "РК",
                        "РА",
                        "ВБ",
                        "РР",
                        "ВЛ"
                    }
                },
                {
                    "Р",
                    new List<string>
                    {
                        "ВИ",
                        "ВИ",
                        "РД",
                        "ВИ",
                        "ВП",
                        "РХ",
                        "РХ",
                        "РА",
                        "РА",
                        "РА",
                        "РЛ",
                        "РХ",
                        "РД",
                        "РА",
                        "РА",
                        "ВП",
                        "РФ",
                        "ВК"
                    }
                },
                {
                    "Ф",
                    new List<string>
                    {
                        "ВИ",
                        "ВА",
                        "ДИ",
                        "ВБ",
                        "ВХ",
                        "ДП",
                        "ВХ",
                        "ДЖ",
                        "ДД",
                        "ДЛ",
                        "ВИ",
                        "ВЖ",
                        "ВН",
                        "ВБ",
                        "ВП",
                        "ВЖ",
                        "ДО",
                        "ВН"
                    }
                },
                {
                    "Х",
                    new List<string>
                    {
                        "ДМ",
                        "ДЖ",
                        "ДИ",
                        "ДИ",
                        "ДЛ",
                        "ДЛ",
                        "РС",
                        "ДЖ",
                        "ДИ",
                        "ДБ",
                        "РЗ",
                        "РЕ",
                        "РР",
                        "РР",
                        "РФ",
                        "ДО",
                        "ДН",
                        "ДИ"
                    }
                },
                {
                    "Ц",
                    new List<string>
                    {
                        "ВИ",
                        "ВА",
                        "ДИ",
                        "ВЛ",
                        "ВГ",
                        "ДИ",
                        "ВГ",
                        "ДЦ",
                        "ДФ",
                        "ДИ",
                        "ВИ",
                        "ВН",
                        "ВН",
                        "ВЛ",
                        "ВК",
                        "ВН",
                        "ДИ",
                        "ВН"
                    }
                },
            };


            var temp = new List<Digimon>();

            //ищем английские имена
            foreach (var digimon in rookie)
            {
                var firstOrDefault =
                    DataBase.DB.Digimons.FirstOrDefault(x => x.NameRus.ToLower() == digimon.NameRus.ToLower());
                if (firstOrDefault != null)
                {
                    digimon.NameEng = firstOrDefault.NameEng;
                    digimon.Digimon = firstOrDefault;
                    temp.Add(firstOrDefault);
                }
                else
                {
                    Console.WriteLine(digimon.NameRus);
                }
            }




            var errors = new List<string>();
            //новая колекция без новичков, их скрещивать не надо
            var notRookee = rookie.Where(x => x.Rank != Rank.Rookie).ToList();

            foreach (var parent1 in notRookee)
            {
                foreach (var parent2 in notRookee)
                {
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
                            parent22 = Down(parent22, notRookee);
                        } while (parent11.Rank != parent22.Rank);

                    }
                    Dictionary<string, List<string>> dic;
                    switch (parent11.Rank)
                    {
                        case Rank.Champion:
                            dic = champTableDictionary;
                            break;
                        case Rank.Ultimate:
                            dic = ultimaTableDictionary;
                            break;
                        case Rank.Mega:
                            dic = megaTableDictionary;
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
                            result = rookie.FirstOrDefault(x => x.Rank == Rank.Rookie && x.ResultCode == strResult);
                            break;
                        case Rank.Ultimate:
                            result = rookie.FirstOrDefault(x => x.Rank == Rank.Champion && x.ResultCode == strResult);
                            break;
                        case Rank.Mega:
                            result = rookie.FirstOrDefault(x => x.Rank == Rank.Ultimate && x.ResultCode == strResult);
                            break;
                        default:
                            throw new ArgumentOutOfRangeException();
                    }

                    if (result == null)
                    {
                        errors.Add(parent11.NameEng+"-"+parent11.NameRus + "-" + parent11.Rank);
                        errors.Add(parent22.NameEng+"-"+parent22.NameRus + "-" + parent22.Rank);

                        Console.WriteLine("Parent1={0}(Rank={4})\tParent2={1}(Rank={5})\tParent11={2}(Rank={6})\tParent22={3}(Rank={7})", 
                            parent1.NameEng,parent2.NameEng,parent11.NameEng,parent22.NameEng,
                            parent1.Rank,parent2.Rank,parent11.Rank,parent22.Rank);
                       
                        continue;
                    }

                    var first =
                        DB.DigivolvesDNA.Any(
                            x => x.DigimonParent1Id == parent1.NameEng && x.DigimonParent2Id == parent2.NameEng);

                    var second =
                        DB.DigivolvesDNA.Any(
                            x => x.DigimonParent2Id == parent1.NameEng && x.DigimonParent1Id == parent2.NameEng);
                    if(!first && !second)
                        DB.DigivolvesDNA.Add(new DigivolveDNA(parent1.NameEng,parent2.NameEng,result.NameEng));


                }
            }

            foreach (var error in errors.GroupBy(x=>x).OrderByDescending(x=>x.Count()))
            {
                Console.WriteLine("{0}-{1}",error.Key,error.Count());
            }



        }


        public DigimonTemp Down(DigimonTemp temp, List<DigimonTemp> list)
        {
            var down = DataBase.DB.Digivolves.FirstOrDefault(x => x.DigimonToId == temp.NameEng);
            if (down == null)
                throw new ApplicationException();
            var digimonTemp = list.FirstOrDefault(x => x.NameEng == down.DigimonFromId);
            if (digimonTemp == null)
                throw new ApplicationException();
            return digimonTemp;
        }
    }
}
