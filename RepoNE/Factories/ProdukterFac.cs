using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepoNE.Models.ViewModels;
using RepoNE.Models.BaseModels;

namespace RepoNE
{
   public class ProdukterFac : AutoFac<Produkter>
    {
        KategoriFac katFac = new KategoriFac();
        public ProduktListe GetProduktListe(int katID)
        {
            ProduktListe pl = new ProduktListe();
            pl.kategori = katFac.Get(katID);
            pl.produkter = GetBy("KatID", katID);
            return pl;
        }
    }
}
