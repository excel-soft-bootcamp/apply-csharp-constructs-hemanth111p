using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace college
{
    abstract class CollegeMember
    {
        private int phoneNumber;
        private string _name,  _address;

        //Telescopic Constructor Chain
        public CollegeMember(string Name)
        {
            this._name = Name;
        }

        public CollegeMember(string Name, int contactNumber ) : this(Name)
        {

            this.phoneNumber = contactNumber; ;

        }
        public CollegeMember(string Name, int contactNumber,string Address) : this(Name,contactNumber)
        {

            this._address = Address;

        }
        

    }
    

   
    
    
}

