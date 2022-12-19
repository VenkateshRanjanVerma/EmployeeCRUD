
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using EmployeeCRUD.Required;

namespace EmployeeCRUD.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Display(Name = "Employee Name")]
        public string Name { get; set; }
        public string Designation { get; set; }
        [Required(ErrorMessage = "Required")]
        [RegularExpression(@"^(\d{10})$", ErrorMessage = "This Phone Number is invalid")]

        [UniquePhoneNumberRequired(ErrorMessage = "This Phone number has been used, please enter a new one")]
        public string PhoneNumber { get; set; }
        [DataType(DataType.MultilineText)]
        public string Address { get; set; }
        public DateTime? RecordCreatedOn { get; set; }
    }
}
