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

          

            BmiValueCalculation value = new BmiValueCalculation();
            int BmiValue=value.calculator(inputs.GetUserHeight(),inputs.GetUserWeight());
            

            BmiValueValidation validate = new BmiValueValidation();
           string message= validate.CheckCondition(BmiValue);

            ConsoleMessageDisplay display = new ConsoleMessageDisplay();
            display.Display(message);
            
            
            
        }
    }
}
