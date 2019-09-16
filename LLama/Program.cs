using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace LLama
{
    class Program
    {
        static List<LLamas> llama;

        static void Main(string[] args)
        {
            Beolv();
            F1();
            F3();
            F4();
            F5();
            F6();

            Console.ReadKey();
        }

        private static void F6()
        {
            var sw = new StreamWriter("stat.txt");

            var ee = new List<int>();
            var se = new List<int>();

            foreach (var t in llama)
            {
                if (t.iz == "sós")
                {
                    se.Add(t.kor);
                }
                else
                {
                    ee.Add(t.kor);
                }
            }

            sw.WriteLine("Édes ízt kedvelők átlagéletkora: {0:0.0}", ee.Average());
            sw.WriteLine("Sós ízt kedvelők átlagéletkora: {0:0.0}", se.Average());
            sw.Close();
        }

        private static void F5()
        {
            int szokoz = 0;

            foreach (var t in llama)
            {
                foreach (var c in t.nev)
                {
                    if (c == ' ')
                    {
                        szokoz++;
                    }
                }
            }

            Console.WriteLine("F5: Összesen {0} db szóköz van a lámák neveiben!", szokoz);
        }

        private static void F4()
        {
            int sosdb = 0;
            int edesdb = 0;

            foreach (var t in llama)
            {
                if (t.iz == "sós")
                {
                    sosdb++;
                }
                else if (t.iz == "édes")
                {
                    edesdb++;
                }
            }

            if (sosdb > edesdb)
            {
                Console.WriteLine("F4: A sós ízt kedvelő lámák vannak többen.");
            }
            else if (sosdb < edesdb)
            {
                Console.WriteLine("F4: Az édes ízt kedvelő lámák vannak többen.");
            }
            else
            {
                Console.WriteLine("F4: Ugyan annyi az ízék kedvelőinek száma.");
            }
        }

        private static void F3()
        {
            string neve = null;
            int ev = 0;

            foreach (var t in llama)
            {
                if (t.kor > ev)
                {
                    ev = t.kor;
                    neve = t.nev;
                }
            }

            Console.WriteLine("F3: A legöregebb {0}, ő {1} éves.", neve, ev);
        }

        private static void F1()
        {
            Console.WriteLine("F1: Összesen {0} láma van a listában.", llama.Count);
        }

        public static void Beolv()
        {
            llama = new List<LLamas>();

            var sr = new StreamReader(@"lama.txt", Encoding.UTF8);

            while (!sr.EndOfStream)

            {
                llama.Add(new LLamas(sr.ReadLine()));
            }

            sr.Close();
        }
    }
}
