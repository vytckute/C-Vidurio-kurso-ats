using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1uzd
{
    class Mokykla
    {
        public int Klases_sk;
        public char Klases_raid;
        public int Mokiniu_sk;
        public int Mokslo_metu_pradzia;

        public Mokykla(int klases_sk, char klases_raid, int mokiniu_sk, int mokslo_metu_pradzia)
        {
            this.Klases_sk = klases_sk;
            this.Klases_raid = klases_raid;
            this.Mokiniu_sk = mokiniu_sk;
            this.Mokslo_metu_pradzia = mokslo_metu_pradzia;
        }

        public static int kiek_metu_mokosi()
        {

            StreamReader skaityti = new StreamReader("duomenys.txt");
            string data = skaityti.ReadToEnd();
            skaityti.Close();
            int metumokos = 0;
            string[] eilute = data.Split(';').ToArray();

            foreach (string eil in eilute)
            {

                string[] temporary = eil.Split(' ').ToArray();

                int metai = 2018 - Convert.ToInt32(temporary[3]);
                metumokos += metai;
            }
            Console.WriteLine("Išviso mokosi mokiniai: " + metumokos+" m.");
            Console.ReadKey();
            return metumokos;
        }
    }
}


