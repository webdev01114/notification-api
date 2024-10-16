using System.ComponentModel.DataAnnotations;

namespace Notification.Api.Models
{
    public class Order
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string productName { get; set; }
        [Required]
        public string status { get; set; }
        [Required]
        public string amount { get; set; }
    }
}
