﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using DW2DB.ViewModels;

namespace DW2DB
{
    /// <summary>
    /// Interaction logic for AllDigimons.xaml
    /// </summary>
    public partial class AllDigimons : UserControl
    {
        public AllDigimons()
        {
            InitializeComponent();
        }
    }

    namespace MyAttachedProperties
    {
        public class SelectingItemAttachedProperty
        {
            public static readonly DependencyProperty SelectingItemProperty = DependencyProperty.RegisterAttached(
                "SelectingItem",
                typeof(DigimonVM),
                typeof(SelectingItemAttachedProperty),
                new PropertyMetadata(default(DigimonVM), OnSelectingItemChanged));

            public static DigimonVM GetSelectingItem(DependencyObject target)
            {
                return (DigimonVM)target.GetValue(SelectingItemProperty);
            }

            public static void SetSelectingItem(DependencyObject target, DigimonVM value)
            {
                target.SetValue(SelectingItemProperty, value);
            }

            static void OnSelectingItemChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
            {
                var grid = sender as DataGrid;
                if (grid == null || grid.SelectedItem == null)
                    return;
                // Works with .Net 4.0
                grid.Dispatcher.BeginInvoke((Action)(() =>
                {
                    grid.UpdateLayout();
                    grid.ScrollIntoView(grid.SelectedItem, null);
                }));
            }
        }
    }
}
