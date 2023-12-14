using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ictshop.Models;

namespace Ictshop.Controllers
{
    public class SanphamController : Controller
    {
        Qlbanhang db = new Qlbanhang();

        // GET: Sanpham
        public ActionResult spmoi()
        {
            var spnew = db.Sanphams.Where(n => n.Sanphammoi == true).Take(8).ToList();
            return PartialView(spnew);
        }
        public ActionResult dtiphonepartial()
        {
            var ip = db.Sanphams.Where(n=>n.Mahang==2).Take(8).ToList();
           return PartialView(ip);
        }
        public ActionResult Apple()
        {
            var ip = db.Sanphams.Where(n => n.Mahang == 2).Take(8).ToList();
            return PartialView(ip);
        }
        public ActionResult dtsamsungpartial()
        {
            var ss = db.Sanphams.Where(n => n.Mahang == 1).Take(12).ToList();
            return PartialView(ss);
        }
        public ActionResult Samsung()
        {
            var ss = db.Sanphams.Where(n => n.Mahang == 1).Take(8).ToList();
            return PartialView(ss);
        }
        public ActionResult dtxiaomipartial()
        {
            var mi = db.Sanphams.Where(n => n.Mahang == 3).Take(8).ToList();
            return PartialView(mi);
        }
        public ActionResult Xiaomi()
        {
            var mi = db.Sanphams.Where(n => n.Mahang == 3).Take(8).ToList();
            return PartialView(mi);
        }
        //public ActionResult dttheohang()
        //{
        //    var mi = db.Sanphams.Where(n => n.Mahang == 5).Take(4).ToList();
        //    return PartialView(mi);
        //}
        public ActionResult xemchitiet(int Masp=0)
        {
            var chitiet = db.Sanphams.SingleOrDefault(n=>n.Masp==Masp);
            if (chitiet == null)
            {
                Response.StatusCode = 404;
                return null;
            }
            return View(chitiet);
        }

        [HttpPost]
        public ActionResult TimKiem(string keyword)
        {       
                var searchResults = db.Sanphams
                    .Where(p => p.Tensp.ToLower().Contains(keyword.ToLower()))
                    .ToList();

                return PartialView("KQTimKiem", searchResults);        
        }



        public ActionResult KQTimKiem()
        {
            return View();
        }

        public PartialViewResult KQTimKiem(List<Sanpham> model)
        {
            return PartialView("KQTimKiem", model);
        }


        public ActionResult dttheohang(int brandId)
        {
            var products = db.Sanphams.Where(p => p.Mahang == brandId).ToList();
            return View(products);
        }

    }

}