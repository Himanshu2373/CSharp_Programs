using System.ComponentModel.DataAnnotations;

namespace CrudOperation.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string categoryName { get; set; }
        [Required]
        public string Description { get; set; }
    }
}
