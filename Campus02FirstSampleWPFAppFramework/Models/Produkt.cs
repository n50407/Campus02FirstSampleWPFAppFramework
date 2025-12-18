using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus02FirstSampleWPFAppFramework.Models
{
    //PoCo // POJO
    public class Produkt
    {
        private int _produktId;
        public int ProduktId
        {
            get { return _produktId; }
            set { _produktId = value; }
        }

        public string ProduktName; //Nicht empfohlen
        public string Bezeichnung { get; set; }

        //public double Preis { get; set; } //automatic Property
        private double _Preis;

        public double Preis
        {
            get { return _Preis; }
            set { _Preis = value; }//ChangeNotification
        }


        public string Farbe { get; set; }
        public int Anzahl { get; set; }

        public List<string> Eigenschaften { get; set; }


    }
}
