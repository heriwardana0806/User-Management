using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Models
{
    [Table("Tb_T_User")]
    public class User
    {
        [Key]
        public String Id { get; set; }
        public String Email { get; set; }
        public String Password { get; set; }
     
    }
}
