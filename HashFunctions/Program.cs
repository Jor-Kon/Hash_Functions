using System;
using System.IO;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace HashFunctions
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = new Stopwatch();

            string input = File.ReadAllText(@"C:\Users\JordanK\source\repos\HashFunctions\Hash_Functions\input.txt");

            sw.Start();
            Hash.MD5(input);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            sw.Start();
            Hash.SHA1(input);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            sw.Start();
            Hash.SHA2(input);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);

            sw.Start();
            Hash.SHA3(input);
            sw.Stop();
            Console.WriteLine(sw.ElapsedMilliseconds);
        }
    }
}
