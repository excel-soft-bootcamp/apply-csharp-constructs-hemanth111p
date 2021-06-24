using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculatorProgram
{
    class Program
    {
        
        static void Main(string[] args)
        {
            UserInputDatas data = new UserInputDatas();
            Console.WriteLine("enter user height");
            data.SetUserHeight(Console.ReadLine());
            Console.WriteLine("enter user weight");
            data.SetUserHeight(Console.ReadLine());
            data.calculation();






        }
    }
}
