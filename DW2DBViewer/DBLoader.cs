﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using DataBase;
using DW2DBViewer.ViewModels;

namespace DW2DBViewer
{
    public static class DBLoader
    {
        private static decimal _percentLoadDigimons;
        public static List<DigimonVM> AllDigimons { get; set; }

        public static DigimonVM Get(Guid guid)
        {
            return AllDigimons.FirstOrDefault(x => x.Source.Id == guid);
        }



        public static List<DigivolveDNAOptionVM> AllOptions { get; set; }

        public static List<DigimonVM> NoRookie
        {
            get { return AllDigimons.Where(x => x.Source.Rank != Rank.Rookie).ToList(); }
        }


        public static void Load()
        {
            var temp = DateTime.Now;
            using (DB db = new DB())
            {
                AllDigimons = db.dw2DbContext.Digimons.GetVMs();
                DigimonLoadCompleted?.Invoke(AllDigimons);
                AllOptions = db.dw2DbContext.DigivolveDnas.GetVMs(AllDigimons);
                DNALoadCompleted?.Invoke(AllDigimons, AllOptions);

            }
            MessageBox.Show("LoadTime = " + (DateTime.Now - temp));
        }

        public static void LoadStatic()
        {
            var temp = DateTime.Now;
            using (DB db = new DB())
            {
                AllDigimons = db.dw2DbContext.Digimons.GetVMs();
                DigimonLoadCompleted?.Invoke(AllDigimons);
                AllOptions = db.dw2DbContext.DigivolveDnas.GetVMs(AllDigimons);
                DNALoadCompleted?.Invoke(AllDigimons, AllOptions);

            }
            MessageBox.Show("LoadTime = " + (DateTime.Now - temp));
        }




        public static Action<decimal> PercentDigimonChanged;
        public static Action<decimal> PercentDNAChanged;
        public static Action<List<DigimonVM>> DigimonLoadCompleted;
        public static Action<List<DigimonVM>,List<DigivolveDNAOptionVM>> DNALoadCompleted;
        private static decimal _percentLoadDna;

        public static List<DigivolveDNAOptionVM> GetVMs(this IEnumerable<DigivolveDNA> digivolveDnas, List<DigimonVM> allDigimons)
        {
            var result = new List<DigivolveDNAOptionVM>();
            var count = digivolveDnas.Count();
            var index = 0;


            foreach (var digivolveDna in digivolveDnas)
            {
                var vm = new DigivolveDNAOptionVM();
                vm.Parents = digivolveDna.Parents.Select(x => Get(x.Parent.Id)).ToList();
                vm.Result = Get(digivolveDna.Result.Id);
                result.Add(vm);
                index++;
                PercentDNAChanged?.Invoke(((decimal)index / count));
            }
            return result;
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
                    new ObservableCollection<DigivolveDigimonVM>(digimonVm.Source.DigivolesFrom.OrderBy(x => x.DP).Select(
                        x => new DigivolveDigimonVM()
                        {
                            Digimon = result.FirstOrDefault(y => y.Source.Id == x.DigimonFrom.Id),
                            DP = x.DP
                        }));
                digimonVm.DigivolveTo =
                    new ObservableCollection<DigivolveDigimonVM>(digimonVm.Source.DigivolesTo.OrderBy(x => x.DP).Select(
                        x => new DigivolveDigimonVM()
                        {
                            Digimon = result.FirstOrDefault(y => y.Source.Id == x.DigimonTo.Id),
                            DP = x.DP
                        }));
                index++;
                PercentDigimonChanged?.Invoke(((decimal)index / count));
            }

            return result.OrderBy(x=>x.Name).ToList();

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
                        skillVm.Description = skill.DescriptionRus;
                        skillVm.Type = ClassHelper.SkillTypeRus[skill.Type];
                        break;
                    default:
                        skillVm.Name = skill.NameEng;
                        skillVm.Description = skill.DescriptionEng;
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
                            ? location.Domain.NameRus + " " + String.Join(",", location.Floors)
                            : location.DescriptionRus);
                        break;
                    default:
                        locations.Add(location.Domain != null
                            ? location.Domain.NameEng + " " + String.Join(",", location.Floors)
                            : location.DescriptionEng);
                        break;
                }
            }
            vm.LocationStr = string.Join("; ", locations);

            return vm;
        }
    }
}