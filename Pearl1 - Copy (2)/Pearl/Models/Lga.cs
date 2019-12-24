using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pearl.Models
{
    [Table("Lgas")]
    public class Lga
    {
        [Key]
        public int LgaID { get; set; }
        [StringLength(10)]
        public string Acronym { get; set; }
        [StringLength(250)]
        public string LgaName { get; set; }
    }   
}