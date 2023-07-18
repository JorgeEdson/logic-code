using LogicCode.Pages;
using System;
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

namespace LogicCode
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Menu_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {            
            var selectedItem = e.NewValue as TreeViewItem;
            if (selectedItem != null)
            {                
                var tag = selectedItem.Tag as string;
                switch (tag)
                {
                    case "SequentialEx01":
                        MainContent.Navigate(new ChangeValuesPage());
                        break;
                    case "SequentialEx02":
                        MainContent.Navigate(new ShowPredecessorPage());
                        break;
                    case "SequentialEx03":
                        MainContent.Navigate(new ConverterMetersToCentimetersPage());
                        break;
                    case "SequentialEx04":
                        MainContent.Navigate(new CalculatingRectangleAreaPage());
                        break;
                    case "SequentialEx05":
                        MainContent.Navigate(new ConvertAgeToDaysPage());
                        break;
                    default:
                        MainContent.Content = string.Empty;
                        break;
                }
            }
        }
    }
}

