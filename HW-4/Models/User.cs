using System.ComponentModel.DataAnnotations;

namespace HW_4.Models
{
    public class User
    {
        [Display(Name="Введіть ім'я:")]
        [Required(ErrorMessage = "Введіть ім'я")]
        [StringLength(50,MinimumLength = 2,ErrorMessage ="Невірно введене ім'я")]
        public string Name { get; set; }

        
        [Display(Name = "Введіть email:")]
        [Required(ErrorMessage = "Введіть email")]
        [RegularExpression(@"[A-Za-z0-9._%+-]+@[A-Za-z0-9.-]+\.[A-Za-z]{2,4}", ErrorMessage = "Невірно введений email")]
        public string Email { get; set; }
    }
}
