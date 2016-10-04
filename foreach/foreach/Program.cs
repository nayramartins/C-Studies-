using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Nayra", "Aline", "River", "Finn" };

            //foreach (string name in names)
            //{
            //    Console.WriteLine(name);
            //}

            //Console.ReadLine();

            string zig = "String reverse test";

            char[] charArray = zig.ToCharArray();
            Array.Reverse(charArray);

            foreach (char zigChar in charArray )
            {
                Console.Write(zigChar);
            }
            Console.ReadLine();
        }
    }
}
