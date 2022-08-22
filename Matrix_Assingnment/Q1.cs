using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix_Assingnment
{
    internal class Q1
    {
        public static void Main()
        {
            double principle = 1000 ,Amount=100000;
            double  time;
            // Calculate compound interest

            time = Math.Log(Amount /principle) /   Math.Log(1+(0.05));

            Console.Write("The time taken is " + time);
            Console.ReadLine();
        }
    }
}
