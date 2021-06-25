using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculationApp
{
    class BmiValueValidation
    {

        #region Checking BMIvalue 
        public string CheckCondition(int BMIValue)
        {
            if (BMIValue < 18.5)
            {
                return "UnderWeight";
            }
            else if (BMIValue >= 25)
            {
                return "OverWeight";
            }
            else
            {
                return "Normal";
            }
        }
        #endregion

    }
}
