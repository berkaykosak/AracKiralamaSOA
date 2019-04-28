using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations.Schema;


namespace AracKiralama.Entities
{
    [Table("Arac")]
    public partial class Arac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Arac()
        {
            kiralikArac = new HashSet<KiralikArac>();
            Rez = new HashSet<Rezervasyon>();
        }

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

        public virtual SirketBilgi Sirket { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KiralikArac> kiralikArac { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezervasyon> Rez{ get; set; }
    }
}