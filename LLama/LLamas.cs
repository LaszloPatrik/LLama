using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLama
{
    class LLamas
    {
        
        public string nev;
        public int ev;
        public string iz;

        public LLamas(string sor)
        {
            var t = sor.Split(';');

            this.nev = t[0];
            this.ev = int.Parse(t[1]);
            this.iz = t[2];
        }

        public int kor => DateTime.Now.Year - this.ev;
    }
}
