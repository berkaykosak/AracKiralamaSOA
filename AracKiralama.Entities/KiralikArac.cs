using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;

namespace AracKiralama.Entities
{

    [Table("KiralikArac")]
    public partial class KiralikArac
    {
        public int kiralikId { get; set; }

        public int? aracID { get; set; }

        public int? kullaniciID { get; set; }

        public DateTime? baslangicTarihi { get; set; }

        public DateTime? bitisTarihi { get; set; }

        public long? verilenKm { get; set; }

        [Column(TypeName = "money")]
        public decimal? alinanUcret { get; set; }

        public bool? iade { get; set; }

        public virtual Arac Arac { get; set; }

        public virtual Kullanicilar kullanici { get; set; }
    }
}
