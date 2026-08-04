using System.ComponentModel.DataAnnotations;

namespace IT_ELECTIVE_2_MIDTERM_H1_H2_H3.Models.DTOs
{
    public class CheckoutFormDTO
    {
        [Required]
        public string CustomerName { get; set; }

        [EmailAddress]
        public string? CustomerEmail { get; set; }
    }
}