using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulatorwalut
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int poczatek = 1;
            int koniec = 48;

            int[] liczby = new int [6];
            
            for (int i=0; i < liczby.Length; i++)
            {
                int losowana = rnd.Next(poczatek, koniec);
                liczby[i] = losowana;
                Console.WriteLine(liczby[i]);
            }

            
            

            

            //int waga = 5;
            //string imie = "kotel";
            //Console.Write("Kot nazywa sie: {0} waga kota to: {1}",waga,imie);
            Console.ReadKey();
        }
    }
}
