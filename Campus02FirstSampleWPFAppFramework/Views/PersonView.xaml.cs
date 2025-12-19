using Campus02FirstSampleWPFAppFramework.Models;
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
    /// Interaction logic for PersonView.xaml
    /// </summary>
    public partial class PersonView : Window
    {
        public PersonView()
        {
            InitializeComponent();
            Person p = new Person();
            p.Id = 1;
            p.Vorname = "Johann";
            p.Stimmungsparameter= 5;
            p.IstUrlaubsreif= true; 
            this.DataContext = p;


        }
    }
}
