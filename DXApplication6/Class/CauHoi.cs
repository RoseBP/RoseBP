using System.Collections.Generic;

namespace DXApplication6
{
    internal class CauHoi
    {
        public int MaCH { set; get; }
        public string Noidung { set; get; }
        public string PhuongAnA { set; get; }
        public string PhuongAnB { set; get; }
        public string PhuongAnC { set; get; }
        public string PhuongAnD { set; get; }
        public string DapAnDung { set; get; }
        public string CourseID { set; get; }
        public int Made { set; get; }
        internal CauHoi(int MaCH, string Noidung, string PhuongAnA, string PhuongAnB, string PhuongAnC, string PhuongAnD,string DapAnDung,string CourseID,int Made)
        {
            this.MaCH = MaCH;
            this.Noidung = Noidung;
            this.PhuongAnA = PhuongAnA;
            this.PhuongAnB = PhuongAnB;
            this.PhuongAnC = PhuongAnC;
            this.PhuongAnD = PhuongAnD;
            this.DapAnDung = DapAnDung;
            this.CourseID = CourseID;
            this.Made = Made;
        }
        public  string toString()
        {
            return "MaCH:" + MaCH + "  Noi dung:" + Noidung + " Phuong An A:" + PhuongAnA + " Phuong An B:" + PhuongAnB + " Phuong An C:" + PhuongAnC + " Phuong An D:" + PhuongAnD + "   Dap An Dung " + DapAnDung + "  CourseID:" + CourseID + "   Ma de thi" + Made;
        }
    }
}