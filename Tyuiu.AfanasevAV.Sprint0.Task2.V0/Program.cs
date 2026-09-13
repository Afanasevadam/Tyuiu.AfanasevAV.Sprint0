using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Tyuiu.AfanasevAV.Sprint0.Task2.V1.Lib;

namespace Tyuiu.SpirinIS.Sprint0.Task2.V1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Адам"));
            Console.ReadKey();
        }
    }
}