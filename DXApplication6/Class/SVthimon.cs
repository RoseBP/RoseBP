using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication6
{
    class SVthimon
    {
        public string StudentID { set; get; }
        public string CourseID { set; get; }
        internal SVthimon(string StudentID,string CourseID)
        {
            this.StudentID = StudentID;
            this.CourseID = CourseID;
        }
    }
}
