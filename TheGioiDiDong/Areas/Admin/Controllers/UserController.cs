using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.DAO;
using Models.EF;
using TheGioiDiDong.Common;
using PagedList;

namespace TheGioiDiDong.Areas.Admin.Controllers
{
    public class UserController : Controller
    {
        // GET: Admin/User
        public ActionResult Index(int page = 1, int pageSize = 10)
        {
            var userDao = new UserDAO();
            var model = userDao.getAll(page, pageSize);
            return View(model);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            if (ModelState.IsValid)
            {
                var userDao = new UserDAO();
                var encryptedMdtPas = Encryptor.MD5Hash(user.Password);
                user.Password = encryptedMdtPas;
                long id = userDao.Insert(user);
                if (id > 0)
                {
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm user thành công");
                }
            }
            return View("Create");
        }

        public ActionResult Json()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Edit(int id)
        {
            var user = new UserDAO().ViewDetail(id);
            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            if (ModelState.IsValid)
            {
                var userDao = new UserDAO();
                if (!string.IsNullOrEmpty(user.Password))
                {
                    var encryptedMdtPas = Encryptor.MD5Hash(user.Password);
                    user.Password = encryptedMdtPas;
                }
                var result = userDao.Update(user);
                if (result)
                {
                    return RedirectToAction("Index", "User");
                }
                else
                {
                    ModelState.AddModelError("", "Thêm user không thành công");
                }
            }
            return View("Create");
        }

        public ActionResult Delete(int id)
        {
            var userDao = new UserDAO();
            userDao.Delete(id);
            return RedirectToAction("Index");
        }
    }
}