using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiValueValidatorLib
{
    public static class BmiValueValidatorType
    {
        
        public static string CheckCondition(int bmiValue)
        {
            if (bmiValue < 18.5)
            {
                return "UnderWeight";
            }
            else if (bmiValue >= 25)
            {
                return "OverWeight";
            }
            else
            {
                return "Normal";
            }
        }
    }
}
