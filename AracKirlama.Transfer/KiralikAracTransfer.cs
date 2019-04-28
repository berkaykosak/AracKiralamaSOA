using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AracKiralama.Transfer
{
    public class KiralikAracTransfer
    {
        public int kiralikID { get; set; }

        public int? aracID { get; set; }

        public int? kullaniciID { get; set; }

        public DateTime? baslangicTarihi { get; set; }

        public DateTime? bitisTarihi { get; set; }

        public long? verilenKm { get; set; }

        [Column(TypeName = "money")]
        public decimal? alinanUcret { get; set; }

        public bool? iade { get; set; }
    }
}
