using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculationApp
{
    public class BmiValueCalculation
    {
        private int bmivalue;

        public int calculator(int height,int weight)
        {
            bmivalue= weight / height;
            return bmivalue;
        }
        
        
       
       
    }
}
