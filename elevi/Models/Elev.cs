using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace elevi.Models
{
    public class Elev
    {
        public string IDNP { get; set; }
        public string Nume { get; set; }
        public string Prenume { get; set; }
        public DateTime DataNasterii { get; set; }
        public string Clasa { get; set; }
        public Genul Gen { get; set; }
        public Adresa Adresa { get; set; }


        public int GetVarsta()
        {
            DateTime zeroTime = new DateTime(1, 1, 1);
            TimeSpan anii = DateTime.Now - DataNasterii;
            int years = (zeroTime + anii).Year - 1;
            return 0;
        }
        
    }


}
