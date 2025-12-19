using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Campus02FirstSampleWPFAppFramework.Models
{
    internal class Person : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public int Id { get; set; } //Auto-implemented property for Id

		private string _Vorname;

		public string Vorname
		{
			get { return _Vorname; }
			set { _Vorname = value; }
		}

		private int _Stimmungsparameter;

		public int Stimmungsparameter
		{
			get { return _Stimmungsparameter; }
			set { 
				_Stimmungsparameter = value;
				if (PropertyChanged != null)
				{
					//GUI ruft getter von Stimmungsfarbe auf
                    PropertyChanged(this, new PropertyChangedEventArgs("Stimmungsfarbe"));
                    PropertyChanged(this, new PropertyChangedEventArgs("Stimmungsparameter"));
                }
            }
		}

        string farbe = "Yellow";
        public string Stimmungsfarbe
		{
			
			get {
				switch(Stimmungsparameter)
				{
					case 0: farbe = "black";
						break;
					case 1: farbe = "darkblue";
						break;

					case 4: farbe = "Blue";
						break;
                    case 6:
                        farbe = "Yellow";
                        break;
                    case 10:farbe = "Pink";
						break;
				}
				
				
				return farbe; 
			}
			
		}

		private bool _IstUrlaubsreif;

		public bool IstUrlaubsreif
        {
			get { return _IstUrlaubsreif; }
			set { 
				
				_IstUrlaubsreif = value;
                if (PropertyChanged != null)
                {
                    //GUI ruft getter von Stimmungsfarbe auf
                    PropertyChanged(this, new PropertyChangedEventArgs("Bild"));
                }

            }
		}
	

		public string Bild
		{
			get {
				if (IstUrlaubsreif == true)
					return "Unhappy.jpg";
				else
					return "Happy.jpg";
				
			
			}
			
		}





	}
}
