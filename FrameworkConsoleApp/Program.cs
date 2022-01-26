using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadLibraryRepo
{
    internal class Program
    {
        static void Main(string[] args)
        {

            var p = NativeLibrary.LoadLibrary("VS450.dll");

            Console.WriteLine(p);
        }
    }
}
