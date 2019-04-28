using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AracKiralama.Transfer
{
    public class RezervasyonTransfer
    {

        public int rezerveID { get; set; }

        [Column(TypeName = "date")]
        public DateTime? rezTarihi { get; set; }

        public bool? rezervliMi { get; set; }

        public int? kullaniciID { get; set; }

        public int? aracID { get; set; }



    }
}
