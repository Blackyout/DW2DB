using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DataBase;
using DW2DBViewer.ViewModels;

namespace DW2DBViewer
{
    public static class DBLoader
    {
        private static decimal _percentLoadDigimons;

        public static Action<decimal> PercentDigimonChanged;
        public static Action<decimal> PercentDNAChanged;
        public static Action<List<DigimonVM>> DigimonLoadCompleted;
        public static Action<List<DigimonVM>, List<DigivolveDNAOptionVM>> DNALoadCompleted;
        private static decimal _percentLoadDna;
        public static List<DigimonVM> AllDigimons { get; set; }

        public static List<DigivolveDNAOptionVM> AllOptions { get; set; }

        public static List<DigimonVM> NoRookie
        {
            get { return AllDigimons.Where(x => x.Source.Rank != Rank.Rookie).ToList(); }
        }

        public static void LoadStatic()
        {
            AllDigimons = DBStatic.GetAllDigimons().GetVMs();
            DigimonLoadCompleted?.Invoke(AllDigimons);
            DNALoadCompleted?.Invoke(AllDigimons, AllOptions);
        }


        public static List<DigimonVM> GetVMs(this IEnumerable<Digimon> digimons)
        {
            var result = new List<DigimonVM>();
            var count = digimons.Count();
            var index = 0;

            foreach (var digimon in digimons)
            {
                result.Add(digimon.GetVM());
            }

            foreach (var digimonVm in result)
            {
                digimonVm.DigivolveFrom =
                    new ObservableCollection<DigivolveDigimonVM>(digimonVm.Source.DigivolesFrom.OrderBy(x => x.DP)
                        .Select(
                            x => new DigivolveDigimonVM
                            {
                                Digimon = result.FirstOrDefault(y => y.Source.NameEng == x.DigimonFromId),
                                DP = x.DP
                            }));
                digimonVm.DigivolveTo =
                    new ObservableCollection<DigivolveDigimonVM>(digimonVm.Source.DigivolesTo.OrderBy(x => x.DP).Select(
                        x => new DigivolveDigimonVM
                        {
                            Digimon = result.FirstOrDefault(y => y.Source.NameEng == x.DigimonToId),
                            DP = x.DP
                        }));
                index++;
                PercentDigimonChanged?.Invoke((decimal) index/count);
            }

            return result.OrderBy(x => x.Name).ToList();
        }


        public static DigimonVM GetVM(this Digimon digimon)
        {
            var vm = new DigimonVM();
            vm.DigivolveFrom = new ObservableCollection<DigivolveDigimonVM>();
            vm.DigivolveTo = new ObservableCollection<DigivolveDigimonVM>();
            vm.Skills = new ObservableCollection<SkillVM>();

            vm.Source = digimon;
            //Локализуем поля
            switch (App.Language.Name)
            {
                case "ru-RU":
                    vm.Name = digimon.NameRus;
                    vm.Rank = ClassHelper.RankRus[digimon.Rank];
                    vm.Type = ClassHelper.TypeRus[digimon.Type];
                    vm.Speciality = ClassHelper.SpecialityRus[digimon.Speciality];
                    break;
                default:
                    vm.Name = digimon.NameEng;
                    vm.Rank = ClassHelper.RankEng[digimon.Rank];
                    vm.Type = ClassHelper.TypeEng[digimon.Type];
                    vm.Speciality = ClassHelper.SpecialityEng[digimon.Speciality];
                    break;
            }

            //Переливаем скиллы
            foreach (var skill in digimon.Skills)
            {
                var skillVm = new SkillVM();
                skillVm.Source = skill;
                switch (App.Language.Name)
                {
                    case "ru-RU":
                        skillVm.Name = skill.NameRus;
                        skillVm.Description = skill.SkillSource != SkillSource.Native
                            ? $"{skill.DescriptionRus} ({ClassHelper.SkillSourceRus[skill.SkillSource]})"
                            : skill.DescriptionRus;
                        skillVm.Type = ClassHelper.SkillTypeRus[skill.Type];
                        break;
                    default:
                        skillVm.Name = skill.NameEng;
                        skillVm.Description = skill.SkillSource != SkillSource.Native
                            ? $"{skill.DescriptionEng} ({ClassHelper.SkillSourceEng[skill.SkillSource]})"
                            : skill.DescriptionEng;
                        skillVm.Type = ClassHelper.SkillTypeEng[skill.Type];
                        break;
                }

                vm.Skills.Add(skillVm);
            }


            //Переливаем локации в одну строку

            var locations = new List<string>();

            foreach (var location in digimon.Locations)
            {
                switch (App.Language.Name)
                {
                    case "ru-RU":
                        locations.Add(location.Domain != null
                            ? location.Domain.NameRus + " Эт.:" + string.Join(",", location.Floors)
                            : location.DescriptionRus);
                        break;
                    default:
                        locations.Add(location.Domain != null
                            ? location.Domain.NameEng + " Lvl:" + string.Join(",", location.Floors)
                            : location.DescriptionEng);
                        break;
                }
            }
            vm.LocationStr = string.Join(" || ", locations);

            return vm;
        }
    }
}