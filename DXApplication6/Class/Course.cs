using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication6
{
    class Course
    { 
        private String MaMH;
        private String TenMH;
        
        internal Course()
        {
            this.MaMH = "";
            this.TenMH = "";           
        }
        internal Course(String MaMH, String TenMH)
        {
            this.MaMH = MaMH;
            this.TenMH = TenMH;
        }
        public String TENMH
        {
            get
            {
                return TenMH;
            }
            set
            {
                TenMH = value;
            }
        }
         public String MAMH
        {
            get
            {
                return MaMH;
            }
            set
            {
                MaMH = value;
            }
        }
    }
}
