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
    /// Interaction logic for ChangeValuesPage.xaml
    /// </summary>
    public partial class ChangeValuesPage : Page
    {
        public ChangeValuesPage()
        {
            InitializeComponent();
            StringBuilder codeBuilder = new StringBuilder();
            codeBuilder.AppendLine("var change = textBoxValueA.Text;");
            codeBuilder.AppendLine("textBoxValueA.Text = textBoxValueB.Text;");
            codeBuilder.AppendLine("textBoxValueB.Text = change;");
            codeBuilder.AppendLine("textBlockOutput.Text = \"Values have been exchanged.\";");
            textBlockCode.Text = codeBuilder.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var change = textBoxValueA.Text;
            textBoxValueA.Text = textBoxValueB.Text;
            textBoxValueB.Text = change;

            textBlockOutput.Text = "Values have been exchanged.";
        }
    }
}
