using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Thi_Trac_Nghiem
{
    class KetQuaThi
    {
        public string MaSoKQ { set; get; }
        public string StudentID { set; get; }
        public string MaDeThi { set; get; }
        public string CourseID { set; get; }
        public string DapAnchon { set; get; }
        public double Diem { set; get; }
        internal KetQuaThi(string MaSoKQ,string StudentID,string MaDeThi,string CourseID,string DapAnchon, double Diem)
        {
            this.MaSoKQ = MaSoKQ;
            this.StudentID = StudentID;
            this.MaDeThi = MaDeThi;
            this.CourseID = CourseID;
            this.DapAnchon = DapAnchon;
            this.Diem = Diem;
        }
    }
}
