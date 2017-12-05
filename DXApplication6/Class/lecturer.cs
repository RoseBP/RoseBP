using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication6
{
    class lecturer
    {
        public String LecturerName { set; get; }
        
        public String LecturerID { set; get; }

        public String faculity { set; get; }


        internal lecturer(String name, String Lecturerid, String faculity)
        {
            this.LecturerName = name;
            this.LecturerID = Lecturerid;
            this.faculity = faculity;
        }
    }
}
