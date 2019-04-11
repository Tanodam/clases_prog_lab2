using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio27
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> numeros = new Queue<int>();

            Random rnd = new Random();
            for (int i=0; i<20;i++)
            {
                numeros.Enqueue(rnd.Next(-100, 100));
            }
            List<int> numuero = new List<int>();
            List<int> numueroPos = new List<int>();
            List<int> numueroNeg = new List<int>();
            numuero = numeros.ToList();
            foreach (int num in numuero)
            {
                Console.WriteLine(num);
                if(num >=0)
                {
                    numueroPos.Add(num);
                }
                else
                {
                    numueroNeg.Add(num);
                }

            }
            Console.ReadKey();
            Console.Clear();
            numueroPos.Sort();
            numueroPos.Reverse();
            numueroNeg.Sort();
            foreach (int num in numueroPos)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();
            Console.Clear();
            foreach (int num in numueroNeg)
            {
                Console.WriteLine(num);
            }
            Console.ReadKey();

        }
    }
}
