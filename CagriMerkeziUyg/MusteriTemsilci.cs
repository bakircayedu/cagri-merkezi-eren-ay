using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CagriMerkeziUyg
{
    public class MusteriTemsilci
    {
        public int TemsilciId { get; set; }
        public string TemsilciTuru { get; set; }
        public bool TemsilciDurumu { get; set; } //true = bosta 
        public Cagri cagri { get; set; }


        public MusteriTemsilci()
        {
            TemsilciTuru = "";
            TemsilciDurumu = true;
        }
    }
}
