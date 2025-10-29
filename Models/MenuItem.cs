using System.ComponentModel.DataAnnotations;

namespace CafeMenuManager.Models
{
    public class MenuItem
    {
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Name is required")]
        public string Name { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Category is required")]
        public string Category { get; set; } = string.Empty;
        
        [Required(ErrorMessage = "Price is required")]
        [Range(0.01, 1000, ErrorMessage = "Price must be between 0.01 and 1000")]
        public decimal Price { get; set; }
        
        public string Description { get; set; } = string.Empty;
        public bool IsAvailable { get; set; } = true;
        public string ImageUrl { get; set; } = string.Empty;
        public bool IsPopular { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
    }
}