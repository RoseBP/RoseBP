using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DXApplication6
{
    class lecturer
    {
        String _LecturerName;
        public String LecturerName
        {
            set
            {
                _LecturerName = value;
            }
            get
            {
                return _LecturerName;
            }
        }
        String _LecturerID;
        public String LecturerID
        {
            set
            {
                _LecturerID = value;
            }
            get
            {
                return _LecturerID;
            }
        }
        String _faculity;
        public String faculity
        {
            set
            {
                _faculity = value;
            }
            get
            {
                return _faculity;
            }
        }
        
        internal lecturer(String name, String Lecturerid, String faculity)
        {
            this._LecturerName = name;
            this._LecturerID = Lecturerid;
            this._faculity = faculity;
        }
    }
}
