using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepoNE;
using System.IO;

namespace MVC_NikonEksperten.Areas.Admin.Controllers
{
    public class aProdukterController : Controller
    {
        KategoriFac katFac = new KategoriFac();
        ProdukterFac pf = new ProdukterFac();
        Uploader uploader = new Uploader();

        // GET: Admin/aProdukt
        public ActionResult Add()
        {
            return View(katFac.GetAll());
        }

        [HttpPost]
        public ActionResult AddResult(Produkter prod, HttpPostedFile fil)
        {
            if (fil != null)
            {
                string path = Request.PhysicalApplicationPath + "Content/Images/";
                prod.Billede = Path.GetFileName(uploader.UploadImage(fil, path, 300, true));
            }
            else
            {
                prod.Billede = "På vej.jpg";
            }

            pf.Insert(prod);
            ViewBag.MSG = "Produktet er oprettet'!";

            return View("Add", katFac.GetAll());
        }
    }
}