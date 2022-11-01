using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static int[] tab;
        static void insertion(int element)
        {
            int n = tab.Length;
            int i;
            for (i = n;  (i>0)&&(tab[i - 1]>element);i--)
            {
                tab[i - 1] = tab[i];
            }
            tab[i] = element;
            n++;
        }

        static void afficher()
        {
            int n = tab.Length;
            for (int i = 0; i < n; i++)
            {
                System.Console.Write(tab[i] + " ");
            }
            System.Console.WriteLine();
        }
        static void Main(string[] args)
        {
            int[] tb = { 23, 24, 26, 28 };
            tab = tb;
            insertion(25);
            afficher();
        }
    }
}
