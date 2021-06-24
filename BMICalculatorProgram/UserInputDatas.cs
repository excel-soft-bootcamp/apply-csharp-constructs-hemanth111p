using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculatorProgram
{
    class UserInputDatas
    {
        #region state
       private int Height;
        
       private int Weight;
        #endregion

        #region behavious , public interfaces / nutrators message passing
        public int GetUserHeight() { return this.Height; }
       
        public int GetUserWeight() { return this.Weight; }
        public void SetUserHeight(string value) { this.Height = Convert.ToInt32(value); }
        
        public void SetUserWeight(String value) { this.Weight = Convert.ToInt32(value); }
        #endregion


        public void calculation()
        {
            int BMIValue = Weight / Height;

        if (BMIValue < 18.5)
            {
                Console.WriteLine("underweight");
            }
            else if (BMIValue >= 25)
            {
                Console.WriteLine("overweighted");
            }
            else
            {
                Console.WriteLine("healthy");
            }




        }

    }
    
    
}
