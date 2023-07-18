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

namespace LogicCode.Pages
{
    /// <summary>
    /// Interaction logic for ConverterMetersToCentimetersPage.xaml
    /// </summary>
    public partial class ConverterMetersToCentimetersPage : Page
    {
        public ConverterMetersToCentimetersPage()
        {
            InitializeComponent();
            StringBuilder codeBuilder = new StringBuilder();
            codeBuilder.AppendLine("var centimeters = decimal.Parse(textBoxMeters.Text) * 100;");            
            codeBuilder.AppendLine("textBlockOutput.Text = textBoxMeters.Text + \" meters converted to centimeters is \" + Math.Floor(centimeters);");            
            textBlockCode.Text = codeBuilder.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var centimeters = decimal.Parse(textBoxMeters.Text) * 100;
            textBlockOutput.Text = textBoxMeters.Text + " meters converted to centimeters is " + Math.Floor(centimeters);
        }
    }
}
