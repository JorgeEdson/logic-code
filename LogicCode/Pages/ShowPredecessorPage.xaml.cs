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
    /// Interaction logic for ShowPredecessorPage.xaml
    /// </summary>
    public partial class ShowPredecessorPage : Page
    {
        public ShowPredecessorPage()
        {
            InitializeComponent();
            StringBuilder codeBuilder = new StringBuilder();
            codeBuilder.AppendLine("var predecessor = int.Parse(textBoxValue.Text) - 1;");
            codeBuilder.AppendLine("textBlockOutput.Text = \"The predecessor of \" + textBoxValue.Text + \" is \" + predecessor;");            
            textBlockCode.Text = codeBuilder.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            var predecessor = int.Parse(textBoxValue.Text) - 1;
            textBlockOutput.Text = "The predecessor of " + textBoxValue.Text + " is " + predecessor;

        }
    }
}
