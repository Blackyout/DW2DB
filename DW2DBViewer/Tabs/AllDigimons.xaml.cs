using System;
using System.Windows;
using System.Windows.Controls;
using DW2DBViewer.ViewModels;

namespace DW2DBViewer
{
    /// <summary>
    ///     Interaction logic for AllDigimons.xaml
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
                typeof (DigimonVM),
                typeof (SelectingItemAttachedProperty),
                new PropertyMetadata(default(DigimonVM), OnSelectingItemChanged));

            public static DigimonVM GetSelectingItem(DependencyObject target)
            {
                return (DigimonVM) target.GetValue(SelectingItemProperty);
            }

            public static void SetSelectingItem(DependencyObject target, DigimonVM value)
            {
                target.SetValue(SelectingItemProperty, value);
            }

            private static void OnSelectingItemChanged(DependencyObject sender, DependencyPropertyChangedEventArgs e)
            {
                var grid = sender as DataGrid;
                if (grid == null || grid.SelectedItem == null)
                    return;
                // Works with .Net 4.0
                grid.Dispatcher.BeginInvoke((Action) (() =>
                {
                    grid.UpdateLayout();
                    grid.ScrollIntoView(grid.SelectedItem, null);
                }));
            }
        }
    }
}