using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserManagement.Models
{
    [Table("Tb_M_Employee")]
    public class Employee
    {
        [Key]
        public String Id { get; set; }
        public String First_Name { get; set; }
        public String Last_Name { get; set; }
        DateTime Birth_Date { get; set; }
        public String Blood_Type { get; set; }
        public String Gender { get; set; }
        public String Phone_Number { get; set; }
        public String Marital_Status { get; set; }
        public String Address { get; set; }
        public String Zip_Code { get; set; }
        public String Email { get; set; }
        bool IsActive { get; set; }

        [ForeignKey("Religion")]
        public int Religion_Id { get; set; }
        public Religion Religion { get; set; }
        [ForeignKey("Position")]
        public String Position_Id { get; set; }
        public Position Position { get; set; }
        [ForeignKey("Village")]
        public int Village_Id { get; set; }
        public Village Village { get; set; }
        public String Manager_Id { get; set; }
        //[ForeignKey("District")]
        //public int Birth_Place { get; set; }
        //public District District { get; set; }
    }
}
