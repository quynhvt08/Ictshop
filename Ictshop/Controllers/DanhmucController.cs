using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ictshop.Models;

namespace Ictshop.Controllers
{
    public class DanhmucController : Controller
    {
        Qlbanhang db = new Qlbanhang();
        // GET: Danhmuc
        public ActionResult DanhmucPartial()
        {
            var danhmuc = db.Hangsanxuats.ToList();
            return PartialView(danhmuc);
        }
        public ActionResult MenuDanhmuc()
        {
            return View();
        }
        public ActionResult Chinhsachmuahang()
        {
            return View();
        }
        public ActionResult Chinhsachbaomat()
        {
            return View();
        }
        public ActionResult Thongtinbaohanh()
        {
            return View();
        }
        public ActionResult Trungtambaohanh()
        {
            return View();
        }
    }
}