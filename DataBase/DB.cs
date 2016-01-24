using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBase
{
    public static class DB
    {

        public static List<DigivolveDNA> DigivolvesDNA = new List<DigivolveDNA>();


        public static List<Skill> Skills = new List<Skill>()
        {
            new Skill("Agumon",SkillType.Attack,"Перцовое дыхание","Pepper Breath","Стреляет огненным шаром", "Small fireball attack", 8,20.5m,SkillSource.Wild),
        };

        public static List<Domain> Domains = new List<Domain>
        {
            new Domain("Драйв","Drive"),
            new Domain("Новый Драйв","Drive 2"),
            new Domain("СКЗИ","SCSI"),
        };

        public static Domain GetDomain(string domainId)
        {
            return Domains.FirstOrDefault(x => x.Id == domainId);
        }


        public static List<Location> Locations = new List<Location>()
        {
            new Location("Betamon",GetDomain("SCSI"),new List<int>() {2}),
            new Location("Agumon","You get as partner when you join the Gold Hawk Guard Team", "Станет вашим партнером при присоединении к Золотым Соколам")

        }; 


        public static List<Digivolve> Digivolves = new List<Digivolve>()
        {
            new Digivolve("Agumon","Greymon",0),
            new Digivolve("Betamon","DarkTyrannomon",0),
            new Digivolve("Betamon","DarkLizardmon",3),
            new Digivolve("Betamon","Tuskmon",6),
            new Digivolve("Veemon","Veedramon",0),
            new Digivolve("Veemon","Flamedramon",4),
            new Digivolve("Gabumon","Centarumon",0),
            new Digivolve("Gabumon","Drimogemon",3),
            new Digivolve("Gabumon","NiseDrimogemon",6),
            new Digivolve("Gabumon","Garurumon",8),
            new Digivolve("Gazimon","Nanimon",0),
            new Digivolve("Gizamon","Cyclonemon",0),
            new Digivolve("Gizamon","Deltamon",3),
            new Digivolve("Gizamon","Devidramon",6),
            new Digivolve("Goburimon","Ogremon",0),
            new Digivolve("Gomamon","Tortomon",0),
            new Digivolve("Gomamon","Ikkakumon",3),
            new Digivolve("Gotsumon","Icemon",0),
            new Digivolve("Gotsumon","MudFrigimon",3),
            new Digivolve("Gotsumon","JungleMojyamon",6),
            new Digivolve("DemiDevimon","IceDevimon",0),
            new Digivolve("DemiDevimon","Devimon",4),
            new Digivolve("Dokunemon","Flymon",0),
            new Digivolve("ClearAgumon","Angemon",0),
            new Digivolve("ClearAgumon","Piddomon",3),
            new Digivolve("Candlemon","Tankmon",0),
            new Digivolve("Candlemon","Meramon",3),
            new Digivolve("Candlemon","Clockmon",6),
            new Digivolve("Crabmon","Coelamon",0),
            new Digivolve("Crabmon","MoriShellmon",3),
            new Digivolve("Crabmon","Shellmon",6),
            new Digivolve("Crabmon","Seadramon",8),
            new Digivolve("Kunemon","Kuwagamon",0),
            new Digivolve("Mushroomon","Vegiemon",0),
            new Digivolve("Mushroomon","RedVegiemon",1),
            new Digivolve("Mushroomon","Woodmon",4),
            new Digivolve("Otamamon","Gekomon",0),
            new Digivolve("Otamamon","Octomon",3),
            new Digivolve("Palmon","Togemon",0),
            new Digivolve("Patamon","Ninjamon",0),
            new Digivolve("Patamon","Starmon",3),
            new Digivolve("Patamon","Wizardmon",6),
            new Digivolve("Patamon","Angemon",8),
            new Digivolve("Biyomon","Airdramon",0),
            new Digivolve("Biyomon","Veedramon",3),
            new Digivolve("Biyomon","Saberdramon",6),
            new Digivolve("Biyomon","Birdramon",8),
            new Digivolve("Penguinmon","Ikkakumon",0),
            new Digivolve("Penguinmon","Dolphmon",3),
            new Digivolve("Syakomon","Octomon",0),
            new Digivolve("Syakomon","Gesomon",3),
            new Digivolve("SnowAgumon","Frigimon",0),
            new Digivolve("SnowAgumon","Mojyamon",3),
            new Digivolve("SnowAgumon","Gururumon",6),
            new Digivolve("SnowGoburimon","Hyogamon",0),
            new Digivolve("Tapirmon","Unimon",0),
            new Digivolve("Tapirmon","ShimaUnimon",3),
            new Digivolve("Tapirmon","Garurumon",6),
            new Digivolve("Tapirmon","Apemon",8),
            new Digivolve("Tentomon","Kabuterimon",0),
            new Digivolve("ToyAgumon","Leomon",0),
            new Digivolve("ToyAgumon","Gatomon",3),
            new Digivolve("Floramon","Kiwimon",0),
            new Digivolve("Floramon","Kokatorimon",3),
            new Digivolve("Floramon","Akatorimon",6),
            new Digivolve("Hagurumon","Numemon",0),
            new Digivolve("Hagurumon","Sukamon",1),
            new Digivolve("Hagurumon","PlatinumSukamon",2),
            new Digivolve("Hagurumon","Raremon",4),
            new Digivolve("Hagurumon","Guardromon",6),
            new Digivolve("Tsukaimon","Bakemon",0),
            new Digivolve("Tsukaimon","Soulmon",3),
            new Digivolve("Elecmon","Tyrannomon",0),
            new Digivolve("Elecmon","FlareLizardmon",3),
            new Digivolve("Elecmon","Monochromon",6),
            new Digivolve("Airdramon","AeroVeedramon",0),
            new Digivolve("Angemon","Andromon",0),
            new Digivolve("Angemon","MagnaAngemon",6),
            new Digivolve("Birdramon","Garudamon",0),
            new Digivolve("Veedramon","AeroVeedramon",0),
            new Digivolve("Garurumon","WereGarurumon",0),
            new Digivolve("Gatomon","Angewomon",0),
            new Digivolve("Greymon","MetalGreymon",0),
            new Digivolve("Greymon","MasterTyrannomon",6),
            new Digivolve("Greymon","SkullGreymon",9),
            new Digivolve("Gururumon","WereGarurumon",0),
            new Digivolve("Dolphmon","Whamon",0),
            new Digivolve("Ikkakumon","Whamon",0),
            new Digivolve("Ikkakumon","Zudomon",6),
            new Digivolve("Kabuterimon","MegaKabuterimon",0),
            new Digivolve("Leomon","Panjyamon",0),
            new Digivolve("Mojyamon","Monzaemon",0),
            new Digivolve("Piddomon","MagnaAngemon",0),
            new Digivolve("Piddomon","Giromon",6),
            new Digivolve("Saberdramon","Garudamon",0),
            new Digivolve("Tortomon","Zudomon",0),
            new Digivolve("Unimon","Mammothmon",0),
            new Digivolve("Flamedramon","AeroVeedramon",0),
            new Digivolve("Flamedramon","Raidramon",6),
            new Digivolve("Frigimon","Monzaemon",0),
            new Digivolve("ShimaUnimon","Mammothmon",0),
            new Digivolve("Apemon","Mammothmon",0),
            new Digivolve("IceDevimon","Myotismon",0),
            new Digivolve("Bakemon","Phantomon",0),
            new Digivolve("Vegiemon","Cherrymon",0),
            new Digivolve("Woodmon","Cherrymon",0),
            new Digivolve("Guardromon","Vademon",0),
            new Digivolve("Guardromon","Garbagemon",6),
            new Digivolve("Guardromon","Datamon",9),
            new Digivolve("Gekomon","ShogunGekomon",0),
            new Digivolve("Gesomon","MarineDevimon",0),
            new Digivolve("Gesomon","WaruSeadramon",6),
            new Digivolve("DarkLizardmon","ExTyrannomon",0),
            new Digivolve("DarkTyrannomon","ExTyrannomon",0),
            new Digivolve("DarkTyrannomon","MetalTyrannomon",6),
            new Digivolve("Devidramon","Gigadramon",0),
            new Digivolve("Devimon","Myotismon",0),
            new Digivolve("Deltamon","Megadramon",0),
            new Digivolve("Deltamon","Gigadramon",6),
            new Digivolve("Kuwagamon","Okuwamon",0),
            new Digivolve("Nanimon","Tekkamon",0),
            new Digivolve("Ogremon","Etemon",0),
            new Digivolve("Octomon","Dragomon",0),
            new Digivolve("PlatinumSukamon","Vademon",0),
            new Digivolve("Raremon","Vademon",0),
            new Digivolve("Raremon","Garbagemon",5),
            new Digivolve("RedVegiemon","Cherrymon",0),
            new Digivolve("Soulmon","Phantomon",0),
            new Digivolve("Tuskmon","MetalTyrannomon",0),
            new Digivolve("Flymon","Okuwamon",0),
            new Digivolve("Hyogamon","WaruMonzaemon",0),
            new Digivolve("Cyclonemon","Megadramon",0),
            new Digivolve("Icemon","Meteormon",0),
            new Digivolve("Akatorimon","Piximon",0),
            new Digivolve("Wizardmon","Digitamamon",0),
            new Digivolve("Drimogemon","Meteormon",0),
            new Digivolve("JungleMojyamon","Meteormon",0),
            new Digivolve("Centarumon","Meteormon",0),
            new Digivolve("Kiwimon","Deramon",0),
            new Digivolve("Clockmon","Tinmon",0),
            new Digivolve("Clockmon","SkullMeramon",8),
            new Digivolve("Coelamon","MegaSeadramon",0),
            new Digivolve("Kokatorimon","Deramon",0),
            new Digivolve("Kokatorimon","Piximon",6),
            new Digivolve("Meramon","BlueMeramon",0),
            new Digivolve("Meramon","SkullMeramon",6),
            new Digivolve("Monochromon","Vermilimon",0),
            new Digivolve("MoriShellmon","Scorpiomon",0),
            new Digivolve("MudFrigimon","Meteormon",0),
            new Digivolve("NiseDrimogemon","Meteormon",0),
            new Digivolve("Ninjamon","Mamemon",0),
            new Digivolve("Seadramon","MegaSeadramon",0),
            new Digivolve("Starmon","Mamemon",0),
            new Digivolve("Starmon","MetalMamemon",6),
            new Digivolve("Starmon","Digitamamon",8),
            new Digivolve("Tankmon","Tinmon",0),
            new Digivolve("Tankmon","SkullMeramon",6),
            new Digivolve("Tyrannomon","Triceramon",0),
            new Digivolve("Tyrannomon","MasterTyrannomon",8),
            new Digivolve("Togemon","Pumpkinmon",0),
            new Digivolve("Togemon","Blossomon",6),
            new Digivolve("Togemon","Lillymon",8),
            new Digivolve("FlareLizardmon","Triceramon",0),
            new Digivolve("FlareLizardmon","Vermilimon",6),
            new Digivolve("Shellmon","Scorpiomon",0),
            new Digivolve("Yanmamon","Pumpkinmon",0),
            new Digivolve("Angewomon","Magnadramon",0),
            new Digivolve("Andromon","Seraphimon",0),
            new Digivolve("AeroVeedramon","Phoenixmon",0),
            new Digivolve("Blossomon","Rosemon",0),
            new Digivolve("BlueMeramon","Boltmon",0),
            new Digivolve("WaruMonzaemon","MetalEtemon",0),
            new Digivolve("WaruSeadramon","Pukumon",0),
            new Digivolve("WereGarurumon","SkullMammothmon",0),
            new Digivolve("WereGarurumon","MetalGarurumon",8),
            new Digivolve("Garudamon","Phoenixmon",0),
            new Digivolve("Giromon","Seraphimon",0),
            new Digivolve("Deramon","Gryphonmon",0),
            new Digivolve("Digitamamon","SaberLeomon",0),
            new Digivolve("Dragomon","Pukumon",0),
            new Digivolve("Zudomon","Preciomon",0),
            new Digivolve("Zudomon","MarineAngemon",9),
            new Digivolve("Lillymon","Rosemon",0),
            new Digivolve("MagnaAngemon","Seraphimon",0),
            new Digivolve("Mamemon","PrinceMamemon",0),
            new Digivolve("Mamothmon","SkullMammothmon",0),
            new Digivolve("MarineDevimon","Pukumon",0),
            new Digivolve("MasterTyrannomon","WarGreymon",0),
            new Digivolve("MegaKabuterimon","HerculesKabuterimon",0),
            new Digivolve("MegaSeadramon","MetalSeadramon",0),
            new Digivolve("MetalGreymon","WarGreymon",0),
            new Digivolve("MetalGreymon","Omnimon",20),
            new Digivolve("MetalMamemon","PrinceMamemon",0),
            new Digivolve("MetalMamemon","SaberLeomon",9),
            new Digivolve("Meteormon","MetalGarurumon",0),
            new Digivolve("Meteormon","Baihumon",20),
            new Digivolve("Myotismon","VenomMyotismon",0),
            new Digivolve("Monzaemon","Jijimon",0),
            new Digivolve("Okuwamon","GranKuwagamon",0),
            new Digivolve("Okuwamon","Diaboromon",20),
            new Digivolve("Panjyamon","SaberLeomon",0),
            new Digivolve("Panjyamon","Magnadramon",9),
            new Digivolve("Raidramon","Phoenixmon",0),
            new Digivolve("Raidramon","Imperialdramon",8),
            new Digivolve("Scorpiomon","Preciomon",0),
            new Digivolve("Tekkamon","Pierrotmon",0),
            new Digivolve("Tinmon","Boltmon",0),
            new Digivolve("Pumpkinmon","Rosemon",0),
            new Digivolve("Whamon","MarineAngemon",0),
            new Digivolve("Phantomon","Pierrotmon",0),
            new Digivolve("SkullMeramon","Boltmon",0),
            new Digivolve("SkullGreymon","Machinedramon",0),
            new Digivolve("Cherrymon","Puppetmon",0),
            new Digivolve("ShogunGekomon","Pukumon",0),
            new Digivolve("Etemon","MetalEtemon",0),
        };



        public static List<Digimon> Digimons = new List<Digimon>()
        {
          new Digimon ("Агумон","Agumon",Rank.Rookie,Type.Vaccine,Speciality.None),
new Digimon ("Аирдрамон","Airdramon",Rank.Champion,Type.Vaccine,Speciality.None),
new Digimon ("АйсДевимон","IceDevimon",Rank.Champion,Type.Virus,Speciality.Water),
new Digimon ("Айсмон","Icemon",Rank.Champion,Type.Data,Speciality.Water),
new Digimon ("Акаторимон","Akatorimon",Rank.Champion,Type.Data,Speciality.Nature),
new Digimon ("Ангевомон","Angewomon",Rank.Ultimate,Type.Vaccine,Speciality.None),
new Digimon ("Ангемон","Angemon",Rank.Champion,Type.Vaccine,Speciality.None),
new Digimon ("Андромон","Andromon",Rank.Ultimate,Type.Vaccine,Speciality.Machine),
new Digimon ("АэроВиидрамон","AeroVeedramon",Rank.Ultimate,Type.Vaccine,Speciality.None),
new Digimon ("Баихумон","Baihumon",Rank.Mega,Type.Data,Speciality.None),
new Digimon ("Бакемон","Bakemon",Rank.Champion,Type.Virus,Speciality.Darkness),
new Digimon ("Бёрдрамон","Birdramon",Rank.Champion,Type.Vaccine,Speciality.Fire),
new Digimon ("Бетамон","Betamon",Rank.Rookie,Type.Virus,Speciality.None),
new Digimon ("Блоссомон","Blossomon",Rank.Ultimate,Type.Data,Speciality.Nature),
new Digimon ("БлюзМерамон","BlueMeramon",Rank.Ultimate,Type.Data,Speciality.Fire),
new Digimon ("БойГреймон","WarGreymon",Rank.Mega,Type.Vaccine,Speciality.None),
new Digimon ("Болтмон","Boltmon",Rank.Mega,Type.Data,Speciality.Machine),
new Digimon ("Вадемон","Vademon",Rank.Ultimate,Type.Virus,Speciality.None),
new Digimon ("ВаруМонзаемон","WaruMonzaemon",Rank.Ultimate,Type.Virus,Speciality.Darkness),
new Digimon ("ВаруСидрамон","WaruSeadramon",Rank.Ultimate,Type.Virus,Speciality.Water),
new Digimon ("Вегиемон","Vegiemon",Rank.Champion,Type.Virus,Speciality.Nature),
new Digimon ("ВеномМиотисмон","VenomMyotismon",Rank.Mega,Type.Virus,Speciality.Darkness),
new Digimon ("ВереГарурумон","WereGarurumon",Rank.Ultimate,Type.Vaccine,Speciality.None),
new Digimon ("Вермилимон","Vermilimon",Rank.Ultimate,Type.Data,Speciality.None),
new Digimon ("Визардмон","Wizardmon",Rank.Champion,Type.Data,Speciality.Darkness),
new Digimon ("Виидрамон","Veedramon",Rank.Champion,Type.Vaccine,Speciality.None),
new Digimon ("Виимон","Veemon",Rank.Rookie,Type.Vaccine,Speciality.None),
new Digimon ("Вудмон","Woodmon",Rank.Champion,Type.Virus,Speciality.Nature),
new Digimon ("Габумон","Gabumon",Rank.Rookie,Type.Data,Speciality.None),
new Digimon ("Гайа","Gaia",Rank.Mega,Type.Virus,Speciality.None),
new Digimon ("Гарудамон","Garudamon",Rank.Ultimate,Type.Vaccine,Speciality.Nature),
new Digimon ("Газимон","Gazimon",Rank.Rookie,Type.Virus,Speciality.None),
new Digimon ("Гарбамон","Garbagemon",Rank.Ultimate,Type.Virus,Speciality.Darkness),
new Digimon ("Гарурумон","Garurumon",Rank.Champion,Type.Data,Speciality.None),
new Digimon ("Гатомон","Gatomon",Rank.Champion,Type.Vaccine,Speciality.None),
new Digimon ("Гвардромон","Guardromon",Rank.Champion,Type.Virus,Speciality.Machine),
new Digimon ("Гекомон","Gekomon",Rank.Champion,Type.Virus,Speciality.Water),
new Digimon ("Гесомон","Gesomon",Rank.Champion,Type.Virus,Speciality.Water),
new Digimon ("Гигадрамон","Gigadramon",Rank.Ultimate,Type.Virus,Speciality.Machine),
new Digimon ("Гизамон","Gizamon",Rank.Rookie,Type.Virus,Speciality.None),
new Digimon ("Гиромон","Giromon",Rank.Ultimate,Type.Vaccine,Speciality.Machine),
new Digimon ("Гобуримон","Goburimon",Rank.Rookie,Type.Virus,Speciality.None),
new Digimon ("ГеркулкесКабутеримон","HerculesKabuterimon",Rank.Mega,Type.Vaccine,Speciality.Nature),
new Digimon ("Гомамон","Gomamon",Rank.Rookie,Type.Vaccine,Speciality.Water),
new Digimon ("Гоцумон","Gotsumon",Rank.Rookie,Type.Data,Speciality.Machine),
new Digimon ("ГранКувагамон","GranKuwagamon",Rank.Mega,Type.Virus,Speciality.Nature),
new Digimon ("Греймон","Greymon",Rank.Champion,Type.Vaccine,Speciality.None),
new Digimon ("Грифонмон","Gryphonmon",Rank.Mega,Type.Data,Speciality.Nature),
new Digimon ("Гурурумон","Gururumon",Rank.Champion,Type.Vaccine,Speciality.None),
new Digimon ("ДаркРизамон","DarkLizardmon",Rank.Champion,Type.Virus,Speciality.Darkness),
new Digimon ("ДаркТираномон","DarkTyrannomon",Rank.Champion,Type.Virus,Speciality.Darkness),
new Digimon ("Датамон","Datamon",Rank.Ultimate,Type.Virus,Speciality.Machine),
new Digimon ("Девидрамон","Devidramon",Rank.Champion,Type.Virus,Speciality.Darkness),
new Digimon ("Девимон","Devimon",Rank.Champion,Type.Virus,Speciality.Darkness),
new Digimon ("Дельтамон","Deltamon",Rank.Champion,Type.Virus,Speciality.Darkness),
new Digimon ("ДемиДевимон","DemiDevimon",Rank.Rookie,Type.Virus,Speciality.Darkness),
new Digimon ("Дерамон","Deramon",Rank.Ultimate,Type.Data,Speciality.Nature),
new Digimon ("Диаборомон","Diaboromon",Rank.Mega,Type.Virus,Speciality.Darkness),
new Digimon ("Дигитамамон","Digitamamon",Rank.Ultimate,Type.Data,Speciality.Darkness),
new Digimon ("Докунемон","Dokunemon",Rank.Rookie,Type.Virus,Speciality.Nature),
new Digimon ("Дольфмон","Dolphmon",Rank.Champion,Type.Vaccine,Speciality.Water),
new Digimon ("Драгомон","Dragomon",Rank.Ultimate,Type.Virus,Speciality.Water),
new Digimon ("Дримогемон","Drimogemon",Rank.Champion,Type.Data,Speciality.Machine),
new Digimon ("Ж-Моджамон","JungleMojyamon",Rank.Champion,Type.Data,Speciality.None),
new Digimon ("Жижимон","Jijimon",Rank.Mega,Type.Vaccine,Speciality.None),
new Digimon ("Зудомон","Zudomon",Rank.Ultimate,Type.Vaccine,Speciality.Water),
new Digimon ("Иккакумон","Ikkakumon",Rank.Champion,Type.Vaccine,Speciality.Water),
new Digimon ("Империалдрамон","Imperialdramon",Rank.Mega,Type.Vaccine,Speciality.None),
new Digimon ("Кабутеримон","Kabuterimon",Rank.Champion,Type.Vaccine,Speciality.Nature),
new Digimon ("Кентарумон","Centarumon",Rank.Champion,Type.Data,Speciality.None),
new Digimon ("Кивимон","Kiwimon",Rank.Champion,Type.Data,Speciality.Nature),
new Digimon ("Кимерамон","Kimeramon",Rank.Mega,Type.Data,Speciality.Darkness),
new Digimon ("КлирАгумон","ClearAgumon",Rank.Rookie,Type.Vaccine,Speciality.None),
new Digimon ("Клокмон","Clockmon",Rank.Champion,Type.Data,Speciality.Machine),
new Digimon ("Коеламон","Coelamon",Rank.Champion,Type.Data,Speciality.Water),
new Digimon ("Кокаторимон","Kokatorimon",Rank.Champion,Type.Data,Speciality.Nature),
new Digimon ("Крабмон","Crabmon",Rank.Rookie,Type.Data,Speciality.Water),
new Digimon ("Кувагамон","Kuwagamon",Rank.Champion,Type.Virus,Speciality.None),
new Digimon ("Кунемон","Kunemon",Rank.Rookie,Type.Virus,Speciality.Nature),
new Digimon ("Кандмон","Candlemon",Rank.Rookie,Type.Data,Speciality.Fire),
new Digimon ("Левая рука Гайа","Gaia left hand",Rank.Mega,Type.Virus,Speciality.None),
new Digimon ("Леомон","Leomon",Rank.Champion,Type.Vaccine,Speciality.None),
new Digimon ("Лилимон","Lillymon",Rank.Ultimate,Type.Vaccine,Speciality.Nature),
new Digimon ("ХаосЛорд","ChaosLord",Rank.Mega,Type.Virus,Speciality.Darkness),
new Digimon ("МагнаАнгемон","MagnaAngemon",Rank.Ultimate,Type.Vaccine,Speciality.None),
new Digimon ("Магнадрамон","Magnadramon",Rank.Mega,Type.Vaccine,Speciality.None),
new Digimon ("Мамемон","Mamemon",Rank.Ultimate,Type.Data,Speciality.Machine),
new Digimon ("Мамонтмон","Mammothmon",Rank.Ultimate,Type.Vaccine,Speciality.None),
new Digimon ("МаринеАнгемон","MarineAngemon",Rank.Mega,Type.Vaccine,Speciality.Water),
new Digimon ("МаринеДевимон","MarineDevimon",Rank.Ultimate,Type.Virus,Speciality.Water),
new Digimon ("МастерТираномон","MasterTyrannomon",Rank.Ultimate,Type.Vaccine,Speciality.Machine),
new Digimon ("Машинедрамон","Machinedramon",Rank.Mega,Type.Virus,Speciality.Darkness),
new Digimon ("Машрумон","Mushroomon",Rank.Rookie,Type.Virus,Speciality.Nature),
new Digimon ("Мегадрамон","Megadramon",Rank.Ultimate,Type.Virus,Speciality.Machine),
new Digimon ("МегаКабутеримон","MegaKabuterimon",Rank.Ultimate,Type.Vaccine,Speciality.Nature),
new Digimon ("МегаСидрамон","MegaSeadramon",Rank.Ultimate,Type.Data,Speciality.Water),
new Digimon ("Мерамон","Meramon",Rank.Champion,Type.Data,Speciality.Fire),
new Digimon ("МеталГарурумон","MetalGarurumon",Rank.Mega,Type.Data,Speciality.Machine),
new Digimon ("МеталГреймон","MetalGreymon",Rank.Ultimate,Type.Vaccine,Speciality.Machine),
new Digimon ("МеталМамемон","MetalMamemon",Rank.Ultimate,Type.Data,Speciality.Machine),
new Digimon ("МеталСидрамон","MetalSeadramon",Rank.Mega,Type.Data,Speciality.Machine),
new Digimon ("МеталТираномон","MetalTyrannomon",Rank.Ultimate,Type.Virus,Speciality.Machine),
new Digimon ("МеталЭтемон","MetalEtemon",Rank.Mega,Type.Virus,Speciality.Machine),
new Digimon ("Метеормон","Meteormon",Rank.Ultimate,Type.Data,Speciality.Machine),
new Digimon ("Миотисмон","Myotismon",Rank.Ultimate,Type.Virus,Speciality.Darkness),
new Digimon ("Моджамон","Mojyamon",Rank.Champion,Type.Vaccine,Speciality.None),
new Digimon ("Монзаемон","Monzaemon",Rank.Ultimate,Type.Vaccine,Speciality.None),
new Digimon ("Монохромон","Monochromon",Rank.Champion,Type.Data,Speciality.None),
new Digimon ("МориШеллмон","MoriShellmon",Rank.Champion,Type.Data,Speciality.Nature),
new Digimon ("МудФригимон","MudFrigimon",Rank.Champion,Type.Data,Speciality.None),
new Digimon ("НайсДримогемон","NiseDrimogemon",Rank.Champion,Type.Data,Speciality.Machine),
new Digimon ("Нанимон","Nanimon",Rank.Champion,Type.Virus,Speciality.None),
new Digimon ("НеоКримсон","NeoCrimson",Rank.Mega,Type.Virus,Speciality.Darkness),
new Digimon ("Нинидзямон","Ninjamon",Rank.Champion,Type.Data,Speciality.Nature),
new Digimon ("Нумемон","Numemon",Rank.Champion,Type.Virus,Speciality.Darkness),
new Digimon ("Оверлорд Гайа","Overlord Gaia",Rank.Mega,Type.Virus,Speciality.None),
new Digimon ("Огремон","Ogremon",Rank.Champion,Type.Virus,Speciality.None),
new Digimon ("Октомон","Octomon",Rank.Champion,Type.Virus,Speciality.Water),
new Digimon ("Окувамон","Okuwamon",Rank.Ultimate,Type.Virus,Speciality.Nature),
new Digimon ("Омнимон","Omnimon",Rank.Mega,Type.Vaccine,Speciality.None),
new Digimon ("Отамамон","Otamamon",Rank.Rookie,Type.Virus,Speciality.Water),
new Digimon ("П-Сукамон","PlatinumSukamon",Rank.Champion,Type.Virus,Speciality.Darkness),
new Digimon ("Панджамон","Panjyamon",Rank.Ultimate,Type.Vaccine,Speciality.None),
new Digimon ("Паппетмон","Puppetmon",Rank.Mega,Type.Virus,Speciality.Nature),
new Digimon ("Палмон","Palmon",Rank.Rookie,Type.Data,Speciality.Nature),
new Digimon ("Патамон","Patamon",Rank.Rookie,Type.Data,Speciality.None),
new Digimon ("Пиддомон","Piddomon",Rank.Champion,Type.Vaccine,Speciality.None),
new Digimon ("Бийомон","Biyomon",Rank.Rookie,Type.Vaccine,Speciality.Nature),
new Digimon ("Пиксимон","Piximon",Rank.Ultimate,Type.Data,Speciality.None),
new Digimon ("Пингвимон","Penguinmon",Rank.Rookie,Type.Vaccine,Speciality.Water),
new Digimon ("Правая рука Гайа","Gaia right hand",Rank.Mega,Type.Virus,Speciality.None),
new Digimon ("Пречиомон","Preciomon",Rank.Mega,Type.Data,Speciality.Water),
new Digimon ("ПринцМамемон","PrinceMamemon",Rank.Mega,Type.Data,Speciality.Machine),
new Digimon ("Пукумон","Pukumon",Rank.Mega,Type.Virus,Speciality.Water),
new Digimon ("Пьерротмон","Pierrotmon",Rank.Mega,Type.Virus,Speciality.Darkness),
new Digimon ("Раидрамон","Raidramon",Rank.Ultimate,Type.Vaccine,Speciality.None),
new Digimon ("Раремон","Raremon",Rank.Champion,Type.Virus,Speciality.Darkness),
new Digimon ("РедВегиемон","RedVegiemon",Rank.Rookie,Type.Virus,Speciality.Nature),
new Digimon ("Роземон","Rosemon",Rank.Mega,Type.Data,Speciality.Nature),
new Digimon ("Сабердрамон","Saberdramon",Rank.Champion,Type.Vaccine,Speciality.None),
new Digimon ("СаберЛеомон","SaberLeomon",Rank.Mega,Type.Data,Speciality.None),
new Digimon ("Серафимон","Seraphimon",Rank.Mega,Type.Vaccine,Speciality.None),
new Digimon ("Сидрамон","Seadramon",Rank.Champion,Type.Data,Speciality.Water),
new Digimon ("Сиякомон","Syakomon",Rank.Rookie,Type.Virus,Speciality.Water),
new Digimon ("Скорпиомон","Scorpiomon",Rank.Ultimate,Type.Data,Speciality.Water),
new Digimon ("СкуллМамонтмон","SkullMammothmon",Rank.Mega,Type.Vaccine,Speciality.Darkness),
new Digimon ("СноуАгумон","SnowAgumon",Rank.Rookie,Type.Vaccine,Speciality.Water),
new Digimon ("СноуГобуримон","SnowGoburimon",Rank.Rookie,Type.Virus,Speciality.Water),
new Digimon ("Соулмон","Soulmon",Rank.Champion,Type.Virus,Speciality.Darkness),
new Digimon ("Стармон","Starmon",Rank.Champion,Type.Data,Speciality.None),
new Digimon ("Страж вакцины","Vaccine Guardian",Rank.Mega,Type.Vaccine,Speciality.None),
new Digimon ("Страж вируса","Virus Guardian",Rank.Mega,Type.Virus,Speciality.None),
new Digimon ("Страж данных","Data Guardian",Rank.Mega,Type.Data,Speciality.None),
new Digimon ("Сукамон","Sukamon",Rank.Champion,Type.Virus,Speciality.Darkness),
new Digimon ("СэндЯнмамон","SandYanmamon",Rank.Champion,Type.Data,Speciality.Nature),
new Digimon ("Танкмон","Tankmon",Rank.Champion,Type.Data,Speciality.Machine),
new Digimon ("Тапирмон","Tapirmon",Rank.Rookie,Type.Virus,Speciality.Darkness),
new Digimon ("Таскмон","Tuskmon",Rank.Champion,Type.Virus,Speciality.None),
new Digimon ("Теккамон","Tekkamon",Rank.Ultimate,Type.Virus,Speciality.Machine),
new Digimon ("Тентомон","Tentomon",Rank.Rookie,Type.Vaccine,Speciality.Nature),
new Digimon ("Тинмон","Tinmon",Rank.Ultimate,Type.Data,Speciality.Machine),
new Digimon ("Тираномон","Tyrannomon",Rank.Champion,Type.Vaccine,Speciality.None),
new Digimon ("Тогемон","Togemon",Rank.Champion,Type.Data,Speciality.Nature),
new Digimon ("Тортомон","Tortomon",Rank.Champion,Type.Data,Speciality.Water),
new Digimon ("ТойАгумон","ToyAgumon",Rank.Rookie,Type.Vaccine,Speciality.None),
new Digimon ("Трицерамон","Triceramon",Rank.Ultimate,Type.Data,Speciality.None),
new Digimon ("Тыквинмон","Pumpkinmon",Rank.Ultimate,Type.Data,Speciality.Darkness),
new Digimon ("Увамон","Whamon",Rank.Ultimate,Type.Vaccine,Speciality.Water),
new Digimon ("Унимон","Unimon",Rank.Champion,Type.Vaccine,Speciality.None),
new Digimon ("Фантомон","Phantomon",Rank.Ultimate,Type.Virus,Speciality.Darkness),
new Digimon ("Фениксмон","Phoenixmon",Rank.Mega,Type.Vaccine,Speciality.Nature),
new Digimon ("ФлареРизамон","FlareLizardmon",Rank.Champion,Type.Data,Speciality.Fire),
new Digimon ("Флеймдрамон","Flamedramon",Rank.Champion,Type.Vaccine,Speciality.Fire),
new Digimon ("Флимон","Flymon",Rank.Champion,Type.Virus,Speciality.Nature),
new Digimon ("Флорамон","Floramon",Rank.Rookie,Type.Data,Speciality.Nature),
new Digimon ("Фригимон","Frigimon",Rank.Champion,Type.Vaccine,Speciality.Water),
new Digimon ("Хагурумон","Hagurumon",Rank.Rookie,Type.Virus,Speciality.Machine),
new Digimon ("ХаосБойГреймон","ChaosWarGreymon",Rank.Mega,Type.Vaccine,Speciality.None),
new Digimon ("ХаосСидрамон","ChaosSeadramon",Rank.Mega,Type.Data,Speciality.Water),
new Digimon ("ХаосПьерротмон","ChaosPierrotmon",Rank.Mega,Type.Virus,Speciality.Darkness),
new Digimon ("Хёгамон","Hyogamon",Rank.Champion,Type.Virus,Speciality.Water),
new Digimon ("Циклонемон","Cyclonemon",Rank.Champion,Type.Virus,Speciality.None),
new Digimon ("Цукаимон","Tsukaimon",Rank.Rookie,Type.Virus,Speciality.Darkness),
new Digimon ("ЧерепМерамон","SkullMeramon",Rank.Ultimate,Type.Data,Speciality.Fire),
new Digimon ("ЧерепоГреймон","SkullGreymon",Rank.Ultimate,Type.Virus,Speciality.Darkness),
new Digimon ("Черримон","Cherrymon",Rank.Ultimate,Type.Virus,Speciality.Nature),
new Digimon ("Шеллмон","Shellmon",Rank.Champion,Type.Data,Speciality.Water),
new Digimon ("ШимаУнимон","ShimaUnimon",Rank.Champion,Type.Vaccine,Speciality.None),
new Digimon ("ШоганГекомон","ShogunGekomon",Rank.Ultimate,Type.Virus,Speciality.Water),
new Digimon ("Эйпмон","Apemon",Rank.Champion,Type.Vaccine,Speciality.None),
new Digimon ("ЭксТираномон","ExTyrannomon",Rank.Ultimate,Type.Virus,Speciality.Darkness),
new Digimon ("Элекмон","Elecmon",Rank.Rookie,Type.Data,Speciality.None),
new Digimon ("Этемон","Etemon",Rank.Ultimate,Type.Virus,Speciality.None),
new Digimon ("Янмамон","Yanmamon",Rank.Champion,Type.Data,Speciality.Nature),
        };





        public static void Fill()
        {
            //мутации
            Dictionary<KeyValuePair<string, string>, string> Mutation = new Dictionary<KeyValuePair<string, string>, string>()
            {
                {new KeyValuePair<string, string>("Черримон","Зудомон"),"Вадемон"  },
                {new KeyValuePair<string, string>("Черримон","МастерТираномон"),"Вадемон"  },
                {new KeyValuePair<string, string>("Черримон","МеталГреймон"),"Вадемон"  },
                {new KeyValuePair<string, string>("Черримон","Увамон"),"Вадемон"  },

//                {new KeyValuePair<string, string>("Паппетмон","Зудомон"),"Вадемон"  },
//                {new KeyValuePair<string, string>("Паппетмон","МастерТираномон"),"Вадемон"  },
//                {new KeyValuePair<string, string>("Паппетмон","МеталГреймон"),"Вадемон"  },
//                {new KeyValuePair<string, string>("Паппетмон","Увамон"),"Вадемон"  },
//
//
//                {new KeyValuePair<string, string>("Черримон","БойГреймон"),"Вадемон"  },
//                {new KeyValuePair<string, string>("Черримон","МаринеАнгемон"),"Вадемон"  },
//                {new KeyValuePair<string, string>("Черримон","Омнимон"),"Вадемон"  },
//                {new KeyValuePair<string, string>("Черримон","Пречиомон"),"Вадемон"  },



                {new KeyValuePair<string, string>("ГеркулкесКабутеримон","Грифонмон"),"Янмамон"  },
                {new KeyValuePair<string, string>("ГеркулкесКабутеримон","Роземон"),"Янмамон"  },
                {new KeyValuePair<string, string>("ГеркулкесКабутеримон","Баихумон"),"СэндЯнмамон"  },
                {new KeyValuePair<string, string>("ГеркулкесКабутеримон","МеталГарурумон"),"СэндЯнмамон"  },
                {new KeyValuePair<string, string>("ГеркулкесКабутеримон","ПринцМамемон"),"СэндЯнмамон"  },
                {new KeyValuePair<string, string>("ГеркулкесКабутеримон","СаберЛеомон"),"СэндЯнмамон"  },
            };
            Dictionary<KeyValuePair<string, string>, string> MutationEng = new Dictionary<KeyValuePair<string, string>, string>();

            foreach (var mutation in Mutation)
            {
                MutationEng.Add(new KeyValuePair<string, string>(DB.Digimons.FirstOrDefault(x => x.NameRus == mutation.Key.Key).NameEng,
                    DB.Digimons.FirstOrDefault(x => x.NameRus == mutation.Key.Value).NameEng),
                    DB.Digimons.FirstOrDefault(x => x.NameRus == mutation.Value).NameEng);
            }

            foreach (var mutationEng in MutationEng)
            {
                DB.DigivolvesDNA.Add(new DigivolveDNA(mutationEng.Key.Key, mutationEng.Key.Value, mutationEng.Value));
            }



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

                    if (result == null
                            //                        && !DB.DigivolvesDNA.Any(
                            //                            x => x.DigimonParent1Id == parent1.NameEng && x.DigimonParent2Id == parent2.NameEng)
                            //                        && !DB.DigivolvesDNA.Any(
                            //                            x => x.DigimonParent2Id == parent1.NameEng && x.DigimonParent1Id == parent2.NameEng)
                            //&& strResult != "МУ"
                            )
                    {
                        errors.Add(parent11.NameEng + "-" + parent11.NameRus + "-" + parent11.Rank);
                        errors.Add(parent22.NameEng + "-" + parent22.NameRus + "-" + parent22.Rank);

                        Console.WriteLine("Parent1={0}(Rank={4})\tParent2={1}(Rank={5})\tParent11={2}(Rank={6})\tParent22={3}(Rank={7})",
                            parent1.NameEng, parent2.NameEng, parent11.NameEng, parent22.NameEng,
                            parent1.Rank, parent2.Rank, parent11.Rank, parent22.Rank);

                        continue;
                    }

                    var first =
                        DB.DigivolvesDNA.Any(
                            x => x.DigimonParent1Id == parent1.NameEng && x.DigimonParent2Id == parent2.NameEng);

                    var second =
                        DB.DigivolvesDNA.Any(
                            x => x.DigimonParent2Id == parent1.NameEng && x.DigimonParent1Id == parent2.NameEng);
                    if (!first && !second)
                        DB.DigivolvesDNA.Add(new DigivolveDNA(parent1.NameEng, parent2.NameEng, result.NameEng));


                }
            }

            foreach (var error in errors.GroupBy(x => x).OrderByDescending(x => x.Count()))
            {
                Console.WriteLine("{0}-{1}", error.Key, error.Count());
            }



        }


        public static DigimonTemp Down(DigimonTemp temp, List<DigimonTemp> list)
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






}
