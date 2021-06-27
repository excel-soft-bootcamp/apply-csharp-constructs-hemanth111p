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
            Student _student = new Student("1-6-2020","4VM17EC413","rama",1234567,"EC","1-7-1998","mysore");
            Teacher _teacher = new Teacher("14-6-2019","HeadOfDepartment",12457,"yogesh",12457,"CS","mysore");
            Staff _staff = new Staff("librarian",1245,"ravi",124678,"library","mysore");
            Guest _guest = new Guest("14-6-2020","raju",3546678,"bengalore");

        }
    }
}

