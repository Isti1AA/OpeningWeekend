using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace OpeningWeekend
{
    class Program
    {

        class adat
        {
            public string eredetiCim;
            public string magyarCim;
            public string bemutato;
            public string forgalmazo;
            public int bevetel;
            public int latogato;


            public adat(string sor)
            {
                string[] d = sor.Split(';');
                string eredetiCim = d[0];
                string magyarCim = d[1];
                string bemutato = d[2];
                string forgalmazo = d[3];
                int bevetel = int.Parse(d[4]);
                int latogato = int.Parse(d[5]);
            }
        }
        static void Main(string[] args)
        {



            List<adat> adatok = new List<adat>();
            foreach (var sor in File.ReadAllLines("nyitohetvege.txt").Skip(1))

            {
                adatok.Add(new adat(sor));
            }


            

            
            foreach (var adat in adatok)
            {
                if (adat.eredetiCim == "Allied")
                {

                    Console.WriteLine("teszt");
                    
                }
            }

          Console.WriteLine($"Az állományban lévő filmek száma : {adatok.Count}");
            Console.ReadKey();

        }





    }
}

