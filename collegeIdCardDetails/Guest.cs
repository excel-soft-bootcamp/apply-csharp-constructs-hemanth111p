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
       
        public Guest(string dateOfVisit,string Name, int contactNumber,string Address) : base(Name, contactNumber,Address)
        {
            this._dateOfVisit = dateOfVisit;
        }
    }
}
