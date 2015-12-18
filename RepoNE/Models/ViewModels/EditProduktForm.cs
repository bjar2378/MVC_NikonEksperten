using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepoNE.Models.ViewModels
{
    public class EditProduktForm
    {
        public List<Kategori> Kategorier { get; set; }
        public Produkter Produkt { get; set; }
    }
}
