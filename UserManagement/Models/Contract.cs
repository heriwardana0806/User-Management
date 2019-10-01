using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Models
{
    [Table("Tb_M_Contract")]
    public class Contract
    {
        [Key]
        public int Id { get; set; }
        public bool Status { get; set; }
        public DateTime JoinDate { get; set; }
        [ForeignKey("Employee")]
        public String Employee_Id { get; set; }
        public Employee Employee { get; set; }
    }
}
