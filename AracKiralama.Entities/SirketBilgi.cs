using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace AracKiralama.Entities
{
    [Table("SirketBilgi")]
    public partial class SirketBilgi
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public SirketBilgi()
        {
            Arac = new HashSet<Arac>();
        }

        public int sirketID { get; set; }

        public string sirketAdi { get; set; }

        public string sirketSehir { get; set; }

        public string sirketAdres { get; set; }

        public string sirketAracSayisi { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Arac> Arac { get; set; }
    }
}
