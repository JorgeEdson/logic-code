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

        #region TitleExample Property
        public static readonly DependencyProperty TitleExampleProperty =
            DependencyProperty.Register("titleExample", typeof(UIElement), typeof(ExampleControl), new PropertyMetadata(null, TitleExampleOnComponentChanged));
        public UIElement TitleExample
        {
            get { return (UIElement)GetValue(TitleExampleProperty); }
            set { SetValue(TitleExampleProperty, value); }
        }
        #endregion

        #region DescriptionExample Property
        public static readonly DependencyProperty DescriptionExampleProperty =
            DependencyProperty.Register("descriptionExample", typeof(UIElement), typeof(ExampleControl), new PropertyMetadata(null, DescriptionExampleOnComponentChanged));
        public UIElement DescriptionExample
        {
            get { return (UIElement)GetValue(DescriptionExampleProperty); }
            set { SetValue(DescriptionExampleProperty, value); }
        }
        #endregion

        #region InputsExample Property
        public static readonly DependencyProperty InputsExampleProperty =
            DependencyProperty.Register("inputsExample", typeof(UIElement), typeof(ExampleControl), new PropertyMetadata(null, InputsExampleOnComponentChanged));
        public UIElement InputsExample
        {
            get { return (UIElement)GetValue(InputsExampleProperty); }
            set { SetValue(InputsExampleProperty, value); }
        }
        #endregion

        public TextBlock TextBlockOutput
        {
            get { return textBlockOutput; }
        }

        public TextBlock TextBlockCode
        {
            get { return textBlockCode; }
        }

        private static void TitleExampleOnComponentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var userControl = d as ExampleControl;
            if (userControl != null)
            {   
                userControl.titleExample.Child = null;
                userControl.titleExample.Child = e.NewValue as UIElement;
            }
        }

        private static void DescriptionExampleOnComponentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var userControl = d as ExampleControl;
            if (userControl != null)
            {
                userControl.descriptionExample.Child = null;
                userControl.descriptionExample.Child = e.NewValue as UIElement;
            }
        }

        private static void InputsExampleOnComponentChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            var userControl = d as ExampleControl;
            if (userControl != null)
            {
                userControl.inputsExample.Children.Clear();
                userControl.inputsExample.Children.Add(e.NewValue as UIElement);
            }
        }
    }
}
