using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CagriMerkeziUyg
{
    public class Cagri
    {
        public int CagriTanimlayici { get; set; }
        public string MusteriTanimlayici { get; set; }
        public string CagriTuru { get; set; }
        public DateTime AramaZamani { get; set; }
        public MusteriTemsilci MusteriTemsilciTanimlayici { get; set; }
        public DateTime GorusmeBaslangicZaman { get; set; }
        public DateTime GorusmeBitisZaman { get; set; }
        public string GorusmeNotlari { get; set; }
        public Cagri(string musteriTel, string cagriTuru, DateTime dt,int cagriid)
        {
            MusteriTanimlayici = musteriTel;
            CagriTuru = cagriTuru;
            AramaZamani = dt;
            CagriTanimlayici = cagriid;
            GorusmeNotlari = "";
            MusteriTemsilciTanimlayici =new MusteriTemsilci();
        }
    }
}
