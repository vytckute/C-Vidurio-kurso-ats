using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4uzd
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader skaityti = new StreamReader("duomenys.txt");
            string data = skaityti.ReadToEnd();
            skaityti.Close();
            string[] eilute = data.Split(';').ToArray();
            foreach (string eil in eilute)
            {
                string[] asmenys = eil.Split(' ').ToArray();
                try
                {
                    throw new Exception(asmenys[1]);
                }
                catch (Exception)
                {

                    if (Convert.ToInt32(asmenys[1]) < 16)
                    {
                        Console.WriteLine(asmenys[0] + " yra vaikas, nes amžius " + asmenys[1]);
                    }
                    else if (Convert.ToInt32(asmenys[1]) > 62)
                    {
                        Console.WriteLine(asmenys[0] + " yra senolis, nes amžius " + asmenys[1]);
                    }

                }


            }
            Console.ReadKey();
        }
    }

}
