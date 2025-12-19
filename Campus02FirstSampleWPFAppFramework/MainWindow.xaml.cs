using Campus02FirstSampleWPFAppFramework.Models;
using Campus02FirstSampleWPFAppFramework.Views;
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

namespace Campus02FirstSampleWPFAppFramework
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            //UserCode
            MessageBox.Show(GetHelloMessage());
            Produkt pNeu = new Produkt();
            pNeu.ProduktId = 42; //setProductId(42) -->Set
            pNeu.ProduktName = "Kaugummi";
            pNeu.Bezeichnung = "Echt frischer Kaugummi";
            pNeu.Preis = 1.99;
            pNeu.Farbe = "Green";
            pNeu.Eigenschaften = new List<string>() { "Frisch", "Klein", "Lecker" };

            this.DataContext= pNeu;
        }

        private void BeimOeffnenClick(object sender, RoutedEventArgs e)
        {
            LayoutSample meinFenster =new LayoutSample();
            meinFenster.DataContext = this.DataContext;
            meinFenster.ShowDialog();
        }
            private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            HelloWeekendWindow meinFenster = new HelloWeekendWindow();
            meinFenster.ShowDialog();
        }
        private void Person_Click(object sender, RoutedEventArgs e)
        {
            PersonView meinFenster = new PersonView();
            meinFenster.ShowDialog();
        }
    }
}
