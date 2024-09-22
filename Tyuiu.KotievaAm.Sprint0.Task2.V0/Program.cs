using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.KotievaAm.Sprint0.Task2.V0.Lib;


namespace Tyuiu.KotievaAm.Sprint0.Task2.V0
{
    internal class Program
    {
        
        
           static void Main(string[] args)
           {
            Console.WriteLine(DataService.GetMessage("Амина"));
            Console.ReadKey();
            Console.ReadKey();
           }
        
    }
}
