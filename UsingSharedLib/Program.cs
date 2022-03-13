using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PGDAC_SharedDll;

namespace UsingSharedLib
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SharedLib sharedLib = new SharedLib();
            sharedLib.Display();
            sharedLib.Show();
            Calculator obj = new Calculator();
            Console.WriteLine(obj.Add(30, 30, 30));
            Console.WriteLine(obj.Multiply(40, 5, 4));
        }
    }
}
