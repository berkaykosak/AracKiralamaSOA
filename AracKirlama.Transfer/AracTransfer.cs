using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AracKiralama.Transfer
{
    public class AracTransfer
    {
        public int aracID { get; set; }

        public string aracMarka { get; set; }

        public string aracModel { get; set; }

        public string gerekenEhliyetYasi { get; set; }

        public byte? minimumYas { get; set; }

        public int? gunlukKmSinir { get; set; }

        public long? anlikKm { get; set; }

        public bool? airbag { get; set; }

        public int? bagajHacmi { get; set; }

        public byte? koltukSayisi { get; set; }

        [Column(TypeName = "money")]
        public decimal? gunlukKiralikFiyat { get; set; }

        public int? sirketID { get; set; }

        public bool? Rezerve { get; set; }

    }
}

