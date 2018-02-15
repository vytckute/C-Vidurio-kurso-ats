using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2uzd
{
    public interface IGyvunas
    {
         string vardas { get; set; }
        string rusis { get; set; }
        string apibudinas();
    }

    class Suo : IGyvunas
    {
       public string vardas { get; set; }
        public string rusis { get; set; }
       public string apibudinas()
        {
            string tekstas= "Šuo – pirmasis gyvūnas, kurį prijaukino žmogus. Šuo tai vienas iš labiausiai paplitusių namų ūkyje laikomų gyvūnų žmonijos istorijoje. Prijaukintas šuo buvo naudingas ne tik žmogui.";
            string tekstas2 = vardas + " " + rusis + " " + " " + tekstas;
            return tekstas2;
        }
        public Suo(string vardas, string rusis) //konstruktorius 
        {
            this.vardas = vardas;
            this.rusis = rusis;
        }
    }
    class Kate : IGyvunas
    {
        public string vardas { get; set; }
        public string rusis { get; set; }
        public string apibudinas()
        {
            string tekstas = "Gyvuliukas, laikomas pelėms, žiurkėms naikinti: Be katės neapsiginsi nuo pelių. Katė murkia.";
            string tekstas2 = vardas + " "+rusis+" "+" "+tekstas;
            return tekstas2;
        }
        public Kate(string vardas, string rusis)
        {
            this.vardas = vardas;
            this.rusis = rusis;
        }
    }

    class Karve : IGyvunas
    {
        public string vardas { get; set; }
        public string rusis { get; set; }
        public string apibudinas()
        {
            string tekstas = "Stambus raguotas gyvulys, laikomas pienui ir mėsai.";
            string tekstas2 = vardas + " " + rusis + " " + " " + tekstas;
            return tekstas2;
      }
        public Karve(string vardas, string rusis)
        {
            this.vardas = vardas;
            this.rusis = rusis;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Kate k = new Kate("Smele","Žinduolys");
            Console.WriteLine(k.apibudinas());
            Suo s = new Suo("Salsa", "Zinduolis");
            Console.WriteLine(s.apibudinas());
            Karve kr = new Karve("Marge", "Zinduolis");
            Console.WriteLine(kr.apibudinas());
            Console.ReadKey();

        }
    }
}
