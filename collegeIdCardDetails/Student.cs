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

        #region members
        string _dateOfAdmission;

        #endregion

        public Student(string dateOfAdmission, int idNumber, string name, int contactNumber, string department, string dateOfBirth, string address, string bloodGroup) : base(idNumber, name, contactNumber, department, dateOfBirth, address, bloodGroup)
        {
            this._dateOfAdmission = dateOfAdmission;

        }




    }
}
