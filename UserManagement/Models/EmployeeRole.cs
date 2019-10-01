using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Models
{
    [Table("Tb_T_Employee_Role")]
    
    public class EmployeeRole
    {
        [Key]
        public String Id { get; set; }
        [ForeignKey("Employee")]
        public String Employee_Id { get; set; }
        public Employee Employee { get; set; }
        [ForeignKey("Role")]
        public String Role_Id { get; set; }
        public Role Role { get; set; }
    }
}
