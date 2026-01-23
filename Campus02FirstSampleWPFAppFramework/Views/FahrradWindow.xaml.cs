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
    /// Interaction logic for FahrradWindow.xaml
    /// </summary>
    public partial class FahrradWindow : Window
    {
        public FahrradWindow()
        {
            InitializeComponent();
            FahrraederRepository rep = new FahrraederRepository();
            
            rep.MeineFahrraeder.Add(new Fahrrad()
            {
                Bezeichnung = "Scotty",
                FahrradId = 1,
                Kategorie = "Fully Mountainbike",
                Abbildung = "Scotty.jpg",
            });
            rep.MeineFahrraeder.Add(
            new Fahrrad()
            {
                Bezeichnung = "Emilia",
                FahrradId = 2,
                Kategorie = "City Bike",
                Abbildung = "City.jpg",
            }
            );
            rep.AusgewF = rep.MeineFahrraeder[0];
            this.DataContext = rep;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            FahrraederRepository rep = this.DataContext as FahrraederRepository;
            Fahrrad f = new Fahrrad()
            {
                Bezeichnung=rep.NeueBezeichnung,
                Kategorie=rep.NeueKategorie
            };
            rep.AddFahrrad(f);
        }
    }
}
