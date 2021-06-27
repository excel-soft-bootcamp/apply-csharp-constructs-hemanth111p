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

        private int _EmployeeNumber;
        private string _dateOfJoining;
        private string position;
        private string _Department;
        public Teacher(string dateOfJoining, string _position, int EmployeeNumber, string Name, int contactNumber, string department, string Address) : base(Name, contactNumber, Address)
        {
            this._dateOfJoining = dateOfJoining;
            this.position = _position;
            this._EmployeeNumber = EmployeeNumber;
            this._Department = department;
        }

    }

}
