using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BmiValueCalculationLib
{
    public static class BmiValueCalculationType
    {
        

        public static int Calculator(int height, int weight)
        {
           int bmivalue = weight / height;
            return bmivalue;
        }




    }
}
