using Campus02FirstSampleWPFAppFramework.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus02FirstSampleWPFAppFramework.ViewModels
{
    internal class FahrradViewModel //INotifyPropertyChanged
    {

        //ICommands
        private FahrraederRepository _rep = new FahrraederRepository();
        public FahrradViewModel()
        {
            MeineFahrraederFiltered = new ObservableCollection<Fahrrad>();
        }

        public Fahrrad AusgewF { get; set; }

        public ObservableCollection<Fahrrad> MeineFahrraeder { get; set; }

     

        public int AnzahlFahrraeder
        {
            get { return MeineFahrraeder.Count; }
            
        }

        public ObservableCollection<Fahrrad> MeineFahrraederFiltered { get; set; }

        public void ReadAll()
        {
            MeineFahrraeder= _rep.ReadAll();

        }
        public string Suchtext { get; set; }

        public void Suchen()
        {
            var fGefiltered=MeineFahrraeder.Where(f=>f.Bezeichnung.Contains(Suchtext));
            MeineFahrraederFiltered.Clear();
            foreach (var f in fGefiltered)
            {
                MeineFahrraederFiltered.Add(f);
            }
        }

        
    }
}
