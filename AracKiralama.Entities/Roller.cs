using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace AracKiralama.Entities
{
    [Table("Roller")]
    public partial class Roller
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Roller()
        {
            kullanici = new HashSet<Kullanicilar>();
        }

        public int rolID { get; set; }

        [Column("rolAdi")]
        [StringLength(50)]
        public string Rol1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Kullanicilar> kullanici { get; set; }
    }
}
