using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulator
{
    /// <summary>
    /// - Przyjmujemy z konsoli od użytkownika pierwszą wartość wyrażenia (jako liczba zmiennoprzecinkowa)
    /// - Przyjmujemy z konsoli od użytkownika rodzaj operacji w postaci znaku + , - , * lub /
    /// - Przyjmujemy z konsoli od użytkownika drugą wartość wyrażenia(jako liczba zmiennoprzecinkowa)
    /// - Wyświetlamy wynik
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            double nLiczba1;
            double nLiczba2;
            string sOperator;
            string ponownie = "t";

            while (ponownie.ToLower() == "t" || ponownie.ToLower() == "tak")
            {
                nLiczba1 = Kalkulator.PodajPierwszaLiczbe();
                sOperator = Kalkulator.PodajOperator();
                nLiczba2 = Kalkulator.PodajDrugaLiczbe(sOperator);
                Kalkulator.WynikDzialaniaKalkulatora(nLiczba1, nLiczba2, sOperator);

                Console.WriteLine("");
                Console.WriteLine("Czy chcesz liczyć ponownie (T): ");
                ponownie = Console.ReadLine();
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }

}
