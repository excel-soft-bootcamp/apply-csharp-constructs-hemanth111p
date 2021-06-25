using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculationApp
{
    class Validation
    {
       
        public void validate(int va)
        {

            ConsolemessageDisplay cd = new ConsolemessageDisplay();
            if (va < 18.5)
            {
               cd.message1();
            }
            else if (va >= 25)
            {
                cd.message2();
            }
            else
            {
                cd.message3();
            }


        }

    }
}
