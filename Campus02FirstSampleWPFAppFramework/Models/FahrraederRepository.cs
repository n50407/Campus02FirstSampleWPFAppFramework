using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus02FirstSampleWPFAppFramework.Models
{
    public class FahrraederRepository: INotifyPropertyChanged
    {
        public ObservableCollection<Fahrrad> MeineFahrraeder { get; set; }
        public FahrraederRepository()
        {
                MeineFahrraeder = new ObservableCollection<Fahrrad>();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void AddFahrrad(Fahrrad fahrrad)
        {
            MeineFahrraeder.Add(fahrrad);
            HelperPropertyChange("AnzahlFahrraeder");
        }
        public void RemoveFahrrad(int id)
        {
            var fahrradToRemove = MeineFahrraeder.Where(f => f.FahrradId == id).FirstOrDefault();
            MeineFahrraeder.Remove(fahrradToRemove);
            HelperPropertyChange("AnzahlFahrraeder");
        }

        public void HelperPropertyChange(string properName)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this,new PropertyChangedEventArgs(properName));
            }
        }

        public string AnzahlFahrraeder
        {
            get
            {
                return $"Sie haben derzeit {MeineFahrraeder.Count} Fahrraeder";
            }
        }

        private Fahrrad _AusgewF;

        public Fahrrad AusgewF
        {
            get { return _AusgewF; 
            }
            set { 
                _AusgewF = value;
                HelperPropertyChange("AusgewF");
            }
        }

        public string NeueBezeichnung{ get; set; }
        public string NeueKategorie { get; set; }

    }

    
}
       
