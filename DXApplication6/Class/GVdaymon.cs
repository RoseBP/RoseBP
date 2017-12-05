using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication6
{
    class GVdaymon
    {
        public string lecturerID { set; get; }
        public string CourseID { set; get; }
        internal GVdaymon(string lecturerID,string CourseID)
        {
            this.lecturerID = lecturerID;
            this.CourseID = CourseID;
        }

    }
}
