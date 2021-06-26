using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace college
{
    //Teacher  is-a Collegemember
    class Teacher : CollegeMember
    {


        private string _dateOfJoining;
        private string position;
        public Teacher(string dateOfJoining, string _position, int idNumber, string name, int contactNumber, string department, string dateOfBirth, string address, string bloodGroup) : base(idNumber, name, contactNumber, department, dateOfBirth, address, bloodGroup)
        {
            this._dateOfJoining = dateOfJoining;
            this.position = _position;
        }

    }

}
