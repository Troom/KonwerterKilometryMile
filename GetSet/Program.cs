using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KMMILES
{
    public class Way
    {

        public void Start()
        { Console.WriteLine("Co program powinien wykonac?\n1- Konwersja kilometrow na mile\n2- Konwersja mil na kilometry");
            int choice = int.Parse(Console.ReadLine());
            EnterNumber(choice);
            int amount = int.Parse(Console.ReadLine());
            Choice(choice,amount);
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
                throw new ArgumentException();
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
        }
    }
	
    public class MainClass
    {
        public static void Main()
        {
            Way droga = new Way();
            droga.Start();
        }
    }

}