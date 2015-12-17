using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace RepoNE.Models.ViewModels
{
    public class ProduktListe
    {
        public Kategori kategori { get; set; }
        public List<Produkter> produkter { get; set; }
    }
}
