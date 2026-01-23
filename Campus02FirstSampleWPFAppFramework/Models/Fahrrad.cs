using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus02FirstSampleWPFAppFramework.Models
{
    public class Fahrrad
    {
        public int FahrradId { get; set; }
        public string Bezeichnung { get; set; }
        public string Abbildung { get; set; }
        public string Kategorie { get; set; } //Moutainbike, Straßenbike, Citybike, Rennrad
    }
}
