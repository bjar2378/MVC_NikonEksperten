using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepoNE;
using System.IO;
using RepoNE.Models.ViewModels;

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

        public ActionResult Edit()
        {
            EditProduct ep = new EditProduct();
            ep.Kategorier = katFac.GetAll();
            return View(ep);
        }

        public ActionResult EditList(int KatID)
        {
            EditProduct ep = new EditProduct();
            ProduktListe pl = new ProduktListe();
            ep.Kategorier = katFac.GetAll();
            pl.produkter = pf.GetBy("KatID", KatID);
            pl.kategori = katFac.Get(KatID);
            ep.Produktliste = pl;

            return View("Edit", ep);
        }
        public ActionResult EditForm(int id)
        {
            EditProduktForm epf = new EditProduktForm();
            epf.Kategorier = katFac.GetAll();
            epf.Produkt = pf.Get(id);
            return View(epf);
        }

        [HttpPost]
        public ActionResult EditResult(Produkter prod, HttpPostedFile fil)
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

            pf.Update(prod);


            EditProduktForm epf = new EditProduktForm();
            epf.Kategorier = katFac.GetAll();
            epf.Produkt = pf.Get(prod.ID);
            ViewBag.MSG = "Produktet er opdateret'!";

            return View("EditForm", epf);
        }

        public ActionResult Delete(int id)
        {
            pf.Delete(id);
            return RedirectToAction("Edit");
        }
    }
}