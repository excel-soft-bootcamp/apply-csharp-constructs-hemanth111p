using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculationApp
{
    class Program
    {
        static void Main(string[] args)
        {
            UserInputs inputs = new UserInputs();

            Console.WriteLine("enter user height in meters");
            inputs.SetUserHeight(Console.ReadLine());

            Console.WriteLine("enter user weight in kilogram");
            inputs.SetUserWeight(Console.ReadLine());

            BmiCalculation bc = new BmiCalculation();
            bc.calculator(inputs.GetUserHeight(),inputs.GetUserWeight());

            
            
            
        }
    }
}
