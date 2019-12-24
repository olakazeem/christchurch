using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pearl.Models
{
    [Table("Department")]
    public class Departments
    {
        [Key]
        public int DeptID { get; set; }
        [StringLength(4)]
        public string DeptName { get; set; }
        
    }
}
