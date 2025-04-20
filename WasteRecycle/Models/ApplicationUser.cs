using System.ComponentModel.DataAnnotations;

namespace WasteRecycle.Models
{
    public class ApplicationUser
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public string Role { get; set; } // "Admin", "Client", "Employee"
    }
}
