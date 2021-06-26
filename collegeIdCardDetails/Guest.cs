using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace college
{
    //Guest  is-a Collegemember
    class Guest : CollegeMember
    {
        private string _dateOfVisit;
        public Guest(string dateOfVisit, int idNumber, string name, int contactNumber, string department, string dateOfBirth, string address, string bloodGroup) : base(idNumber, name, contactNumber, department, dateOfBirth, address, bloodGroup)
        {
            this._dateOfVisit = dateOfVisit;
        }
    }
}
