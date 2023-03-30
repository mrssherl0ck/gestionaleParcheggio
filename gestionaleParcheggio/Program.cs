using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace gestionaleParcheggio
{
    internal class Program
    {
        static void Main(string[] args)
        {
         //Strutte per contenere i dati
           List<Veicolo> parcheggio = new List<Veicolo>();

            while (true)
            {
                //Console.Clear();
                Console.WriteLine("1- Inserire Veicolo");
                Console.WriteLine("2- Stampa veicoli presenti");
                Console.WriteLine("3- Uscita Veicolo");
                Console.WriteLine("4- Tariffa Oraria 2 euro. Importo da pagare:");
                Console.WriteLine("\n9- Esci");

                string scelta = Console.ReadLine();



                if (scelta == "1")
                {
                    Console.WriteLine("Per favore inserire Targa Veicolo");
                    string targa = Console.ReadLine();
                    parcheggio.Add(new Veicolo(targa));

                }

                if (scelta == "2")
                {
                    foreach (Veicolo v in parcheggio)
                    {   
                        Console.WriteLine(v);
                    }
                }

                if (scelta == "3")
                {
                    Console.WriteLine("Per favore inserire Targa Veicolo");
                    string ricerca = Console.ReadLine();
                    foreach (Veicolo v in parcheggio)
                    {
                        parcheggio.RemoveAt(parcheggio.IndexOf(v));
                    }
                }
            }
        }
    }
}
