using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication6
{
    public class Student
    {
        private String MSSV;
        private String Name;
        private String Email;     
        private String MSSV_
        {
            get
            {
                return MSSV; 
            }
            set
            {
                MSSV = value;
            }
        }
        private String Name_
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        private String Email_
        {
            get
            {
                return Email;
            }
            set
            {
                Email = value;
            }
        }
       
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