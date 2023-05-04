using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace finallab.Models
{
    public class employees
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public String empId { get; set; }
        public String empName { get; set; }
        public String Email { get; set; }
        public String phoneNumber { get; set; }
        public DateTime hireDate { get; set; }
        public String positionId { get; set; }
    }
}


 