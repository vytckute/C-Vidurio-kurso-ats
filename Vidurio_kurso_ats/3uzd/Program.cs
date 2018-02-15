using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3uzd
{
    public class Asmuo
    {
        public string vardas { get; set; }
        public string pavarde { get; set; }

        public Asmuo(string vardas, string pavarde)
        {
            this.vardas = vardas;
            this.pavarde = pavarde;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Asmuo> asmenys = new List<Asmuo>(); //sarasas (vardu ir pavardziu)
            Dictionary<Asmuo, int> telefonu_knyga = new Dictionary<Asmuo, int>(); //prie saraso pridedu telnr
                                                                                  //   Console.WriteLine("Kiek abonentu telefono knygoje?");
                                                                                  //  int n = Convert.ToInt32(Console.ReadLine());

            int n = 30;
            string[] vardai = { "Ona", "Jonas", "Petras", "Janina", "Saule", "Albertas", "Rokas", "Vilma", "Silvija" };
            string[] pavardes = { "Petr", "Rutk", "Petru", "Bunk", "Zvonk", "Jhon", "Simpson", "Luko", "Bela", "Romo" };
            int[] numeriai = { 253456, 65946, 456246, 456320, 3520325, 123056 };
            Random rng = new Random();
            for (int i = 0; i < n; i++)
            {
               Asmuo generate=new Asmuo(vardai[rng.Next(vardai.Count())], pavardes[rng.Next(pavardes.Count())] );
               if (!asmenys.Contains(generate))
                    asmenys.Add(generate);
             
            }
            foreach (var item in asmenys)
            {
                telefonu_knyga.Add(item, numeriai[rng.Next(numeriai.Count())]);
            }

            foreach (KeyValuePair<Asmuo, int> pair in telefonu_knyga)
            {
                Console.WriteLine("{0} {1}, {2}", pair.Key.vardas, pair.Key.pavarde, pair.Value);
            } 
                        Console.ReadKey();
        }
    }
}

