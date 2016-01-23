using System.ComponentModel;
using System.Runtime.CompilerServices;
using DataBase;
using DW2DB.Annotations;

namespace DW2DB.ViewModels
{
    public class SkillVM : INotifyPropertyChanged
    {
        public Skill Source { get; set; }

        public SkillVM(Skill source)
        {
            Source = source;
            UpdateFields();
        }

        private void UpdateFields()
        {
            switch (App.Language.Name)
            {
                case "ru-RU":
                    Name = Source.NameRus;
                    Description = Source.DescriptionRus;
                    Type = ClassHelper.SkillTypeRus[Source.Type];
                    break;
                default:
                    Name = Source.NameEng;
                    Description = Source.DescriptionEng;
                    Type = ClassHelper.SkillTypeEng[Source.Type];
                    break;
            }
            OnPropertyChanged(nameof(Name));
            OnPropertyChanged(nameof(Description));
            OnPropertyChanged(nameof(Type));
        }

        public string Type { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }



        public event PropertyChangedEventHandler PropertyChanged;

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}