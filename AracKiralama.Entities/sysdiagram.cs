using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AracKiralama.Entities
{
    //bu class sysdiagrams, diyagramları izlemek ve yönetmek için SQL Server tarafından tutulan bir tablodur. 
    //Bu bir sistem masasıdır. Yalnız bırakmak en iyisi.


    public partial class sysdiagrams
    {
        [Required]
        [StringLength(128)]
        public string name { get; set; }

        public int principal_id { get; set; }

        [Key]
        public int diagram_id { get; set; }

        public int? version { get; set; }

        public byte[] definition { get; set; }
    }
}
