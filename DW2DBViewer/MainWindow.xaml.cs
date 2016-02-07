using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;

namespace DW2DBViewer
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            App.LanguageChanged += LanguageChanged;

            var currLang = App.Language;

            //Заполняем меню смены языка:
            MenuLanguage.Items.Clear();
            foreach (var lang in App.Languages)
            {
                var menuLang = new MenuItem();
                menuLang.Header = lang.DisplayName;
                menuLang.Tag = lang;
                menuLang.IsChecked = lang.Equals(currLang);
                menuLang.Click += ChangeLanguageClick;
                MenuLanguage.Items.Add(menuLang);
            }
        }

        private void LanguageChanged(object sender, EventArgs e)
        {
            var needRestart = false;
            var currLang = App.Language;

            //Отмечаем нужный пункт смены языка как выбранный язык
            foreach (MenuItem i in MenuLanguage.Items)
            {
                var ci = i.Tag as CultureInfo;

                needRestart = i.IsChecked != (ci != null && ci.Equals(currLang));

                i.IsChecked = ci != null && ci.Equals(currLang);
            }

            if (needRestart)
            {
                Process.Start(Application.ResourceAssembly.Location);
                Application.Current.Shutdown();
            }
        }

        private void ChangeLanguageClick(object sender, EventArgs e)
        {
            var mi = sender as MenuItem;
            if (mi != null)
            {
                var lang = mi.Tag as CultureInfo;
                if (lang != null)
                {
                    App.Language = lang;
                }
            }
        }
    }

    /// <summary>
    ///     Конвертер булевого значения в невидимость
    /// </summary>
    [ValueConversion(typeof (bool), typeof (Visibility))]
    public class InvisibilityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (bool) value ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return 0;
        }
    }
}