using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace szuneti_hf
{
    class Program
    {
        static int[] Veletlen_szamok()
        {
            const int MAXN = 5;
            int[] szamok = new int[MAXN];
            Random r = new Random();
            for (int i = 0; i < szamok.Length; i++)
            {
                szamok[i] = r.Next(1, 11);
            }
            return szamok;
        }
        static void Kiir(int[] v_sz)
        {
            Console.Write("A tömb elemei: ");
            for (int i = 0; i < v_sz.Length; i++)
            {
                Console.Write($"{v_sz[i]} ");
            }
        }
        static void Main(string[] args)
        {
            /*
             Generálj véletlen számokból álló tömböt!
             Döntsd el van-e benne páros szám.
             */
            int[] veletlen_szamok = Veletlen_szamok();

            Kiir(veletlen_szamok);

            Console.ReadKey();
        }
    }
}
