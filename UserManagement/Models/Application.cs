using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Models
{
    [Table("Tb_M_Application")]
    public class Application
    {
        public String Id { get; set; } 
        public String Name { get; set; }
        public bool IsDeleted { get; set; }
    }
}
