using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadacha3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            List<int> mass = new List<int>();
            for (int i =0;i<n;++i)
            {
                mass.Add(Convert.ToInt32(Console.ReadLine()));
            }
            mass.Sort();
            foreach(var t in mass)
            {
                Console.WriteLine(t);
            }
            Console.ReadKey();
        }
    }
}
