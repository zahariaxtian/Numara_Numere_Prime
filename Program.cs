using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {

        public static bool prim(int n)
        {
            for (int j = 2; j <= n/2; j++)
            {
                if (n%j == 0)
                return false; 
            }
            return true;
        }

        static void Main(string[] args)
        {
            int contor = 0;
            Console.Write("Introduceti numarul dorit:");
            int x = int.Parse(Console.ReadLine());
            if (x == 1 || x == 0)
            {
                Console.WriteLine("Acest numar nu este un numar prim! Va rugam sa introduceti un numar mai mare sau egal cu 2");
                Console.ReadLine();
            }
            else
            {
                for (int i = 2; i <= x; i++)
                {
                    if (prim(i) == true)
                    { contor++; }
                }

                Console.Write("Pentru numarul introdus de dumneavoastra exista {0} numere prime", contor);
                Console.ReadLine();
            }
            }
        }
    }
