using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlakDukkani.Entities
{
    public class Album
    {
        public int AlbumID { get; set; }
        public string AlbumAdi { get; set; }
        public string SanatciAdi { get; set; }
        public DateTime CıkısTarihi { get; set; }
        public Decimal Fiyat { get; set; }
        public int IndirimOrani { get; set; }
        public bool SatisDevamMi { get; set; }
    }
}
