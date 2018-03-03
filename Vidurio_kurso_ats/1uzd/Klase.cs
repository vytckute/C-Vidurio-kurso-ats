using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1uzd
{
    class Klase:Mokykla
    {
       
        public List<string> Vardai { get; set; }
        public  int[] Vidurkiai { get; set; }
        public Klase(int klases_sk, char klases_raid, int mokiniu_sk, int mokslo_metu_pradzia, List<string>vardai, int[]vidurkiai) : base(klases_sk, klases_raid, mokiniu_sk, mokslo_metu_pradzia)
        {
            Vardai = vardai;
            Vidurkiai = vidurkiai;
        }

    }
}
