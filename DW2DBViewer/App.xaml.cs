using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows;
using System.Windows.Data;
using DW2DBViewer.Properties;

namespace DW2DBViewer
{
    /// <summary>
    ///     Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private IWorker Worker = new AsyncWorker();

        public App()
        {
//            if (!Directory.Exists("DigimonPic"))
//                Directory.CreateDirectory("DigimonPic");

            Languages.Clear();
            Languages.Add(new CultureInfo("en-US")); //Нейтральная культура для этого проекта
            Languages.Add(new CultureInfo("ru-RU"));
            LanguageChanged += App_LanguageChanged;
        }

        public static List<CultureInfo> Languages { get; } = new List<CultureInfo>();

        public static CultureInfo Language
        {
            get { return Thread.CurrentThread.CurrentUICulture; }
            set
            {
                if (value == null) throw new ArgumentNullException("value");
                if (value == Thread.CurrentThread.CurrentUICulture) return;

                //1. Меняем язык приложения:
                Thread.CurrentThread.CurrentUICulture = value;

                //2. Создаём ResourceDictionary для новой культуры
                var dict = new ResourceDictionary();
                switch (value.Name)
                {
                    case "ru-RU":
                        dict.Source = new Uri(string.Format("Resources/lang.{0}.xaml", value.Name), UriKind.Relative);
                        break;
                    default:
                        dict.Source = new Uri("Resources/lang.xaml", UriKind.Relative);
                        break;
                }

                //3. Находим старую ResourceDictionary и удаляем его и добавляем новую ResourceDictionary
                var oldDict = Current.Resources.MergedDictionaries.Where(
                    d => d.Source != null && d.Source.OriginalString.StartsWith("Resources/lang.")).First();
                if (oldDict != null)
                {
                    var ind = Current.Resources.MergedDictionaries.IndexOf(oldDict);
                    Current.Resources.MergedDictionaries.Remove(oldDict);
                    Current.Resources.MergedDictionaries.Insert(ind, dict);
                }
                else
                {
                    Current.Resources.MergedDictionaries.Add(dict);
                }

                //4. Вызываем евент для оповещения всех окон.
                LanguageChanged(Current, new EventArgs());
            }
        }

        //Евент для оповещения всех окон приложения
        public static event EventHandler LanguageChanged;

        public void Application_LoadCompleted(object sender, StartupEventArgs startupEventArgs)
        {
            Language = Settings.Default.DefaultLanguage;
        }

        private void OnError(Exception obj)
        {
            MessageBox.Show(obj.ToString());
        }

        private void App_LanguageChanged(object sender, EventArgs e)
        {
            Settings.Default.DefaultLanguage = Language;
            Settings.Default.Save();
        }
    }

    [ValueConversion(typeof (string), typeof (string))]
    public class ImagePathConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return $"pack://application:,,,/PicDB;component/Pics/{value}.jpg";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return null;
        }
    }
}