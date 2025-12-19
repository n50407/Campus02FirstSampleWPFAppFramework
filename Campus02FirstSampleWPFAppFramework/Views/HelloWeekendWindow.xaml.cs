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

namespace Campus02FirstSampleWPFAppFramework.Views
{
    /// <summary>
    /// Interaction logic for HelloWeekendWindow.xaml
    /// </summary>
    public partial class HelloWeekendWindow : Window
    {
        public HelloWeekendWindow()
        {
            InitializeComponent();

            RadioButton myRadioButton =new RadioButton();
            myRadioButton.Content = "Hello Weekend!";
            SolidColorBrush brush = new SolidColorBrush(Colors.Red);

            myRadioButton.Background = brush;
            MyTopStackPanelFreitag.Children.Add(myRadioButton);
        }
    }
}
