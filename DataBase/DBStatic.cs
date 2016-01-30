using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace DataBase
{
    public class DBStatic
    {
        public static List<DigivolveDNA> DigivolvesDNA = new List<DigivolveDNA>();

        public static List<Skill> Skills = new List<Skill>()
        {
           new Skill("Unimon",SkillType.Attack,"Святой выстрел","Air Attack","Запускает во врага сгусток священной энергии.", "Shoots an Air Burst.", 8,20),
new Skill("Vademon",SkillType.Attack,"Луч похищения","Alien Ray","Стреляет лазером из пистолета.", "Fires a Ray Beam.", 20,37.5m),
new Skill("Saberdramon",SkillType.Assist,"Anti-Confusion","АнтиСмятение","Лечит смятение.", "Cures Confusion.", 12,0),
new Skill("Gururumon",SkillType.Assist,"Антидот","Anti-Dote","Лечит отравление.", "Cures Poison.", 10,0),
new Skill("ShimaUnimon",SkillType.Assist,"Антифриз","Anti-Freeze","Лечит паралич.", "Cures Paralysis.", 12,0),
new Skill("MudFrigimon",SkillType.Assist,"Тяжеловес","Armor Coating","Повышает силу атаки вашего дигимона.", "Boosts one ally Digimon attack by 20%.", 10,0),
new Skill("MetalEtemon",SkillType.Assist,"Подсечка на банане","Banana Slip","Не позволяет врагам контратаковать.", "Causes all countering digimon to lose turn.", 60,0),
new Skill("Leomon",SkillType.CounterAttack,"Удар короля зверей","Beast King Fist","Возвращает урон в полуторном размере.", "Counter returns damage dealt 1.5x, floored (rounded down).", 12,15),
new Skill("Giromon",SkillType.Attack,"Смертоносная бомба","Big Bang Boom","Кидает бомбочки во всех врагов.", "Throws Grenades at all foe.", 40,30),
new Skill("Syakomon",SkillType.Attack,"Жемчужина","BlackPearl Shot","После применения этой атаки ваша защита уменьшается в два раза до конца хода.", "Attacks with no defense.", 4,20),
new Skill("Tyrannomon",SkillType.Attack,"Огненное дыхание","Blaze Blast","Атакует всех врагов огнём.", "Shoots a Breath of Fire.", 10,25),
new Skill("FlareLizardmon",SkillType.Assist,"Огненный луч","Blaze Buster","Добавляет огненный эффект ко всем атакам.", "Changes all moves used by the Digimon to Fire.", 10,0),
new Skill("NeoCrimson",SkillType.Attack,"Атака вслепую","Blind Attack","Очень сильная атака, но иногда бьёт самого себя.", "Randomly attacks one digimon, friend or enemy.", 30,60),
new Skill("Gabumon",SkillType.Attack,"Голубое пламя","Blue Blaster","Стреляет шаром энергии.", "Shoots a Fireball.", 4,10),
new Skill("SnowGoburimon",SkillType.Attack,"Снежная молния","Bolt Strike","Атакует снежной ракетой.", "Fires a Frozen Missile.", 6,10),
new Skill("Patamon",SkillType.Attack,"Воздушный выстрел","Boom Bubble","Запускает во врага воздушный пузырь.", "Shoots a Boom Bubble.", 6,12.5m),
new Skill("Flymon",SkillType.Attack,"Коричневый стингер","Brown Stinger","Ставит на противника отравление.", "Shoots Poison Needles.", 12,20),
new Skill("Raremon",SkillType.CounterAttack,"Дыхание буйвола","Buffalo Breath","Ставит на врага смятение.", "Confuses foe in Counter.", 10,22.5m),
new Skill("ChaosLord",SkillType.Attack,"Пушка хаоса","Chaos Cannon","Атакует несколько раз подряд пока не закончатся MP.", "Allows multiple hits if the previous hit knocks out an opponent.", 40,25),
new Skill("Clockmon",SkillType.Interrupt,"Хронолом","Chrono Breaker","Дигимон, которого прервали, атакует последним.", "Delays foe's attack to end.", 14,20),
new Skill("Etemon",SkillType.Attack,"Конец концерта","Concert Crush","Ставит на противника очарование.", "Foe can't use Power Techs.", 18,27.5m),
new Skill("Gesomon",SkillType.Attack,"Возмутитель кораллов","Coral Crusher","Снижает скорость противника.", "Lowers speed by 20%.", 12,20),
new Skill("Devidramon",SkillType.Attack,"Малиновый коготь","Crimson Claw","Если ваш дигимон отравлен, сконфужен или парализован, этой атакой он может передать отрицательные эффекты врагу.", "If you have Confuse, Poison or Stun, then the skill will transfer that status to your enemy.", 18,35),
new Skill("Phoenixmon",SkillType.Assist,"Малиновое пламя","Crimson Flame","Оживляет лежачего дигимона.", "Restores knocked out digimon to full health.", 50,0),
new Skill("SkullGreymon",SkillType.Attack,"Эпицентр","Dark Shot","Запускает во врага органическую ракету.", "Fires an Organic Missle.", 20,40),
new Skill("Hagurumon",SkillType.Attack,"Тёмная шестерёнка","Darkness Gear","Запускает во врага шестерёнку.", "Fires a Darkness Gear.", 8,17.5m),
new Skill("DarkLizardmon",SkillType.Assist,"Тёмный луч","Darkness Ray","Добавляет эффект тьмы ко всем атакам.", "Changes all moves used by the Digimon to Darkness.", 10,0),
new Skill("Megadramon",SkillType.Attack,"Атака тёмной стороны","Darkside Attack","Не позволяет врагу лечиться до конца хода.", "Foes can't recover HP.", 20,32.5m),
new Skill("Icemon",SkillType.Assist,"Защитный луч","Defensive Ray","Повышает уровень защиты вашего дигимона.", "Boosts one ally digimon defense by 20%.", 10,0),
new Skill("DemiDevimon",SkillType.Attack,"Полудартс","Demi Dart","Снижает уровень MP противника.", "Lowers enemy MP a little.", 8,15),
new Skill("Datamon",SkillType.Attack,"Цифровая бомба","Digital Bomb","Кидает маленькие бомбочки во всех врагов.", "Toss small Bombs on all foes.", 30,22.5m),
new Skill("Okuwamon",SkillType.Attack,"Омега коготь ножниц","Duo ScissorClaw","Атакует всех врагов и снижает их защиту.", "Lower's all foes defense by ~20% (before applying damage itself).", 36,22.5m),
new Skill("Betamon",SkillType.Attack,"Электрошок","Electric Shock","Стреляет сгустком электричества.", "Fires an Electric Burst.", 8,17.5m),
new Skill("Kunemon",SkillType.Attack,"Электронить","Electro Thread","Выпускает электрическую нить.", "Shoots Electro Threads.", 8,17.5m),
new Skill("Kabuterimon",SkillType.Interrupt,"Мега бластер","Electro-Shocker","Снижает силу атаки врага.", "Lower's the attack stat of target digimon by 20%.", 12,22.5m),
new Skill("MetalMamemon",SkillType.CounterAttack,"Энергобомба","Energetic Bomb","Стреляет сгустком энергии по всем врагам.", "When countering, all foes are hit instead of just one.", 20,30),
new Skill("MetalSeadramon",SkillType.Attack,"Абсолютный поток","Energy Blast","Атакует всех врагов струёй энергии.", "Shoot Energy Blasts at foe.", 60,37.5m),
new Skill("Gazimon",SkillType.Attack,"Парализующее дыхание","E-Stun Blast","Парализует врага.", "May paralyze.", 8,15),
new Skill("Bakemon",SkillType.Attack,"Шарм дьявола","Evil Charm","Ставит на противника смятение.", "Can confuse.", 12,20),
new Skill("Devimon",SkillType.Attack,"Коготь смерти","Evil Touch","Снижает уровень MP противника.", "Lowers enemy's MP.", 12,22.5m),
new Skill("MarineDevimon",SkillType.Attack,"Давление","Evil Wind","Снижает скорость противника.", "Reduces all foes speed by 20%.", 36,20),
new Skill("DarkTyrannomon",SkillType.Attack,"Огненный взрыв","Fire Blast","Атакует всех врагов стеной огня.", "Shoots Flame at all foes.", 22,17.5m),
new Skill("MetalTyrannomon",SkillType.Attack,"Гигаразрушитель два","Fire Blast 2","Стреляет органической ракетой.", "Fires an Organic Missile.", 20,37.5m),
new Skill("Magnadramon",SkillType.Attack,"Святое пламя","Fire Tornado","Атакует всех врагов сгустками энергии.", "Shoots Energy at all foes.", 80,45),
new Skill("Meramon",SkillType.Attack,"Пылающий кулак","Fireball","Бьёт противника огненным кулаком.", "Shoots a Fire Punch.", 12,30),
new Skill("Angemon",SkillType.Attack,"Кулак судьбы","Fist of Fate","Бьёт противника кулаком.", "Throws a Light-Speed Punch.", 10,27.5m),
new Skill("Candlemon",SkillType.Attack,"Костёр","Flame Bomber","Атакует противника огнём.", "Shoots a Fireball.", 6,15),
new Skill("Flamedramon",SkillType.Attack,"Огненная ракета","Flaming Rocket","Атакует огненной ракетой.", "Shoots a Blazing Missile.", 12,30),
new Skill("Lillymon",SkillType.Attack,"Цветочная пушка","Flower Cannon","Стреляет по врагу цветочной энергией.", "Fires Flower Energy Blast.", 16,35),
new Skill("Coelamon",SkillType.Attack,"Изменчивое жало","Fossil Bite","Атакует врага когтями.", "Attacks with Claws.", 8,20),
new Skill("MetalGarurumon",SkillType.Attack,"Дыхание Коцита","Freeze Breath","Атакует всех врагов ледяным дыханием.", "Frozen Breath hits all foe.", 60,37.5m),
new Skill("Tsukaimon",SkillType.Attack,"Дружеский огонь","Friendly Fire","Позволяет атаковать своих же дигимонов для получения контратаки. Лечит смятение.", "Allows you to attack an ally in order to trigger counterattack. Also cures confusion.", 4,17.5m),
new Skill("Seraphimon",SkillType.Assist,"Полное лечение","Full HP Cure","Восстанавливает все HP каждому из ваших дигимонов.", "Fully recovers all ally digimon in battle.", 80,0),
new Skill("Panjyamon",SkillType.Assist,"Полное восстановление","Full Recovery","Восстанавливает все HP вашему дигимону.", "Restores one digimon to full HP (does not revive).", 18,0),
new Skill("Mushroomon",SkillType.Assist,"Ядовитый гриб","Fungus Cruncher","Ставит отравление на дигимонов, которые вас атакуют.", "Makes yourself poisonous, causing poison to any attacking digimon.", 8,0),
new Skill("MetalGreymon",SkillType.Attack,"Гигаразрушитель","Giga Blaster","Запускает во врага органическую ракету.", "Fires an Organic Missile.", 18,37.5m),
new Skill("Gigadramon",SkillType.Attack,"Крыло гигабайта","Giga Byte Wing","Не даёт лечить отрицательные изменения статуса до конца хода.", "Foes can't regain Status.", 20,32.5m),
new Skill("Machinedramon",SkillType.Attack,"Бесконечная пушка","Giga Cannon","Атакует несколько раз подряд пока не кончатся MP.", "Attacks untill MP runs out.", 60,30),
new Skill("HerculesKabuterimon",SkillType.Interrupt,"Гига коготь ножниц","GigaScissorClaw","Полностью отменяет атаку противника.", "Disables enemy attack.", 40,30),
new Skill("Myotismon",SkillType.Attack,"Крыло гризли","Grisly Wing","Выпускает летучих мышей во всех врагов.", "Attack fow with Flying Bats.", 40,30),
new Skill("SnowAgumon",SkillType.Attack,"Маленькая буря","Hail Storm","Стреляет льдинками по всем врагам.", "Attacks with a Hail Storm.", 8,17.5m),
new Skill("Ikkakumon",SkillType.Attack,"Гарпун-торпеда","Harpoon Torpedo","Атакует торпедой.", "Shoots a Horn Missile.", 10,25),
new Skill("WaruMonzaemon",SkillType.Assist,"Инфаркт","Heart Break Hit","Ослабляет всех дигимонов типа данных.", "Reduces attack and defense by 20% of all Data digimon.", 36,0),
new Skill("Angewomon",SkillType.Attack,"Святая стрела","Heaven's Arrow","Выпускает во врага стрелу.", "Shoots a Light-Speed Arrow.", 16,35),
new Skill("MegaKabuterimon",SkillType.Assist,"Таран рогом","Horn Buster","Снижает уровень атаки противника.", "Lowers Offense Power greatly.", 20,32.5m),
new Skill("Garurumon",SkillType.Attack,"Кричащий бластер","Howling Blaster","Стреляет потоком энергии.", "Shoots Blue Flame.", 12,27.5m),
new Skill("SaberLeomon",SkillType.Attack,"Сокрушающий коготь","Howling Crusher","Предотвращает контратаку врага.", "No Counter, Claw attack.", 30,45),
new Skill("MagnaAngemon",SkillType.Assist,"Восстановление здоровья","HP Recovery","Восстанавливает по 150 HP каждому из ваших дигимонов.", "Heals each ally digimon in battle for 150 HP.", 24,0),
new Skill("Jijimon",SkillType.Assist,"Повис на смерти","Hung on Death","Оживляет дигимона, полностью лечит его и ставит неуязвимость до конца хода.", "Revive digimon, reduce all HP and nullifies all attacks during own turn.", 20,0),
new Skill("Shellmon",SkillType.Attack,"Гидробластер","Hydro Blaster","Атакует противника сжатой водой.", "Shoots High Pressure Water.", 10,25),
new Skill("Tankmon",SkillType.Attack,"Гипер-пушка","Hyper Cannon","Стреляет органической ракетой.", "Fires a Cannon.", 10,25),
new Skill("Digitamamon",SkillType.Assist,"Гипервспышка","Hyper Flashing","Ослабляет всех дигимонов типа вакцина.", "Lowers attack and defense by 20% for all Vaccine Digimon in battle.", 36,0),
new Skill("Cyclonemon",SkillType.Attack,"Гипер луч","Hyper Heat","Атакует сверхгорячим лазером.", "Shoots a Super Hot Blast.", 10,22.5m),
new Skill("Seadramon",SkillType.Attack,"Ледяная стрела","Ice Blast","Атакует всех врагов острыми льдинками.", "Shoot IceBlades at all foe.", 18,15),
new Skill("Mojyamon",SkillType.Attack,"Сосулька","Icicle Shot","Бьёт врага сосулькой.", "Shoots an Icicle at foes.", 10,25),
new Skill("Diaboromon",SkillType.Attack,"Адская ракета","Inferno Missile","Стреляет ракетами по всем врагам.", "Fires Missiles at all foes.", 80,45),
new Skill("Meteormon",SkillType.Assist,"Неуязвимость","Invincibility","Ставит неуязвимость до конца хода.", "Nullifies all attacks against a single ally Digimon.", 20,0),
new Skill("Dokunemon",SkillType.Assist,"Невидимость","Invisibility","Уходит от одиночных атак врага.", "Enemy does not target you.", 8,0),
new Skill("Drimogemon",SkillType.Attack,"Кручёная дрель","Iron Drill Spin","Атакует врага сверлом.", "Attacks with an Iron Drill.", 10,25),
new Skill("Garbagemon",SkillType.Attack,"Джанк Чанкер","Junk Chunker","Стреляет какашкой.", "Shoots Poop at enemies", 12,30),
new Skill("Baihumon",SkillType.Assist,"Конгоу","Kongou","Делает дигимона неуязвимым до конца хода.", "Unbeatable during own turn.", 16,0),
new Skill("Gryphonmon",SkillType.Attack,"Лезвие легенда","Legendary Blade","Атакует всех врагов сверхзвуковой волной.", "Sonic attack on all foes.", 70,40),
new Skill("Goburimon",SkillType.Interrupt,"Живой щит","Life Shield","Снижает атаку вражеского дигимона.", "Lowers tech power of one foe.", 6,0),
new Skill("Andromon",SkillType.Attack,"Спиральный меч","Lightning Blade","Атакует всех врагов световым клинком.", "Lightning Blade hits all foes.", 24,0),
new Skill("Raidramon",SkillType.Attack,"Голубая молния","Lightning Blast","Поражает противника молниями.", "Fires an Electric Burst.", 20,40),
new Skill("Gatomon",SkillType.Attack,"Удар кошки","Lightning Paw","Атакует когтями.", "Attacks with Claws.", 10,25),
new Skill("MegaSeadramon",SkillType.Attack,"Грозовое копье","Lightning Spear","Запускает во врага зелёный электрический шар.", "Fires a Lightning Bolt.", 16,35),
new Skill("Piximon",SkillType.Attack,"Хвост феи","Magical Tail","Атакует копьём.", "Throws a Spear.", 18,37.5m),
new Skill("Gomamon",SkillType.Attack,"Парад рыбок","Marching Fishes","Атака разноцетными рыбками.", "Small Fish Storm attack.", 6,15),
new Skill("NiseDrimogemon",SkillType.Assist,"Механический луч","Mech Ray","Добавляет механический эффект ко всем атакам.", "Changes all moves used by the Digimon to Machine.", 10,0),
new Skill("Apemon",SkillType.Attack,"Бросок костью","Mega Bone Stick","Атакует всех врагов острыми шипами.", "Attacks all foes with needles.", 14,12.5m),
new Skill("Imperialdramon",SkillType.Attack,"Мега огонь","Mega Fire","Мощно атакует всех врагов сгустками энергии.", "Energy Blasts all foes.", 84,42.5m),
new Skill("Piddomon",SkillType.Assist,"Мегалечение","Mega Heal","Восстанавливает 150 HP вашему дигимону.", "Heals one ally Digimon for 150 HP.", 12,0),
new Skill("SkullMeramon",SkillType.Attack,"Атака расплавленным металлом","Metal Fireball","Атакует всех врагов расплавленным металлом.", "Shoot Hot Metal on all foe.", 32,25),
new Skill("Starmon",SkillType.CounterAttack,"Поток метеоров","Meteor Stream","Атакует всех врагов метеорами.", "Hit all foes on Counter.", 12,20),
new Skill("Birdramon",SkillType.Attack,"Крыло метеора","Meteor Wing","Стреляет огненными шарами по всем врагам.", "Fire Wings attack all foes.", 18,15),
new Skill("Tekkamon",SkillType.Interrupt,"Электромеч","MP Destroyer","Снижает силу атаки врага и восстанавливает уровень MP вашего дигимона.", "Absorbs MP used by opponent and lowers tech power.", 12,0),
new Skill("BlueMeramon",SkillType.Interrupt,"Ледяной фантом","MP Magic","Восстанавливает уровень MP вашего дигимона.", "Absorbs MP used by opponent.", 4,0),
new Skill("ShogunGekomon",SkillType.Attack,"Бьющая тональность","Musical Fist","Восстанавливает здоровье дигимонам-вакцинам и бьёт всех остальных.", "Attack will heal opponent when you are Vaccine attacking Data, Data attacking Virus, and Virus attacking Vaccine.", 12,37.5m),
new Skill("MoriShellmon",SkillType.Assist,"Природный луч","Nature Hit Ray","Добавляет природный эффект ко всем атакам.", "Changes all moves used by the Digimon to Nature.", 10,0),
new Skill("Soulmon",SkillType.Assist,"Некромагия","Necro Magic","Позволяет красть MP у лежачих дигимонов.", "Will receive a lot more MP back than simply guarding. Only works on defeated Digimon. Can get MP out of the same Digimon up to 3 times.", 0,0),
new Skill("Togemon",SkillType.CounterAttack,"Тику-тику бам-бам","Needle Spray","Ствит на противника отравление.", "Counter Attack with Poison.", 10,22.5m),
new Skill("Pukumon",SkillType.Attack,"Шквал иголок","Needle Squall","Атакует всех врагов острыми шипами.", "Shoots Spines at all foes.", 80,42.5m),
new Skill("Blossomon",SkillType.Attack,"Кручёный цветок","Ninja Flower","Запускает во врага сюрикен.", "Shoots Flower Shurikens.", 30,25),
new Skill("Ninjamon",SkillType.CounterAttack,"Бросок сюрикена","NinjaKnifeThrow","Атакует врага сюрикенами.", "Counter multiplies total damage by 1.5x.", 10,22.5m),
new Skill("Greymon",SkillType.Attack,"Мега пламя","Nova Blast","Атакует струёй огня.", "Attacks with a Fire Blast.", 12,27.5m),
new Skill("MarineAngemon",SkillType.Attack,"Любовь океана","Ocean Love","Ставит на противника очарование.", "Disables foe's strong techs.", 30,35),
new Skill("PlatinumSukamon",SkillType.Assist,"Волна паники","Panic Wave","Позволяет вашим атакам ставить на врага смятение.", "Addes confusion to an ally's attack.", 10,0),
new Skill("JungleMojyamon",SkillType.Assist,"Восстановление параметров","Parameter Patch","Восстанавливает сниженные параметры вашего дигимона.", "Recovers Digimon's Parameters.", 12,0),
new Skill("Nanimon",SkillType.Attack,"Время партии","Party Time","Увеличивает силу атаки, если ваш дигимон отравлен.", "Increases attack power by 1.5x if you are poisoned.", 10,20),
new Skill("Numemon",SkillType.Attack,"Время партии","Party Time","Увеличивает силу атаки, если ваш дигимон отравлен.", "Increases attack power by 1.5x if you are poisoned.", 10,20),
new Skill("Sukamon",SkillType.Attack,"Время партии","Party Time","Увеличивает силу атаки, если ваш дигимон отравлен.", "Increases attack power by 1.5x if you are poisoned.", 10,20),
new Skill("Vegiemon",SkillType.Attack,"Время партии","Party Time","Увеличивает силу атаки, если ваш дигимон отравлен.", "Increases attack power by 1.5x if you are poisoned.", 10,20),
new Skill("Agumon",SkillType.Attack,"Перцовое дыхание","Pepper Breath","Стреляет огненным шаром.", "Shoots a Fireball.", 8,17.5m),
new Skill("Cherrymon",SkillType.Attack,"Вишнёвая бомба","Pit Pelter","Стреляет вишнями по всем.", "Shoots Pits at all enemies.", 40,27.5m),
new Skill("Palmon",SkillType.Attack,"Ядовитый плющ","Poison Ivy","Ставит на противника отравление.", "Can poison target digimon.", 8,15),
new Skill("WaruSeadramon",SkillType.Assist,"Волна яда","Poison Wave","Позволяет вашим атакам ставить на врага яд.", "Addes poison to an ally's attack.", 26,0),
new Skill("Kimeramon",SkillType.Attack,"Крыло яда","Poison Wing","Выпускает огненный выстрел.", "Shoots a Heat Blast.", 40,60),
new Skill("ExTyrannomon",SkillType.Attack,"Красивая атака","Pretty Attack","Ставит на противника очарование.", "Disables foe's strong techs.", 20,30),
new Skill("Guardromon",SkillType.Attack,"Защита от гранат","Protect Grenade","Выпускает ракету.", "Fires a Homing Missile.", 12,20),
new Skill("Dolphmon",SkillType.Attack,"Пульсовый взрыв","Pulse Blast","Снижает атаку противника.", "Reduces opponent's current attack stat by 20%.", 12,20),
new Skill("Kiwimon",SkillType.Attack,"Маленький клевок","Pummel Peck","Выпускает во врага множество ЧибиКивимонов.", "Sends a Mini-Kiwimon to one foe.", 10,25),
new Skill("Ogremon",SkillType.CounterAttack,"Хаокен","Pummel Whack","Использует MP врага, чтобы контратаковать.", "When countering, you lose the MP of the move that hit you.", 20,30),
new Skill("Puppetmon",SkillType.Attack,"Молот-револьвер","Puppet Pummel","Стреляет во врага пулями из своего молота.", "Explosive Hammer Attack.", 32,50),
new Skill("Floramon",SkillType.Attack,"Душ аллергии","Rain of Pollen","Осыпает врага пыльцой.", "Covers enemy with Pollen.", 6,15),
new Skill("Tinmon",SkillType.Assist,"Оживляющая сила","Recovery Power","Лечит отравление, смятение, паралич у всех союзников.", "Cures confusion, poison, and stun on all allied Digimon.", 36,0),
new Skill("Vermilimon",SkillType.Assist,"Реформатирование","Re-Format","Сбрасывает повышенные характеристики всех врагов.", "Removes all status changes on all opponents, including attack power increases.", 40,0),
new Skill("Hyogamon",SkillType.Assist,"Реинициализация","Re-Initialize","Сбрасывает повышенные характеристики врага.", "Resets the status of one opponent, including increased attack power.", 12,0),
new Skill("Gotsumon",SkillType.Attack,"Булыжник","Rock Fist","Запускает во врага каменную глыбу.", "Shoots Rock at enemy.", 8,20),
new Skill("Rosemon",SkillType.Attack,"Рапира розы","Rose Spear","Бьёт всех врагов цветочной рапирой.", "Hosomi Punch all enemies.", 60,35),
new Skill("RedVegiemon",SkillType.Assist,"Острый перец","RottenRainballs","Позволяет вашим атакам ставить на врага яд.", "Causes one ally digimon to poison opponents when attacking.", 8,0),
new Skill("Deramon",SkillType.Attack,"Королевский орешек","Royal Smasher","Запускает во врага яйцо.", "Shoots Egg at enemies.", 14,32.5m),
new Skill("Preciomon",SkillType.Attack,"Плеск воды печали","Sad Water Blast","Атакует всех врагов печальной волной.", "Hit all foe with Sad Water.", 80,45),
new Skill("SkullMamothmon",SkillType.Attack,"Спиральная кость","S-Bone Crusher","Кидает кости во всех врагов.", "Spinning Bone hits all foe.", 70,40),
new Skill("Kuwagamon",SkillType.Attack,"Коготь ножниц","Scissor Claw","Снижает защиту противника.", "Reduces opponent's current defense stat by ~20% before damage applied.", 12,22.5m),
new Skill("Crabmon",SkillType.Attack,"Наказание ножницами","Scissor Magic","Атака клешнёй.", "A Scissors attack.", 6,15),
new Skill("Phantomon",SkillType.Attack,"Душекрад","Shadow Scythe","Если после этой атаки враг умирает, ваш дигимон атакует ещё раз.", "Attacks again if the target is defeated.", 20,37.5m),
new Skill("Tuskmon",SkillType.Attack,"Боевой клык","Slamming Tusk","Всегда атакует первым.", "Always go first.", 12,22.5m),
new Skill("ClearAgumon",SkillType.Assist,"Малое лечение","Small HP Cure","Восстанавливает 50 HP вашему дигимону.", "Heals 50 HP to one ally digimon.", 6,0),
new Skill("Mamemon",SkillType.CounterAttack,"Бомба с улыбкой","Smiley Bomb","Запускает во всех врагов бомбочки.", "Counter increases multiplies damage by 1.5x.", 16,32.5m),
new Skill("PrinceMamemon",SkillType.CounterAttack,"Таран с улыбкой","Smiley Warhead","Бьёт всех врагов кулаками.", "When countering, Attack Power becomes 60 and All Enemies are hit.", 40,40),
new Skill("Centarumon",SkillType.Attack,"Пушка охотника","Solar Ray","Стреляет лазером из пушки.", "Fires an Energy Burst.", 8,20),
new Skill("Gekomon",SkillType.Attack,"Симфония разрушения","Sonic Crusher","Ставит на противника смятение.", "Sonic Blow can confuse foe.", 12,20),
new Skill("Airdramon",SkillType.Attack,"Игла вращения","Spinning Needle","Осыпает противника иглами.", "Increases attack power by 1.5x against countering enemies.", 10,22.5m),
new Skill("Gizamon",SkillType.Attack,"Спиральный коготь","Spiral Saw","Атакует противника шипами.", "Attacks with Back Fin.", 8,17.5m),
new Skill("Biyomon",SkillType.Attack,"Изгибатель","Spiral Twister","Атакует зелёным шаром огня.", "Shoots a Fireball.", 6,12.5m),
new Skill("Octomon",SkillType.Attack,"Пушка штормового моря","Spurting Ink","Атака чернилами.", "Fires Black Ink Shots.", 10,25),
new Skill("Elecmon",SkillType.Attack,"Искрящаяся молния","S-Thunder Smack","Атакует противника молниями.", "Hits foe with Lightning Bolt.", 6,17.5m),
new Skill("Tortomon",SkillType.Attack,"Твёрдая фаланга","Strong Carapace","Атакует всех врагов острыми шипами.", "Shoots Horns at all foes.", 12,10),
new Skill("Otamamon",SkillType.Attack,"Колыбельный пузырь","Stun Bubble","Ставит на противника смятение.", "Confuses foes with Bubbles.", 8,15),
new Skill("Kokatorimon",SkillType.Attack,"Окаменитель","Stun Flame Shot","Парализует врага.", "Stun foe with a Flame.", 12,20),
new Skill("SandYanmamon",SkillType.Assist,"Парализующий луч","Stun Ray","Позволяет вашим атакам ставить на врага паралич.", "Causes attacks to stun opponent Digimon.", 10,0),
new Skill("Frigimon",SkillType.Attack,"Удар ниже нуля","SubzeroIcePunch","Сила этой атаки повышается с каждым новым ударом.", "Each successive attack adds 2.5 AP.", 10,25),
new Skill("Tentomon",SkillType.Attack,"Маленькая молния","Super Shocker","Атакует врага электрическим разрядом.", "Shoot Static Electricity at foes.", 6,12.5m),
new Skill("Penguinmon",SkillType.Attack,"Бесконечные хлопки","Super Slap","Бьёт противника крылом.", "Slaps an enemy.", 6,15),
new Skill("Scorpiomon",SkillType.CounterAttack,"Хвостовой клинок","Tail Blade","Атакует противника хвостом.", "Avoid attack while resting.", 18,30),
new Skill("Dragomon",SkillType.Attack,"Запретный трезубец","Tentacle Claw","Атакует врага трезубцем.", "Throws a 3 Point Spear.", 16,27.5m),
new Skill("WarGreymon",SkillType.Attack,"Сила земли","Terra Force","Атакует огромным огненным шаром.", "Fires Powerful Energy Shots", 40,60),
new Skill("Wizardmon",SkillType.CounterAttack,"Грозовое облако","Thunder Ball","Парализует противника контратакой.", "Stun foe in Counter Aattack.", 10,22.5m),
new Skill("Yanmamon",SkillType.Attack,"Удар молнии","Thunder Ray","Бьёт врага молнией.", "Fires a Thunder Bolt.", 10,25),
new Skill("Whamon",SkillType.Attack,"Приливная волна","Tidal Wave","Снижает силу атаки всех врагов.", "20% reduction to opponent's current attack stat.", 36,20),
new Skill("Boltmon",SkillType.Attack,"Удар томагавком","Tomahawk Crunch","Бьёт всех врагов томагавком.", "Throws Axes at all enemies.", 60,37.5m),
new Skill("ToyAgumon",SkillType.Attack,"Игрушка-пламя","Toy Flame","Стреляет игрушечным пламенем.", "Shoots Flame Blocks.", 6,15),
new Skill("Omnimon",SkillType.Attack,"Трансцендентный меч","Transcend Sword","Ставит на противника паралич и сильнее бьёт отдыхающих врагов.", "Attack Power increased to 75 against an enemy waiting to counter. Can paralyze.", 38,50),
new Skill("Pumpkinmon",SkillType.Attack,"Шутка или жизнь","Trick or Treat","После применения этой атаки ваша защита уменьшается в два раза до конца хода.", "User has their defense reduced to 0.", 30,30),
new Skill("Triceramon",SkillType.Attack,"Трёхрогая атака","Tri-Horn Attack","Бьёт протиника рогами.", "Attacks with a Horns.", 16,35),
new Skill("Deltamon",SkillType.Attack,"Тройные силы","Triple Forces","Стреляет сгустками энергии по всем врагам.", "Energy Bursts at all foes.", 18,15),
new Skill("Pierrotmon",SkillType.Attack,"Козырной меч","Trump Sword","На эту атаку не действует прерывание.", "Unstoppable sword throw.", 30,45),
new Skill("Mammothmon",SkillType.Attack,"Атака бивнем","Tusk Crusher","Атакует всех врагов бивнем.", "Crushes all foes caught.", 18,32.5m),
new Skill("Woodmon",SkillType.Attack,"Древесная вытяжка","Twig Tap","Вытягивает из врага его HP и передаёт их вашему дигимону.", "Drains enemy HP.", 12,20),
new Skill("Veemon",SkillType.Attack,"Удар головой","Vee Head Butt","Бьёт противника кулаком.", "A Head Butt attack.", 8,20),
new Skill("VenomMyotismon",SkillType.Interrupt,"Инъекция яда","Venom Infusion","Полностью отменяет атаку противника.", "Prevents enemy from attacking.", 40,0),
new Skill("Monzaemon",SkillType.Assist,"Атака вирусов","Virus Attack","Ослабляет всех дигимонов типа вирус.", "Reduces Attack and Defense 20% of all Virus Digimon in battle.", 36,0),
new Skill("Veedramon",SkillType.Attack,"Взрыв В-новой","V-Nova Blast","Сильнее бьёт отдыхающих врагов.", "Attack Power increased by 1.5x against an enemy waiting to counter.", 10,22.5m),
new Skill("Monochromon",SkillType.Attack,"Извержение вулкана","Volcanic Strike","Атакует врага магмой.", "Shoots Fireballs.", 12,30),
new Skill("Zudomon",SkillType.Attack,"Молот вулкана","Vulcan's Hammer","Бьёт всех врагов своим молотом.", "Hits all foe with a hammer.", 28,22.5m),
new Skill("AeroVeedramon",SkillType.Attack,"Лезвие В-крыла","V-Wing Blade","Сильнее бьёт отдыхающих врагов.", "Increases attack power by 1.5x against countering enenmies.", 16,32.5m),
new Skill("Tapirmon",SkillType.Attack,"Ночной кошмар","Waking Dream","Насылает на противника кошмары.", "Nightmare attacks a foe.", 4,10),
new Skill("IceDevimon",SkillType.Assist,"Водный луч","Water Ray","Добавляет водный эффект ко всем атакам.", "Changes all moves used by the Digimon to Water.", 10,0),
new Skill("Garudamon",SkillType.Interrupt,"Крыло тени","Wing Blade","Атакует огненным клинком.", "Fires a Vaccum Blade.", 20,35),
new Skill("WereGarurumon",SkillType.Attack,"Коготь кайзера","Wolf Claw","Атакует противника кастетом.", "Attacks with claws.", 16,35),
new Skill("GranKuwagamon",SkillType.Attack,"Икс-коготь ножниц","X-Scissor Claw","Бьёт противника когтями.", "Attacks with a claw.", 40,55),
new Skill("MasterTyrannomon",SkillType.Assist,"Лечение дзэн","Zen Recovery","Восстанавливает сниженные параметры всех ваших дигимонов.", "Restores Digimon's status to normal.", 40,0),
new Skill("Akatorimon",SkillType.Assist,"Взрыв зип","Zip Boom","Повышает скорость вашего дигимона.", "Boosts one ally Digimon speed by 20%.", 12,0),
new Skill("IceDevimon",SkillType.Attack,"Сосулька","Icicle Shot","Бьёт врага сосулькой.", "Shoots an Icicle at foes.", 10,25,SkillSource.Wild),
new Skill("Akatorimon",SkillType.Attack,"Огненное дыхание","Blaze Blast","Атакует всех врагов огнём.", "Shoots a Breath of Fire.", 10,25,SkillSource.Wild),
new Skill("WaruMonzaemon",SkillType.Attack,"Огненный взрыв","Fire Blast","Атакует всех врагов стеной огня.", "Shoots Flame at all foes.", 22,17.5m,SkillSource.Wild),
new Skill("WaruSeadramon",SkillType.Attack,"Грозовое копье","Lightning Spear","Запускает во врага зелёный электрический шар.", "Fires a Lightning Bolt.", 16,35,SkillSource.Wild),
new Skill("Vermilimon",SkillType.Attack,"Извержение вулкана","Volcanic Strike","Атакует врага магмой.", "Shoots Fireballs.", 12,30,SkillSource.Wild),
new Skill("Gururumon",SkillType.Attack,"Святой выстрел","Air Attack","Запускает во врага сгусток священной энергии.", "Shoots an Air Burst.", 8,20,SkillSource.Wild),
new Skill("DarkLizardmon",SkillType.Attack,"Огненный взрыв","Fire Blast","Атакует всех врагов стеной огня.", "Shoots Flame at all foes.", 22,17.5m,SkillSource.Wild),
new Skill("Dokunemon",SkillType.Attack,"Электронить","Electro Thread","Выпускает электрическую нить.", "Shoots Electro Threads.", 8,17.5m,SkillSource.Wild),
new Skill("JungleMojyamon",SkillType.Attack,"Сосулька","Icicle Shot","Бьёт врага сосулькой.", "Shoots an Icicle at foes.", 10,25,SkillSource.Wild),
new Skill("Jijimon",SkillType.Attack,"Сосулька","Icicle Shot","Бьёт врага сосулькой.", "Shoots an Icicle at foes.", 10,25,SkillSource.Wild),
new Skill("ClearAgumon",SkillType.Attack,"Игрушка-пламя","Toy Flame","Стреляет игрушечным пламенем.", "Shoots Flame Blocks.", 6,15,SkillSource.Wild),
new Skill("MagnaAngemon",SkillType.Attack,"Кулак судьбы","Fist of Fate","Бьёт противника кулаком.", "Throws a Light-Speed Punch.", 10,27.5m,SkillSource.Wild),
new Skill("MasterTyrannomon",SkillType.Attack,"Гигаразрушитель два","Fire Blast 2","Стреляет органической ракетой.", "Fires an Organic Missile.", 20,37.5m,SkillSource.Wild),
new Skill("MasterTyrannomon",SkillType.Attack,"Огненное дыхание","Blaze Blast","Атакует всех врагов огнём.", "Shoots a Breath of Fire.", 10,25,SkillSource.Wild),
new Skill("Monzaemon",SkillType.Attack,"Святой выстрел","Air Attack","Запускает во врага сгусток священной энергии.", "Shoots an Air Burst.", 8,20,SkillSource.Wild),
new Skill("MoriShellmon",SkillType.Attack,"Гидробластер","Hydro Blaster","Атакует противника сжатой водой.", "Shoots High Pressure Water.", 10,25,SkillSource.Wild),
new Skill("MudFrigimon",SkillType.CounterAttack,"Удар короля зверей","Beast King Fist","Возвращает урон в полуторном размере.", "Counter returns damage dealt 1.5x, floored (rounded down).", 12,15,SkillSource.Wild),
new Skill("NiseDrimogemon",SkillType.Attack,"Кручёная дрель","Iron Drill Spin","Атакует врага сверлом.", "Attacks with an Iron Drill.", 10,25,SkillSource.Wild),
new Skill("PlatinumSukamon",SkillType.Attack,"Время партии","Party Time","Увеличивает силу атаки, если ваш дигимон отравлен.", "Increases attack power by 1.5x if you are poisoned.", 10,20,SkillSource.Wild),
new Skill("Panjyamon",SkillType.CounterAttack,"Удар короля зверей","Beast King Fist","Возвращает урон в полуторном размере.", "Counter returns damage dealt 1.5x, floored (rounded down).", 12,15,SkillSource.Wild),
new Skill("Piddomon",SkillType.Attack,"Кулак судьбы","Fist of Fate","Бьёт противника кулаком.", "Throws a Light-Speed Punch.", 10,27.5m,SkillSource.Wild),
new Skill("RedVegiemon",SkillType.Attack,"Время партии","Party Time","Увеличивает силу атаки, если ваш дигимон отравлен.", "Increases attack power by 1.5x if you are poisoned.", 10,20,SkillSource.Wild),
new Skill("Saberdramon",SkillType.Attack,"Изгибатель","Spiral Twister","Атакует зелёным шаром огня.", "Shoots a Fireball.", 6,12.5m,SkillSource.Wild),
new Skill("Seraphimon",SkillType.Attack,"Спиральный меч","Lightning Blade","Атакует всех врагов световым клинком.", "Lightning Blade hits all foes.", 24,0,SkillSource.Wild),
new Skill("Soulmon",SkillType.Attack,"Крыло гризли","Grisly Wing","Выпускает летучих мышей во всех врагов.", "Attack fow with Flying Bats.", 40,30,SkillSource.Wild),
new Skill("SandYanmamon",SkillType.Attack,"Маленький клевок","Pummel Peck","Выпускает во врага множество ЧибиКивимонов.", "Sends a Mini-Kiwimon to one foe.", 10,25,SkillSource.Wild),
new Skill("Tinmon",SkillType.Attack,"Удар молнии","Thunder Ray","Бьёт врага молнией.", "Fires a Thunder Bolt.", 10,25,SkillSource.Wild),
new Skill("Phoenixmon",SkillType.Attack,"Лезвие В-крыла","V-Wing Blade","Сильнее бьёт отдыхающих врагов.", "Increases attack power by 1.5x against countering enenmies.", 16,32.5m,SkillSource.Wild),
new Skill("FlareLizardmon",SkillType.Attack,"Крыло метеора","Meteor Wing","Стреляет огненными шарами по всем врагам.", "Fire Wings attack all foes.", 18,15,SkillSource.Wild),
new Skill("Hyogamon",SkillType.Attack,"Ледяная стрела","Ice Blast","Атакует всех врагов острыми льдинками.", "Shoot IceBlades at all foe.", 18,15,SkillSource.Wild),
new Skill("ShimaUnimon",SkillType.Attack,"Пушка охотника","Solar Ray","Стреляет лазером из пушки.", "Fires an Energy Burst.", 8,20,SkillSource.Wild),
new Skill("Baihumon",SkillType.Attack,"Коготь кайзера","Wolf Claw","Атакует противника кастетом.", "Attacks with claws.", 16,35,SkillSource.Wild),
new Skill("Virus Guardian",SkillType.Assist,"Помощь для защиты","Armor Aid","Повышает защиту самому себе.", "Boosts your defense by 20%.", 20,0),
new Skill("Data Guardian",SkillType.Attack,"Критический удар","Critical Blow","Добивает противника, если у него мало HP.", "Will only deal damage if it will defeat foe.", 26,20),
new Skill("Gaia right hand",SkillType.Assist,"Дестабилизационный луч","Destabilizer Ray","Снижает уровень защиты всех врагов.", "Lowers defense of all enemy Digimon by 20%.", 36,0),
new Skill("Vaccine Guardian",SkillType.Attack,"Энерговзрыв","Energy Blast","Запускает во врага энергосферу.", "Fires an Energy Blast,", 40,60),
new Skill("Gaia",SkillType.Attack,"Фантазма бомба","Fantasmic Bomb","Голубая волна бьёт всех врагов.", "Attack wave on all enemies.", 84,42.5m),
new Skill("Overlord Gaia",SkillType.Attack,"Фантазма луч","Fantasmic Ray","Улучшенная версия Фантазма бомбы.", "Attack wave on all enemies.", 90,45),
new Skill("Gaia",SkillType.CounterAttack,"Удар бога","GAIA Gear","Контратака Гайа. Если она не задействована, то движение промахивается.", "If the counter is not triggered, the move will automatically miss.", 48,67.5m),
new Skill("Data Guardian",SkillType.Attack,"Ополовиниватель","HP Zapper","Ополовинивает HP противника.", "Does damage equal to the amount of HP the target has remaining divided by 2 (rounded down).", 36,0),
new Skill("Vaccine Guardian",SkillType.Attack,"Перцовое дыхание","Karate Sweep","Бьёт всех противников приёмом карате.", "Karate Chops all enemies.", 80,45),
new Skill("Gaia left hand",SkillType.Attack,"Левая рука бога","Left Hand","Атака левой рукой.", "Gives foes a Bakhand Slap.", 36,55),
new Skill("Overlord Gaia",SkillType.Attack,"Абсолютное оружие","Light Gun","Очень сильная атака, которая бьёт всех врагов, если обе руки Гайа уничтожены.", "Shoots stored Light Energy.", 60,70),
new Skill("Virus Guardian",SkillType.Attack,"Рельсовая пушка","Rail Cannon","Стреляет во врага сгустком энергии. Всегда ходит последним.", "Power Attack at end of turn.", 40,67.5m),
new Skill("Gaia left hand",SkillType.Assist,"Редукционный луч","Reduction Ray","Снижает силу атаки врага.", "Lowers target's attack by 20%.", 12,0),
new Skill("Data Guardian",SkillType.Assist,"Сброс статуса","Reset Status","Сбрасывает повышенные характеристики врага.", "Removes all status changes, including boosts.", 32,0),
new Skill("Gaia right hand",SkillType.Attack,"Правая рука бога","Right Hand","Атака правой рукой.", "Gives foes a Backhand Slap.", 30,47.5m),
new Skill("Vaccine Guardian",SkillType.Assist,"Безопасная сфера","Safety Sphere","Повышает защиту самому себе.", "Boosts defense by 20% and less likely to be targeted by enemies.", 18,0),
new Skill("Virus Guardian",SkillType.CounterAttack,"Сильный удар","Stun Punch","Парализует противника кулаками.", "Counter Attack stuns foe.", 44,57.5m),
new Skill("Gaia",SkillType.Attack,"Титан лазер","Titan Laser","Голубой лазер бьёт всех врагов и наносит двойной урон нейтральным целям.", "Shoots Laser at all foes. It appears to add 2 damage against neutral targets.", 90,47.5m),
new Skill("Overlord Gaia",SkillType.CounterAttack,"Бурная атака","Tubular Attack","Контратака Гайа.", "CounterAttack hits all foe.", 56,47.5m),

new Skill("Omnimon",SkillType.Attack,"Пушка Гаруру","Garuru Cannon","Очень сильная атака по всем врагам.", "Fires Missiles at all foes.", 80,45,SkillSource.Wild),
new Skill("Baihumon",SkillType.Attack,"Железные когти","Iron Claws","Механическая версия Силы Земли.", "Basically Machine version of Terra Force.", 40,60,SkillSource.Wild1),
new Skill("Baihumon",SkillType.Attack,"Бронзовая пушка","Bronze Cannon","Механическая версия Пушки Гаруру.", "Basically same as Garuru Cannon with same specialty.", 80,45,SkillSource.Wild1),
new Skill("Omnimon",SkillType.Assist,"Омега лечение","Omega Heal","Восстанавливает 200 HP одному дигимону.", "Heal 200 HP of one digimon.", 16,0,SkillSource.Wild1),
new Skill("Diaboromon",SkillType.Attack,"Потерянный рай","Paradise Lost","Тёмная версия Силы Земли.", "Basically Darkness version of Terra Force.", 40,60,SkillSource.Wild1),
new Skill("ChaosWargreymon",SkillType.Attack,"Гигаразрушитель","Giga Blaster","Запускает во врага органическую ракету.", "Fires an Organic Missile.", 18,37.5m,SkillSource.Wild2),
new Skill("ChaosWarGreymon",SkillType.Attack,"Сила земли","Terra Force","Атакует огромным огненным шаром.", "Fires Powerful Energy Shots", 40,60,SkillSource.Wild2),
new Skill("ChaosSeadramon",SkillType.Attack,"Абсолютный поток","Energy Blast","Атакует всех врагов струёй энергии.", "Shoot Energy Blasts at foe.", 60,37.5m,SkillSource.Wild3),
new Skill("ChaosSeadramon",SkillType.Attack,"Коричневый стингер","Brown Stinger","Ставит на противника отравление.", "Shoots Poison Needles.", 12,20,SkillSource.Wild3),
new Skill("ChaosPierrotmon",SkillType.Attack,"Козырной меч","Trump Sword","На эту атаку не действует прерывание.", "Unstoppable sword throw.", 30,45,SkillSource.Wild4),
new Skill("MetalGreymon",SkillType.Interrupt,"Крыло тени","Wing Blade","Атакует огненным клинком.", "Fires a Vaccum Blade.", 20,35,SkillSource.Wild5),
        };

        public static List<Domain> Domains = new List<Domain>
        {
           new Domain("Бут Домен","Boot Domain"),
new Domain("СКЗИ Домен","SCSI Domain"),
new Domain("Видео Домен","Video Domain"),
new Domain("Диск Домен","Disk Domain"),
new Domain("БИОС Домен","BIOS Domain"),
new Domain("Драйв Домен","Drive Domain"),
new Domain("Веб Домен","Web Domain"),
new Domain("МОДЕМ Домен","MODEM Domain"),
new Domain("СКЗИ Домен (второе посещение)","SCSI Domain (2nd visit)"),
new Domain("Видео Домен (второе посещение)","Video Domain (2nd visit)"),
new Domain("Диск Домен (второе посещение)","Disk Domain (2nd visit)"),
new Domain("Биос Домен (второе посещение)","BIOS Domain (2nd visit)"),
new Domain("Драйв Домен (второе посещение)","Drive Domain (2nd visit)"),
new Domain("Веб Домен (второе посещение)","Web Domain (2nd visit)"),
new Domain("Модем Домен (второе посещение)","MODEM Domain (2nd visit)"),
new Domain("ДВД Домен","DVD Domain"),
new Domain("КОД Домен","CODE Domain"),
new Domain("Лазер Домен","Laser Domain"),
new Domain("Сила Домен","Power Domain"),
new Domain("Диод Домен","Diode Domain"),
new Domain("Гига Домен","Giga Domain"),
new Domain("Порт Домен","Port Domain"),
new Domain("Скан Домен","Scan Domain"),
new Domain("Патч Домен","Patch Domain"),
new Domain("Мега Домен","Mega Domain"),
new Domain("Дата Домен","Data Domain"),
new Domain("Софт Домен","Soft Domain"),
new Domain("Баг Домен","Bug Domain"),
new Domain("РАМ Домен","RAM Domain"),
new Domain("РОМ Домен","ROM Domain"),
new Domain("Башня Ядра","Core Tower"),
new Domain("Башня Хаоса","Chaos Tower"),
new Domain("Тера Домен","Tera Domain"),
        };

        public static Domain GetDomain(string domainId)
        {
            //return new Domain();
            return Domains.FirstOrDefault(x => x.NameEng == domainId);
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
            new Digivolve("Mammothmon","SkullMammothmon",0),
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
            //ищем английские имена
            foreach (var digimon in DigimonTemps)
            {
                var firstOrDefault =
                    DataBase.DBStatic.Digimons.FirstOrDefault(x => x.NameRus.ToLower() == digimon.NameRus.ToLower());
                if (firstOrDefault != null)
                {
                    digimon.NameEng = firstOrDefault.NameEng;
                    digimon.Digimon = firstOrDefault;
                }
                else
                {
                    Console.WriteLine(digimon.NameRus);
                }
            }
            
            foreach (var parent1 in DigimonTempsNotRookie)
            {
                foreach (var parent2 in DigimonTempsNotRookie)
                {

                    var dnaResult = GetChild(parent1.NameEng, parent2.NameEng);

                    if (dnaResult == null) continue;
                   

                    var first =
                        DBStatic.DigivolvesDNA.Any(
                            x => x.DigimonParent1Id == dnaResult.DigimonParent1Id && x.DigimonParent2Id == dnaResult.DigimonParent2Id);

                    var second =
                        DBStatic.DigivolvesDNA.Any(
                            x => x.DigimonParent2Id == dnaResult.DigimonParent1Id && x.DigimonParent1Id == dnaResult.DigimonParent2Id);
                    if (!first && !second)
                        DBStatic.DigivolvesDNA.Add(dnaResult);


                }
            }

        }

        private static DigivolveDNA GetChild(string parent1Str, string parent2Str)
        {

            var parent1 = DigimonTempsNotRookie.FirstOrDefault(x => x.NameEng == parent1Str);
            var parent2 = DigimonTempsNotRookie.FirstOrDefault(x => x.NameEng == parent2Str);

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
                    parent22 = Down(parent22, DigimonTempsNotRookie);
                } while (parent11.Rank != parent22.Rank);
            }
            Dictionary<string, List<string>> dic;
            switch (parent11.Rank)
            {
                case Rank.Champion:
                    dic = ChampTableDictionary;
                    break;
                case Rank.Ultimate:
                    dic = UltimaTableDictionary;
                    break;
                case Rank.Mega:
                    dic = MegaTableDictionary;
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
                    result = DigimonTemps.FirstOrDefault(x => x.Rank == Rank.Rookie && x.ResultCode == strResult);
                    break;
                case Rank.Ultimate:
                    result = DigimonTemps.FirstOrDefault(x => x.Rank == Rank.Champion && x.ResultCode == strResult);
                    break;
                case Rank.Mega:
                    result = DigimonTemps.FirstOrDefault(x => x.Rank == Rank.Ultimate && x.ResultCode == strResult);
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


                    if (!mutations.Any(
                        x => x.DigimonParent1Id == parent1.NameEng && x.DigimonParent2Id == parent2.NameEng)
                        && !mutations.Any(
                            x => x.DigimonParent2Id == parent1.NameEng && x.DigimonParent1Id == parent2.NameEng))
                    {
                        throw new ApplicationException("В таблице мутаций нет этого сочетания");
                    }
                }

                Console.WriteLine(
                    "Parent1={0}(Rank={4})\tParent2={1}(Rank={5})\tParent11={2}(Rank={6})\tParent22={3}(Rank={7})",
                    parent1.NameEng, parent2.NameEng, parent11.NameEng, parent22.NameEng,
                    parent1.Rank, parent2.Rank, parent11.Rank, parent22.Rank);

                return null;
            }

            var dnaResult = new DigivolveDNA(parent1.NameEng, parent2.NameEng, result.NameEng);
            return dnaResult;
        }

        public static new List<DigimonTemp> DigimonTempsNotRookie
        {
            get
            {
                return DigimonTemps.Where(x => x.Rank != Rank.Rookie).ToList();
            }
        }

        public static new List<DigimonTemp> DigimonTemps = new List<DigimonTemp>()
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
        public static Dictionary<string, List<string>> ChampTableDictionary = new Dictionary<string, List<string>>()
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

        public static Dictionary<string, List<string>> UltimaTableDictionary = new Dictionary<string, List<string>>()
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

        public static Dictionary<string, List<string>> MegaTableDictionary = new Dictionary<string, List<string>>()
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



        private static List<DigivolveDNA> GetMutation()
        {
            var tempDna = new List<DigivolveDNA>();
            Dictionary<KeyValuePair<string, string>, string> Mutation = new Dictionary<KeyValuePair<string, string>, string>()
            {
                {new KeyValuePair<string, string>("Черримон", "Зудомон"), "Вадемон"},
                {new KeyValuePair<string, string>("Черримон", "МастерТираномон"), "Вадемон"},
                {new KeyValuePair<string, string>("Черримон", "МеталГреймон"), "Вадемон"},
                {new KeyValuePair<string, string>("Черримон", "Увамон"), "Вадемон"},
                {new KeyValuePair<string, string>("ГеркулкесКабутеримон", "Грифонмон"), "Янмамон"},
                {new KeyValuePair<string, string>("ГеркулкесКабутеримон", "Роземон"), "Янмамон"},
                {new KeyValuePair<string, string>("ГеркулкесКабутеримон", "Баихумон"), "СэндЯнмамон"},
                {new KeyValuePair<string, string>("ГеркулкесКабутеримон", "МеталГарурумон"), "СэндЯнмамон"},
                {new KeyValuePair<string, string>("ГеркулкесКабутеримон", "ПринцМамемон"), "СэндЯнмамон"},
                {new KeyValuePair<string, string>("ГеркулкесКабутеримон", "СаберЛеомон"), "СэндЯнмамон"},
                //хз может неправильно
                { new KeyValuePair<string, string>("Паппетмон","Зудомон"),"Вадемон"  },
                {new KeyValuePair<string, string>("Паппетмон","МастерТираномон"),"Вадемон"  },
                {new KeyValuePair<string, string>("Паппетмон","МеталГреймон"),"Вадемон"  },
                {new KeyValuePair<string, string>("Паппетмон","Увамон"),"Вадемон"  },


                {new KeyValuePair<string, string>("Черримон","БойГреймон"),"Вадемон"  },
                {new KeyValuePair<string, string>("Черримон","МаринеАнгемон"),"Вадемон"  },
                {new KeyValuePair<string, string>("Черримон","Омнимон"),"Вадемон"  },
                {new KeyValuePair<string, string>("Черримон","Пречиомон"),"Вадемон"  },
            };
            Dictionary<KeyValuePair<string, string>, string> MutationEng =
                new Dictionary<KeyValuePair<string, string>, string>();

            foreach (var mutation in Mutation)
            {
                MutationEng.Add(
                    new KeyValuePair<string, string>(
                        DBStatic.Digimons.FirstOrDefault(x => x.NameRus == mutation.Key.Key).NameEng,
                        DBStatic.Digimons.FirstOrDefault(x => x.NameRus == mutation.Key.Value).NameEng),
                    DBStatic.Digimons.FirstOrDefault(x => x.NameRus == mutation.Value).NameEng);
            }

            foreach (var mutationEng in MutationEng)
            {
                tempDna.Add(new DigivolveDNA(mutationEng.Key.Key, mutationEng.Key.Value, mutationEng.Value));
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
