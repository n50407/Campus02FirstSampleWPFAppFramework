using System;
using System.Collections.Generic;
using System.Linq;
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
            MyLogikV2 obj2 = obj as MyLogikV2;
            obj2.SayGoodBye();
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

        public void PrintBewertung()
        {
            int bewertung = 12;
            Console.WriteLine("Die Bewertung ist " + bewertung);
        }
    }
}
