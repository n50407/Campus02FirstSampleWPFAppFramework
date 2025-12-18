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
using System.Windows.Shapes;

namespace Campus02FirstSampleWPFAppFramework
{
    /// <summary>
    /// Interaction logic for LayoutSample.xaml
    /// </summary>
    public partial class LayoutSample : Window
    {
        public LayoutSample()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Button button = sender as Button;
            (button.Parent as StackPanel).Children.Add(new TextBox() { Text="Hello per Click"});
        }
    }
}
