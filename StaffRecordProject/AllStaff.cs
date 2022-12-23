using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaffRecordProject
{
    public class AllStaff : IAcademicStaff, INonAcademicStaff
    {
        

        public string FirstName { get ; set ; }
        public string LastName { get ; set ; }
        public string Email { get ; set ; }
        public string IDCard { get ; set ; }
        public string Role { get ; set ; }
        

        public void Admin()
        {

        }

        public void ExamOfficer()
        {

        }

        public void Principal()
        {

        }

        public void Teacher()
        {

        }


    }
}
