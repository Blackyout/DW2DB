using System.ComponentModel;
using System.Runtime.CompilerServices;
using DataBase;
using DW2DB.Annotations;

namespace DW2DB.ViewModels
{
    public class SkillVM
    {
        public Skill Source { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }
    }
}