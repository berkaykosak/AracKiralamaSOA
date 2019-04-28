using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AracKiralama.Transfer
{
    public class KullanicilarTransfer
    {
        public int kullaniciID { get; set; }

        [StringLength(50)]
        public string adi { get; set; }

        [StringLength(50)]
        public string soyadi { get; set; }

        public string email { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ehliyetYasi { get; set; }

        [StringLength(50)]
        public string sifre { get; set; }

        [Column(TypeName = "date")]
        public DateTime? dogumTarihi { get; set; }

        public int? rolID { get; set; }
    }
}
