using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace college
{
    //student is-a Collegemember
    public class Student : CollegeMember
    {

        private string _USN;
        private string _dateOfAdmission;
        private string DOB;
        private string _department;

        public Student(string dateOfAdmission, string USN, string Name, int contactNumber, string department, string dateOfBirth, string Address) : base(Name, contactNumber, Address)
        {
            this._dateOfAdmission = dateOfAdmission;
            this.DOB = dateOfAdmission;
            this._department = department;
            this._USN = USN;

        }




    }
}
