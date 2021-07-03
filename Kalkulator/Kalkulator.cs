using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    class Kalkulator
    {

        public static double PodajPierwszaLiczbe ()
        {
            string sLiczba;
            double nLiczba = 0;
            bool czyLiczba = false;
            do
            {
                Console.Write("Podaj pierwszą liczbę: ");
                sLiczba = Console.ReadLine();
                if (double.TryParse(sLiczba, out nLiczba) )
                {
                    Console.WriteLine("Pierwsza liczba: {0}", nLiczba);
                    czyLiczba = true;
                }
                else
                {
                    Console.WriteLine("Podana wartość: {0} nie jest liczbą.", sLiczba);
                }
            } while (!(czyLiczba));
            return nLiczba;
        }
        public static double PodajDrugaLiczbe (string sOperator)
        {
            string sLiczba;
            double nLiczba = 0;
            bool czyLiczba = false;
            do
            {
                Console.Write("Podaj drugą liczbę: ");
                sLiczba = Console.ReadLine();
                if (double.TryParse(sLiczba, out nLiczba) )
                {
                    if (sOperator == "/" && nLiczba == 0)
                    {
                        Console.WriteLine("Nie można dzielić przez 0.");
                    }
                    else
                    {
                        Console.WriteLine("Druga liczba: {0}", nLiczba);
                        czyLiczba = true;
                    }
                }
                else
                {
                    Console.WriteLine("Podana wartość: {0} nie jest liczbą.", sLiczba);
                }
            } while (!(czyLiczba));
            return nLiczba;
        }
        
        public static string PodajOperator()
        {
            string sOperator;
            bool okOperator = false;
            do
            {
                Console.Write("Podaj operator (+, -, *, /): ");
                sOperator = Console.ReadLine();
                switch (sOperator)
                {
                    case "+":
                        Console.WriteLine("Wybrano dodawanie");
                        okOperator = true;
                        break;
                    case "-":
                        Console.WriteLine("Wybrano odejmowanie");
                        okOperator = true;
                        break;
                    case "*":
                        Console.WriteLine("Wybrano mnożenie");
                        okOperator = true;
                        break;
                    case "/":
                        Console.WriteLine("Wybrano dzielenie");
                        okOperator = true;
                        break;
                    default:
                        Console.WriteLine("To nie jest prawidłowy operator");
                        break;
                }
            } while (!(okOperator));
            return sOperator;
        }

        public static void WynikDzialaniaKalkulatora(double nLiczba1, double nLiczba2, string sOperator)
        {
            double wynik = 0;
            switch (sOperator)
            {
                case "+":
                    wynik = nLiczba1 + nLiczba2;
                    break;
                case "-":
                    wynik = nLiczba1 - nLiczba2;
                    break;
                case "*":
                    wynik = nLiczba1 * nLiczba2;
                    break;
                case "/":
                    wynik = nLiczba1 / nLiczba2;
                    break;
            }
            Console.WriteLine("Wynik działania:");
            Console.WriteLine("{0} {1} {2} = {3,1:0.00}", nLiczba1, sOperator, nLiczba2, wynik);
        }
    }
}
