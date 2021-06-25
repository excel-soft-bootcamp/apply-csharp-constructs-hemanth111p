using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculationApp
{
    class BmiValueCalculation
    {
       int BmiValue;

        public void calculator(int height,int weight)
        {
            BmiValue = weight / height;
            BmiValueValidation va = new BmiValueValidation();
            va.validate(BmiValue);
        }
        
        
       
       
    }
}
