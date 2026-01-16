using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDelegatesEvents
{
    public interface IMyLogik
    {
        void MyFunction();
    }

    public class MyLogikV1 : IMyLogik
    {
        public void MyFunction()
        {
            Console.WriteLine("Logik 1");
        }
    }
    public class MyLogikV2 : IMyLogik
    {
        public void MyFunction()
        {
            Console.WriteLine("Logik 2");
        }

        public void SayHello()
        {
            Console.WriteLine("Logik 2");
        }

        public void SayGoodBye()
        {
            Console.WriteLine("Logik 2");
        }
    }
 
    public class Program
    {
        public static void DoSomethingMitLogikV1(IMyLogik obj)
        {
            //ständigen Änderungen vermeiden
            obj.MyFunction();
            //Cast eher vermeiden
           // MyLogikV2 obj2 = obj as MyLogikV2;
            //obj2.SayGoodBye();
            
        }

        public static void DoSomethingMitLogikV2(MyVoidLogikDelegate f)
        {
            //ständigen Änderungen vermeiden
            f();
        }
     

        static void Main(string[] args)
        {
            MyVoidLogikDelegate del1 = new MyVoidLogikDelegate(new MyLogikV1().MyFunction);
            MyLogikV2 myLogikV2 = new MyLogikV2();
            MyVoidLogikDelegate del2 = myLogikV2.MyFunction;
            DoSomethingMitLogikV2(del1);



            //Delegates, Lambda Expressions, Events, Interfaces
            int i = 12;
            System.Int32 ii = 20;

            Nullable<int> iii = null;
            int? iv = null;

            object o = i; //boxing




            DoSomethingMitLogikV1(new MyLogikV1()); 
            DoSomethingMitLogikV1(new MyLogikV2());

            Produkt p1 =new Produkt() { Preis=150, Bezeichnung="Sicheres Produkt", Stars=5, Sicherheitsstandard=true };
            // p1.PrintBewertung(myLogik1);
            //p1.PrintBewertung(myLogik2);
            var ergSub = Calc(20, 40, Sub);
            var ergSum = Calc(20, 40, Sum);
            var ergSumMitLambda = Calc(20, 40, (a,b)=>{ return a + b; });
            var ergDivMitLambda = Calc(20, 40, (a, b) => { return a / b; });
            var ergOarg = Calc(20, 40, (a, b) => { return Math.PI * a + b; });


        }
        public static double Sub(double x, double y)
        {
            return x - y;
        }
        public static double Sum(double x, double y)
        {
            return x + y;
        }
        public static double Calc(double z1, double z2,
            Func<double,double,double> myFunction)
        {
            return myFunction(z1, z2);
        }

        delegate void Del19(int x);
        void M1MitIntundVoid(Del19 d)
        {

        }
        delegate void Del7(string str, int j);
        void M2StringIntundVoid(Del7 d)
        {
            d("Hallo", 19);
        }
        void M2StringIntundVoid(Action<string,int> d)
        {
            d("Hallo", 19);
        }
        public void StringUndVoid(string s, int i)
        {

        }
        delegate int Del23(bool trueFalse);
        void M3MitBooleanundRetunrsint(Del23 d)
        {

        }
        void M3MitBooleanundRetunrsint(Func<bool,int> d)
        {
            int erg = d(true);
        }


        public int BooleanReturnsInt(bool b)
        {
            return 12;
        }

    }
    public delegate void MyVoidLogikDelegate();
    
    //class MyVoidLogikClass{
    // Invoke
    //
    public class Produkt
    {
        public string Bezeichnung { get; set; }
        public double Preis { get; set; }
        public int Stars { get; set; }
        public bool Sicherheitsstandard { get; set; }

        /*
        public void PrintBewertung("Logik" Interface / Delegate)
        {
            //Pause bis 10:20 Uhr, danach gemeinsame Auflösung
            int bewertung = 12; //12 soll von übergebenen Logik Delegate / Interface kommen
            //bewertung = BitteBewerten(this); --liefert zwischen 0 und 100
            Console.WriteLine("Die Bewertung ist " + bewertung);
            //V1 Preis > 100 && Stars <10 ---> 17
            //V2 Sicherheit ==true && Bezeichnung.Contains("Sicher") --> 20
            //V3 Preis <50 --> 50
        }
        */
    }
}
