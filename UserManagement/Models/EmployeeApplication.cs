using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Models
{
    [Table("Tb_T_Employee_Application")]
    public class EmployeeApplication
    {
        public int Id { get; set; }

        [ForeignKey("Application")]
        public String Application_Id { get; set; }
        public Application Application { get; set; }
        [ForeignKey("Employee")]
        public String Employee_Id { get; set; }
        public Employee Employee { get; set; }
    }
}
