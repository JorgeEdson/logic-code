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

namespace LogicCode.Controls
{
    /// <summary>
    /// Interaction logic for ExampleControl.xaml
    /// </summary>
    public partial class ExampleControl : UserControl
    {
        public ExampleControl()
        {
            InitializeComponent();
            DataContext = this;
        }

        public static readonly DependencyProperty TitleExampleProperty =
            DependencyProperty.Register("titleExample", typeof(object), typeof(ExampleControl), new PropertyMetadata(null));

        public object TitleExample
        {
            get { return GetValue(TitleExampleProperty); }
            set { SetValue(TitleExampleProperty, value); }
        }

        public static readonly DependencyProperty DescriptionExampleProperty =
            DependencyProperty.Register("descriptionExample", typeof(object), typeof(ExampleControl), new PropertyMetadata(null));

        public object DescriptionExample
        {
            get { return GetValue(DescriptionExampleProperty); }
            set { SetValue(DescriptionExampleProperty, value); }
        }

        public static readonly DependencyProperty InputsExampleProperty =
            DependencyProperty.Register("inputsExample", typeof(object), typeof(ExampleControl), new PropertyMetadata(null));

        public object InputsExample
        {
            get { return GetValue(InputsExampleProperty); }
            set { SetValue(InputsExampleProperty, value); }
        }

        public TextBlock TextBlockOutput
        {
            get { return textBlockOutput; }
        }

        public TextBlock TextBlockCode
        {
            get { return textBlockCode; }
        }
    }
}
