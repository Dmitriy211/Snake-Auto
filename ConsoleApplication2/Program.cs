using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Timer
{
    class Program
    {
        public static void DoIt()
        {
            while (true)
            {
                Thread.Sleep(1000);
                Console.WriteLine("*");
            }
        }

        static void Main(string[] args)
        {
            Thread t = new Thread(new ThreadStart(DoIt));
            t.Start();
        }

       
    }
}