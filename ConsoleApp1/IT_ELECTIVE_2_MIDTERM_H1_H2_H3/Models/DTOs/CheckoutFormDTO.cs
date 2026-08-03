using System.ComponentModel.DataAnnotations;

namespace IT_ELECTIVE_2_MIDTERM_H1_H2_H3.Models.DTOs
{
    public class CheckoutFormDTO
    {
        [Required(ErrorMessage = "Customer name is required.")]
        public string CustomerName { get; set; } = string.Empty;

        [EmailAddress(ErrorMessage = "Please enter a valid email address.")]
        public string? CustomerEmail { get; set; }
    }
}