using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Models
{
    [Table("Tb_M_Subdistrict")]
    public class Subdistrict
    {
        [Key]
        public int Id { get; set; }
        public String Name { get; set; } 
        public bool IsDeleted { get; set; }
        [ForeignKey("District")]
        public int District_Id { get; set; }
        public District District { get; set; }
    }
}
