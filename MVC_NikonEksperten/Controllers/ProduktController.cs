using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using RepoNE;

namespace MVC_NikonEksperten.Controllers
{
    
    public class ProduktController : Controller
    {
        ProdukterFac prodFac = new ProdukterFac();
        // GET: Produkt
        public ActionResult ProduktListe(int id=1)
        {
            return View(prodFac.GetProduktListe(id));
        }
    }
}