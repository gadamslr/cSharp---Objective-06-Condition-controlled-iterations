using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cSharp___Objective_06_Condition_controlled_iterations
{
    internal class Program
    {
        static int D2(string Y)
        {
            int Z = Convert.ToInt32(Y);
            int Count = 0;
            while (Z > 1)
            {
                Z = Z / 2;
                Count++;
            }
            return Count;
        }
        static void Main(string[] args)
        {
            string X = "8";
            Console.WriteLine(D2(X));
            Console.ReadLine();
        }
    }
}
