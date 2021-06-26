using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace college
{
    public class CollegeMember
    {
        private int _idNumber, phoneNumber;
        private string _name, DOB, _bloodGroup, _address, _department;

        //Telescopic Constructor Chain
        public CollegeMember(int idNumber)
        {
            this._idNumber = idNumber;
        }

        public CollegeMember(int idNumber, string name) : this(idNumber)
        {

            this._name = name;

        }
        public CollegeMember(int idNumber, string name, int contactNumber) : this(idNumber, name)
        {

            this.phoneNumber = contactNumber;

        }
        public CollegeMember(int idNumber, string name, int contactNumber, string department) : this(idNumber, name, contactNumber)
        {

            this._department = department;

        }
        public CollegeMember(int idNumber, string name, int contactNumber, string department, string dateOfBirth) : this(idNumber, name, contactNumber, department) {

            this.DOB = dateOfBirth;

        }
        public CollegeMember(int idNumber, string name, int contactNumber, string department, string dateOfBirth, string address) : this(idNumber, name, contactNumber, department, dateOfBirth)
        {

            this._address = address;

        }
        public CollegeMember(int idNumber, string name, int contactNumber, string department, string dateOfBirth, string address, string bloodGroup) : this(idNumber, name, contactNumber, department, dateOfBirth, address)
        {

            this._bloodGroup = bloodGroup;

        }



    }
    

   
    
    
}

