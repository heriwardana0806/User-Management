using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Models
{
    [Table("Tb_M_Role")]
    public class Role
    {
        [Key]
        public String Id { get; set; }
        public String Name { get; set; } 
        public bool IsDeleted { get; set; }
    }
}
