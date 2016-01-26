﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Imaging;
using DataBase;
using DW2DB.ViewModels;

namespace DW2DB
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
            using (DB db = new DB())
            {
                AllDigimons = db.dw2DbContext.Digimons.GetVMs();
                AllOptions = db.dw2DbContext.DigivolveDnas.GetVMs(AllDigimons);
            }
        }

        public static Action PercentDigimonChanged;
        public static Action PercentDNAChanged;
        private static decimal _percentLoadDna;

        public static decimal PercentLoadDigimons   
        {
            get { return _percentLoadDigimons; }
            set
            {
                _percentLoadDigimons = value;
                PercentDigimonChanged?.Invoke();
            }
        }

        public static decimal PercentLoadDNA    
        {
            get { return _percentLoadDna; }
            set
            {
                _percentLoadDna = value;
                PercentDNAChanged?.Invoke();
            }
        }


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
                PercentLoadDNA = ((decimal)index / count);
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
                var vm = digimon.GetVM();
                vm.DigivolveFrom =
                    new ObservableCollection<DigivolveDigimonVM>(vm.Source.DigivolesFrom.OrderBy(x => x.DP).Select(
                        x => new DigivolveDigimonVM()
                        {
                            Digimon = result.FirstOrDefault(y => y.Source.Id == x.DigimonFrom.Id),
                            DP = x.DP
                        }));
                vm.DigivolveTo =
                    new ObservableCollection<DigivolveDigimonVM>(vm.Source.DigivolesTo.OrderBy(x => x.DP).Select(
                        x => new DigivolveDigimonVM()
                        {
                            Digimon = result.FirstOrDefault(y => y.Source.Id == x.DigimonTo.Id),
                            DP = x.DP
                        }));
                result.Add(vm);
                index++;
                PercentLoadDigimons = ((decimal) index/count);
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
