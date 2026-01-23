using Campus02FirstSampleWPFAppFramework.Models;
using Campus02FirstSampleWPFAppFramework.ViewModels;
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
    /// Interaction logic for LVWindow.xaml
    /// </summary>
    public partial class LVWindow : Window
    {
        public LVWindow()
        {
            InitializeComponent();
            LVViewModel vm=new LVViewModel();
            //LV lv1 =new LV() { LVId=2,Bezeichnung="ISY",Stunden=4,Kategorie="Pflicht"};
            //vm.AddLV(lv1);
            vm.FillLVsFromDB();
            this.DataContext = vm;

        }
    }
}
