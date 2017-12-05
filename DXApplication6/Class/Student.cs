using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication6
{
    public class Student
    {
        public String MSSV { set; get; }
        public String Name { set; get; }
        public String Email { set; get; }


        internal Student(string name, string mSSV)
        {
            this.Name = "";
            this.MSSV = "";            
            this.Email = "";            
        }
        internal Student(String MSSV,  String Name,  String Email)
        {
            this.Name = Name;
            this.MSSV = MSSV;
            this.Email = Email;            
        }
    }
}