using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AracKiralama.Entities
{
    [Table("Rezervasyon")]
    public partial class Rezervasyon
    {
        [Key]
        public int rezerveID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? rezTarihi { get; set; }

        public bool? rezervliMi { get; set; }

        public int? kullaniciID { get; set; }

        public int? aracID { get; set; }

        public virtual Arac Arac { get; set; }

        public virtual Kullanicilar kullanici { get; set; }
    }
}
