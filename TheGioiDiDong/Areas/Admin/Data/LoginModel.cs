using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace TheGioiDiDong.Areas.Admin.Data
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Vui lòng nhập Username")]
        public string Username { set; get; }

        [Required(ErrorMessage = "Vui lòng nhập Password")]
        public string Password { set; get; }

        public bool Remember { set; get; }
    }
}