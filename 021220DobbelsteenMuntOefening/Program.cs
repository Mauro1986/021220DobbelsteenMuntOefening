using _021220DobbelsteenMuntOefening.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _021220DobbelsteenMuntOefening
{
    public class Program
    {
        private const int AANTAL = 10;

        public static void Main(String[] args)
        {
            RandomElement[] elements = { new Dobbelsteen(), new Munt() };
            // genereer 10 dobbelsteenworpen
            for (int i = 0; i < AANTAL; i++)
            {
                Console.WriteLine(elements[0].Gooi());
            }
            // genereer 10 muntworpen, druk in plaats van 0 en 1 kop of munt af.
            
            for (int i = 0; i < AANTAL; i++)
            {
                if (elements[1].Gooi() == 0)
                {
                    Console.WriteLine("munt");
                }
                else
                {
                    Console.WriteLine("kop");
                }
            }
        }
    }
}
