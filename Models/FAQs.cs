using System.ComponentModel.DataAnnotations;

namespace JooneliTrading.Models
{
    public class FAQs
    {
        [Required]
        public string Question { get; set; } = string.Empty;

        [Required]
        public string Answer { get; set; } = string.Empty;
    }
}
