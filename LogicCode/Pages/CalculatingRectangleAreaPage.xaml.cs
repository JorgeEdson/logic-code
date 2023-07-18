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
    /// Interaction logic for CalculatingRectangleAreaPage.xaml
    /// </summary>
    public partial class CalculatingRectangleAreaPage : Page
    {
        public CalculatingRectangleAreaPage()
        {
            InitializeComponent();
            StringBuilder codeBuilder = new StringBuilder();
            codeBuilder.AppendLine("var area = decimal.Parse(textBoxWidth.Text) * decimal.Parse(textBoxHeight.Text);");
            codeBuilder.AppendLine("textBlockOutput.Text = \"The area this Rectangle is \" + area;");
            textBlockCode.Text = codeBuilder.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var area = decimal.Parse(textBoxWidth.Text) * decimal.Parse(textBoxHeight.Text);
            textBlockOutput.Text = "The area this Rectangle is " + area;
        }
    }
}
