using System.ComponentModel.DataAnnotations;

namespace CinemaApp2
{
    public class ValidationHelper
    {
        public static ValidationResult ValidateShowTime(DateTime showTime, ValidationContext context)
        {
            if (showTime < DateTime.Now.Date)
            {
                return new ValidationResult("Session cannot be earlier than today.");
            }

            if (showTime > DateTime.Now.Date.AddYears(3))
            {
                return new ValidationResult("Session cannot be later than three years from today.");
            }

            return ValidationResult.Success!;
        }
    }
}
