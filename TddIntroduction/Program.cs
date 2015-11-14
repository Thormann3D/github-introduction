using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TddIntroduction.Tests;

namespace TddIntroduction
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            while (i <= 99) {
                i++;
                FizzBuzz fb = new FizzBuzz();
                fb.Query(i);
                Console.WriteLine(fb.Query(i));
            }
            Console.ReadLine();
        }
    }
}
