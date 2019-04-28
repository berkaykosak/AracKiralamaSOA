using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace AracKiralama.Transfer
{
    public class RollerTransfer
    {

        public int rolID { get; set; }

        [Column("Role")]
        [StringLength(50)]
        public string Rol1 { get; set; }



    }
}
