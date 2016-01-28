﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace DW2DBViewer
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        IWorker Worker = new AsyncWorker();

        private static List<CultureInfo> m_Languages = new List<CultureInfo>();

        public static List<CultureInfo> Languages
        {
            get
            {
                return m_Languages;
            }
        }

        public App()
        {
//            if (!Directory.Exists("DigimonPic"))
//                Directory.CreateDirectory("DigimonPic");

            m_Languages.Clear();
            m_Languages.Add(new CultureInfo("en-US")); //Нейтральная культура для этого проекта
            m_Languages.Add(new CultureInfo("ru-RU"));
            App.LanguageChanged += App_LanguageChanged;
        }

        //Евент для оповещения всех окон приложения
        public static event EventHandler LanguageChanged;

        public static CultureInfo Language
        {
            get
            {
                return System.Threading.Thread.CurrentThread.CurrentUICulture;
            }
            set
            {
                if (value == null) throw new ArgumentNullException("value");
                if (value == System.Threading.Thread.CurrentThread.CurrentUICulture) return;

                //1. Меняем язык приложения:
                System.Threading.Thread.CurrentThread.CurrentUICulture = value;

                //2. Создаём ResourceDictionary для новой культуры
                ResourceDictionary dict = new ResourceDictionary();
                switch (value.Name)
                {
                    case "ru-RU":
                        dict.Source = new Uri(String.Format("Resources/lang.{0}.xaml", value.Name), UriKind.Relative);
                        break;
                    default:
                        dict.Source = new Uri("Resources/lang.xaml", UriKind.Relative);
                        break;
                }

                //3. Находим старую ResourceDictionary и удаляем его и добавляем новую ResourceDictionary
                ResourceDictionary oldDict = (Application.Current.Resources.MergedDictionaries.Where(
                    d => d.Source != null && d.Source.OriginalString.StartsWith("Resources/lang."))).First();
                if (oldDict != null)
                {
                    int ind = Application.Current.Resources.MergedDictionaries.IndexOf(oldDict);
                    Application.Current.Resources.MergedDictionaries.Remove(oldDict);
                    Application.Current.Resources.MergedDictionaries.Insert(ind, dict);
                }
                else
                {
                    Application.Current.Resources.MergedDictionaries.Add(dict);
                }

                //4. Вызываем евент для оповещения всех окон.
                LanguageChanged(Application.Current, new EventArgs());
            }
        }

        public void Application_LoadCompleted(object sender, StartupEventArgs startupEventArgs)
        {
            Language = DW2DBViewer.Properties.Settings.Default.DefaultLanguage;


//            try
//            {
//                DBLoader.Load();
//            }
//            catch (Exception e)
//            {
//                MessageBox.Show(e.ToString());
//
//            }


             
                Worker.DoWork(DBLoader.Load, () =>
                {
                }, OnError);
    

         


        }

        private void OnError(Exception obj)
        {
            MessageBox.Show(obj.ToString());
        }

        private void App_LanguageChanged(Object sender, EventArgs e)
        {
//            DW2DBViewer.
            DW2DBViewer.Properties.Settings.Default.DefaultLanguage = Language;
            DW2DBViewer.Properties.Settings.Default.Save();
        }

        
    }

  
}