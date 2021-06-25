using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BMICalculationApp
{
    class UserInputs
    {
        #region state
        private int height;

       private int weight;
        #endregion

        #region behavious , public interfaces / nutrators message passing
        public int GetUserHeight() { return this.height; }

        public int GetUserWeight() { return this.weight; }
        public void SetUserHeight(string value) { this.height = Convert.ToInt32(value); }

        public void SetUserWeight(String value) { this.weight = Convert.ToInt32(value); }
        #endregion



        
    }
}
