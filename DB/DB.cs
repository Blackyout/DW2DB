﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB
{
    public class DB
    {
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
            new Digivolve("Hagurumon","P-Sukamon",2),
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
            new Digivolve("Leomon","Panjamon",0),
            new Digivolve("Mojyamon","Monzaemon",0),
            new Digivolve("Piddomon","MagnaAngemon",0),
            new Digivolve("Piddomon","Giromon",6),
            new Digivolve("Saberdramon","Garudamon",0),
            new Digivolve("Tortomon","Zudomon",0),
            new Digivolve("Unimon","Mamothmon",0),
            new Digivolve("Flamedramon","AeroVeedramon",0),
            new Digivolve("Flamedramon","Raidramon",6),
            new Digivolve("Frigimon","Monzaemon",0),
            new Digivolve("ShimaUnimon","Mamothmon",0),
            new Digivolve("Apemon","Mamothmon",0),
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
            new Digivolve("WereGarurumon","SkullMamothmon",0),
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
            new Digivolve("Mamothmon","SkullMamothmon",0),
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
            new Digivolve("Panjamon","SaberLeomon",0),
            new Digivolve("Panjamon","Magnadramon",9),
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
new Digimon ("Мамонтмон","Mamothmon",Rank.Ultimate,Type.Vaccine,Speciality.None),
new Digimon ("МаринеАнгемон","MarineAngemon",Rank.Mega,Type.Vaccine,Speciality.Water),
new Digimon ("МаринеДевимон","MarineDevimon",Rank.Ultimate,Type.Virus,Speciality.Water),
new Digimon ("МастерТираномон","MasterTyrannomon",Rank.Ultimate,Type.Vaccine,Speciality.Machine),
new Digimon ("Машинедрамон","Macinedramon",Rank.Mega,Type.Virus,Speciality.Darkness),
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
new Digimon ("Панджамон","Panjamon",Rank.Ultimate,Type.Vaccine,Speciality.None),
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
new Digimon ("СкуллМамонтмон","SkullMamothmon",Rank.Mega,Type.Vaccine,Speciality.Darkness),
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

    }



}
