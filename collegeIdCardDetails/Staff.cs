using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace college
{
    //Staff  is-a Collegemember
    class Staff : CollegeMember
    {


        private string _workType;
        private string _department;
        private int _IdNumber;

        public Staff(string workType, int idNumber, string Name, int contactNumber, string department, string Address) : base(Name, contactNumber, Address)
        {

            this._workType = workType;
            this._department = department;
            this._IdNumber = idNumber;
        }
    }
}
