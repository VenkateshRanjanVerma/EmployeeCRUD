using EmployeeCRUD.Data;
using System.ComponentModel.DataAnnotations;

namespace EmployeeCRUD.Required
{
    public class UniquePhoneNumberRequired : ValidationAttribute
    {
        private readonly ApplicationDbContext _context;

        protected override ValidationResult IsValid(
        object value, ValidationContext validationContext)
        {
            var _context = (ApplicationDbContext)validationContext.GetService(typeof(ApplicationDbContext));
            if (_context.Employees.Any(x => x.PhoneNumber == value))
            {
                return new ValidationResult(ErrorMessage);
            }
         

            return ValidationResult.Success;
        }
    }
}
