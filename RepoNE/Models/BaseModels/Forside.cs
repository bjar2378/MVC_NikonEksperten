using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepoNE;

namespace RepoNE.Models.BaseModels
{
    public class Forside
    {
        public int ID { get; set; }
        
        public string Billede { get; set; }

        public string BilledeTekst { get; set; }

        public int KatID { get; set; }
    }
}
