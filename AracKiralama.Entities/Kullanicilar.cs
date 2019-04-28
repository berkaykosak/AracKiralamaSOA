using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.ComponentModel.DataAnnotations;


namespace AracKiralama.Entities
{
    [Table("Kullanicilar")]
    public partial class Kullanicilar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Kullanicilar()
        {
            kiralikArac = new HashSet<KiralikArac>();
            Rez = new HashSet<Rezervasyon>();
        }

        public int kullaniciId { get; set; }

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

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KiralikArac> kiralikArac { get; set; }

        public virtual Roller Rol { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Rezervasyon> Rez { get; set; }
    }
}
