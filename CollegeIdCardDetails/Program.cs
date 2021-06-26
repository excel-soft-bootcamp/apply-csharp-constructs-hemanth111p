using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace college
{
    public class Program
    {

        static void Main()
        {
            Student _student = new Student("1-06-2020",1001,"rama",123456789,"EC","17/03/1997","mysore","A+");
            Teacher _teacher = new Teacher("1-1-2020","Principle",121,"abcd",125124,"mathematics","2-5-1980","bengalore","B-");
            Staff _staff = new Staff("librarian",1001,"ravi",8541254,"library","6-4-1990","mysore","O+");
            Guest _guest = new Guest("14-4-2021",12,"raju",74512546,"office","1-4-1995","xyz","O+");

        }
    }
}

