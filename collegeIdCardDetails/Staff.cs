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

        public Staff(string workType, int idNumber, string name, int contactNumber, string department, string dateOfBirth, string address, string bloodGroup) : base(idNumber, name, contactNumber, department, dateOfBirth, address, bloodGroup)
        {

            this._workType = workType;

        }
    }
}
