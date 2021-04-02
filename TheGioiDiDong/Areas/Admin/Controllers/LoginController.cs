using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.DAO;
using TheGioiDiDong.Areas.Admin.Data;
using TheGioiDiDong.Common;

namespace TheGioiDiDong.Areas.Admin.Controllers
{
    public class LoginController : Controller
    {
        // GET: Admin/Login
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Login(LoginModel model)
        {
            if (ModelState.IsValid)
            {
                var dao = new UserDAO();
                var result = dao.Login(model.Username, Encryptor.MD5Hash(model.Password));
                if (result == 1)
                {
                    var user = dao.GetById(model.Username);
                    var userSession = new UserLogin();
                    userSession.userID = user.ID;
                    Session.Add(CommonConstants.USER_SESSION, userSession);
                    return RedirectToAction("Index", "Dashboard");
                }
                else if (result == -1)
                {
                    ModelState.AddModelError("", "Tài khoản của bạn đã bị khóa");
                }
                else if (result == 0)
                {
                    ModelState.AddModelError("", "Tên đăng nhập hoặc mật khẩu không chính xác");
                }
            }
            return View("Index");
        }
    }
}