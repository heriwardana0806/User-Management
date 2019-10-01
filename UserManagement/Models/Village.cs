using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Models
{
    [Table("Tb_M_Village")]
    public class Village
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; } 
        public bool IsDeleted { get; set; }
        [ForeignKey("Subdistrict")]
        public int Subdistrict_Id { get; set; }
        public Subdistrict Subdistrict { get; set; }
    }
}
