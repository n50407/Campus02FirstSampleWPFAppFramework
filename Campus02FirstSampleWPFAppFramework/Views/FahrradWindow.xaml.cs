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
    /// Interaction logic for FahrradWindow.xaml
    /// </summary>
    public partial class FahrradWindow : Window
    {
        public FahrradWindow()
        {
            InitializeComponent();
            FahrraederRepository rep = new FahrraederRepository();

            /*
            rep.AddFahrrad(new Fahrrad()
            {
                Bezeichnung = "Scotty",
                FahrradId = 1,
                Kategorie = "Fully Mountainbike",
                Abbildung = "Scotty.jpg",
            });
            rep.AddFahrrad(
            new Fahrrad()
            {
                Bezeichnung = "Emilia",
                FahrradId = 2,
                Kategorie = "City Bike",
                Abbildung = "City.jpg",
            }
            );
            */
            /*
            rep.ReadAll();
            rep.AusgewF = rep.MeineFahrraeder[0];
            this.DataContext = rep;

            var v1 = rep.MeineFahrraeder.
                Where(f => f.Bezeichnung.Contains("e")).
                OrderBy(f => f.Abbildung).
                ToList();

            //"select x from meineKunden"
            //LINQ
            var v2 = from fx in rep.MeineFahrraeder
                     where fx.Bezeichnung.Contains("e")
                     orderby fx.Kategorie
                     select fx; //select * 

            */

            FahrradViewModel viewModel = new FahrradViewModel();
            viewModel.ReadAll();
            this.DataContext = viewModel;



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

        private void Dummy_Click(object sender, RoutedEventArgs e)
        {
          
        }

        private void Suchen_Click(object sender, RoutedEventArgs e)
        {
            FahrradViewModel viewModel = this.DataContext as FahrradViewModel;
            viewModel.Suchen();

        }
    }
}
