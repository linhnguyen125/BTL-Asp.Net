using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TheGioiDiDong
{
    [Serializable]
    public class UserLogin
    {
        public long userID { set; get; }

        public string username { set; get; }
    }
}