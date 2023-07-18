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
    /// Interaction logic for ConvertAgeToDaysPage.xaml
    /// </summary>
    public partial class ConvertAgeToDaysPage : Page
    {
        public ConvertAgeToDaysPage()
        {
            InitializeComponent();
            StringBuilder codeBuilder = new StringBuilder();
            codeBuilder.AppendLine("var onlyDays = (decimal.Parse(textBoxYears.Text)*365)+");
            codeBuilder.AppendLine("    (decimal.Parse(textBoxMonths.Text) * 30)+");            
            codeBuilder.AppendLine("    decimal.Parse(textBoxDays.Text);");            
            codeBuilder.AppendLine("textBlockOutput.Text = \"The complete age only in days age is \" + Math.Floor(onlyDays);");       
            
            textBlockCode.Text = codeBuilder.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var onlyDays = (decimal.Parse(textBoxYears.Text)*365)+
                (decimal.Parse(textBoxMonths.Text) * 30)+
                decimal.Parse(textBoxDays.Text);
            textBlockOutput.Text = "The complete age only in days age is " + Math.Floor(onlyDays);
        }
    }
}
