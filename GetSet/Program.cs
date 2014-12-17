using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMMILES
{
    public class Way
    {

        private float km;
        public float Km
        {
            get { return km; }
            set { km = value; }
        }

        private float mil;
        public float Mil
        {
            get { return Km * 1.432f ; }
            set { mil = value; }
        }

        private int value1;

        public int Value1
        {
            get { return value1; }
            set {
                if (value==1 || value==2)
                {
                    value1 = value;   
                }
                else
                {
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("Podaj ktore zadanie ma wykonac program\n1 mile\n2 kilometry");
                        Value1 = int.Parse(Console.ReadLine());
                    } 
                    while (Value1== 1 & Value1 == 2);
                        value1 = Value1;
                }
                
            }
        }

        private int value2;
        public int Value2
        {
            get {return value2;}
            set {
                if (value>0)
                { Console.WriteLine("value<0"); value2 = value; }  
                else if(value<0)
                {
                    do
                  {
                      Console.WriteLine("Podaj liczbe powyzej zera");
                      Value2 = int.Parse(Console.ReadLine());
                  } 
                    while (Value2 <0);
                }
                value2 = Value2; }
        }
       

        public void Start()
        { Console.WriteLine("Co program powinien wykonac?\n\n1- Konwersja kilometrow na mile.\n2- Konwersja mil na kilometry.");
            Value1 = int.Parse(Console.ReadLine());
            EnterNumber(value1);
            Value2 = int.Parse(Console.ReadLine());    
            Choice(value1,value2);
        }

        public void EnterNumber(int choice)
        {
            if (choice == 1)
            {
                Console.WriteLine("Podaj liczbe kilometrow");
            }
            else if (choice == 2)
            {
                Console.WriteLine("Podaj liczbe mil");
            }
            else
            {
                Console.WriteLine("BLAD MISIU");
                //throw new ArgumentException();
            }
        }

        public void Choice(int value, int amount)
        {
            if (value==1)
            {
                ConvertMile(amount);
            }
            if (value==2)
            {
                ConvertKilometers(amount);
            }
        }

        void ConvertKilometers(int value)
        {
            float kilometers = 0.621f;
            if (value == 1)
            {
                Console.WriteLine("{0} mila to {1} kilometra", value, value * kilometers);
            }
            else if (value > 1 & value < 5)
            {
                Console.WriteLine("{0} mile to {1} kilometrow", value, value * kilometers);
            }
            else if (value > 4)
            {
                Console.WriteLine("{0} mil to {1} kilometrow", value, value * kilometers);
            }
            else
            {
                Console.WriteLine("error");
            }
        }

        void ConvertMile(int value)
        {
            float miles = 1.609344f;
            if (value == 1)
            {
                Console.WriteLine("{0} kilometr to {1} mil", value, value * miles);
            }
            else if (value > 1 & value < 5)
            {
                Console.WriteLine("{0} kilometry to {1} mil", value, value * miles);
            }
            else if (value > 4)
            {
            Console.WriteLine("{0} kilometrow to {1} mil", value, value * miles);
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
	
    public class MainClass
    {
        public static void Main()
        {
            Way droga = new Way();
            droga.Start();
            droga.Km=10;
            //Console.WriteLine(droga.Mil);    
        }
    }

}

//no nieźle Ci poszło mimo iż do programowania obiektowego trochę brakuje:)
//Ważne jest przedewszystkim byś oddzielił warstwę prezentacyjną ( tutaj Console.WriteLine) od logiki (przeliczenia)
//Spróbuj teraz to przerobić tak, aby ten kod zadziałał: (użyj właśiwości/properties)

//var droga = new Way();
//droga.Km = 15;
//Console.WriteLine(droga.Mil);