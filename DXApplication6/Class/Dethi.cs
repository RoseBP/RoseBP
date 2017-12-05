using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication6
{
    class Dethi
    {
        public int MaDethi { set; get; }
        public String CourseID { set; get; }

        internal Dethi(int MaDethi , String CourseID)
        {
            this.MaDethi = MaDethi;
            this.CourseID = CourseID;
            
        }

    }
}
