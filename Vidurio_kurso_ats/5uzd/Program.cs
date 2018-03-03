using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _5uzd
{
    class imone
    {
        public string pavadinimas { get; set; }
        public string adresas { get; set; }
        public int biudzetas { get; set; }
        public imone(string pavadinimas, string adresas, int biudzetas)
        {
            this.pavadinimas = pavadinimas;
            this.adresas = adresas;
            this.biudzetas = biudzetas;
        }

    }
    class Program
    {
        public delegate bool IsChecher(int pinigai);

        static bool Tusinukai(int pinigai)
        {
            if (pinigai < 1000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool zenkliukai(int pinigai)
        {
            if (pinigai >= 1000 && pinigai <= 5000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static bool puodukai(int pinigai)
        {
            if (pinigai > 5000)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        static void Main(string[] args)
        {
            StreamReader skaityti = new StreamReader("duomenys.txt");
            string data = skaityti.ReadToEnd();
            skaityti.Close();

            string[] eilute = data.Split(';').ToArray();
            int m = 0;
            List<imone> imoness = new List<imone>();
            foreach (string eil in eilute)
            {
                List<string> temporary = eil.Split(',').ToList();
                string pavadinimas = temporary[0];
                string adresas = temporary[2];
                int biudzetas = Convert.ToInt32(temporary[1]);
                imone im = new imone(pavadinimas, adresas, biudzetas);
                imoness.Add(im);
            }
            IsChecher check = Tusinukai;
            IsChecher check2 = zenkliukai;
            IsChecher check3 = puodukai;
            foreach (imone im in imoness)
            {
                if (check(im.biudzetas))
                {
                    Console.WriteLine("Imonei " + im.adresas + " siunčiamas tušinukas");
                }

                else if (check2(im.biudzetas))
                {
                    Console.WriteLine("Imonei " + im.adresas + " siunčimas ženkliukas");
                }

                else if (check3(im.biudzetas))
                {
                    Console.WriteLine("Imonei " + im.adresas + " siunčiamas puodukas");
                }
            }
            Console.ReadKey();
        }
    }
}

