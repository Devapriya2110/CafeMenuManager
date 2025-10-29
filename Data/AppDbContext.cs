using Microsoft.EntityFrameworkCore;
using CafeMenuManager.Models;

namespace CafeMenuManager.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<MenuItem> MenuItems { get; set; } = null!;

      protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    base.OnModelCreating(modelBuilder);
    
    // Seed initial data with ₹ prices
    modelBuilder.Entity<MenuItem>().HasData(
        // Coffee Items (existing)
        new MenuItem { Id = 1, Name = "Espresso", Category = "Coffee", Price = 120m, Description = "Strong and rich Italian espresso", IsPopular = true, ImageUrl = "/images/espresso.jpg", IsAvailable = true, CreatedDate = DateTime.Now },
        new MenuItem { Id = 2, Name = "Cappuccino", Category = "Coffee", Price = 180m, Description = "Perfect blend of espresso, steamed milk, and foam", IsPopular = true, ImageUrl = "/images/cappuccino.jpg", IsAvailable = true, CreatedDate = DateTime.Now },
        new MenuItem { Id = 3, Name = "Latte", Category = "Coffee", Price = 200m, Description = "Smooth espresso with steamed milk", ImageUrl = "/images/latte.jpg", IsAvailable = true, CreatedDate = DateTime.Now },
        new MenuItem { Id = 4, Name = "Mocha", Category = "Coffee", Price = 220m, Description = "Chocolate-infused espresso with steamed milk", IsPopular = true, ImageUrl = "/images/mocha.jpg", IsAvailable = true, CreatedDate = DateTime.Now },
        new MenuItem { Id = 5, Name = "Cold Brew", Category = "Coffee", Price = 150m, Description = "Smooth cold brewed coffee", ImageUrl = "/images/cold-brew.jpg", IsAvailable = true, CreatedDate = DateTime.Now },

        // Tea Items (existing)
        new MenuItem { Id = 6, Name = "English Breakfast", Category = "Tea", Price = 80m, Description = "Classic robust black tea", ImageUrl = "/images/english-breakfast.jpg", IsAvailable = true, CreatedDate = DateTime.Now },
        new MenuItem { Id = 7, Name = "Green Tea", Category = "Tea", Price = 80m, Description = "Light and refreshing green tea", ImageUrl = "/images/green-tea.jpg", IsAvailable = true, CreatedDate = DateTime.Now },
        new MenuItem { Id = 8, Name = "Chai Latte", Category = "Tea", Price = 120m, Description = "Spiced tea with steamed milk", IsPopular = true, ImageUrl = "/images/chai-latte.jpg", IsAvailable = true, CreatedDate = DateTime.Now },

        // Bakery Items (existing)
        new MenuItem { Id = 9, Name = "Croissant", Category = "Bakery", Price = 100m, Description = "Buttery French croissant", IsPopular = true, ImageUrl = "/images/croissant.jpg", IsAvailable = true, CreatedDate = DateTime.Now },
        new MenuItem { Id = 10, Name = "Blueberry Muffin", Category = "Bakery", Price = 90m, Description = "Fresh blueberry muffin", ImageUrl = "/images/blueberry-muffin.jpg", IsAvailable = true, CreatedDate = DateTime.Now },
        new MenuItem { Id = 11, Name = "Chocolate Chip Cookie", Category = "Bakery", Price = 60m, Description = "Warm chocolate chip cookie", ImageUrl = "/images/chocolate-chip-cookie.jpg", IsAvailable = true, CreatedDate = DateTime.Now },
        new MenuItem { Id = 12, Name = "Sourdough Bread", Category = "Bakery", Price = 180m, Description = "Artisan sourdough loaf", ImageUrl = "/images/sourdough.jpg", IsAvailable = true, CreatedDate = DateTime.Now },
        new MenuItem { Id = 13, Name = "Cinnamon Roll", Category = "Bakery", Price = 110m, Description = "Freshly baked cinnamon roll", IsPopular = true, ImageUrl = "/images/cinnamon-roll.jpg", IsAvailable = true, CreatedDate = DateTime.Now },

        
        // Coffee Items (new)
        new MenuItem { Id = 14, Name = "Filter Coffee", Category = "Coffee", Price = 80m, Description = "Traditional South Indian filter coffee", IsPopular = true, ImageUrl = "/images/filter-coffee.jpg", IsAvailable = true, CreatedDate = DateTime.Now },
        new MenuItem { Id = 15, Name = "Americano", Category = "Coffee", Price = 140m, Description = "Espresso with hot water", ImageUrl = "/images/americano.jpg", IsAvailable = true, CreatedDate = DateTime.Now },
        
        // Tea Items (new)
        new MenuItem { Id = 16, Name = "Masala Chai", Category = "Tea", Price = 60m, Description = "Traditional Indian spiced tea", IsPopular = true, ImageUrl = "/images/masala-chai.jpg", IsAvailable = true, CreatedDate = DateTime.Now },
        new MenuItem { Id = 17, Name = "Earl Grey", Category = "Tea", Price = 90m, Description = "Bergamot flavored black tea", ImageUrl = "/images/earl-grey.jpg", IsAvailable = true, CreatedDate = DateTime.Now },
        
        // Bakery Items (new)
        new MenuItem { Id = 18, Name = "Veg Puff", Category = "Bakery", Price = 50m, Description = "Flaky puff pastry with vegetable filling", IsPopular = true, ImageUrl = "/images/veg-puff.jpg", IsAvailable = true, CreatedDate = DateTime.Now },
        new MenuItem { Id = 19, Name = "Chocolate Donut", Category = "Bakery", Price = 70m, Description = "Soft donut with chocolate glaze", ImageUrl = "/images/chocolate-donut.jpg", IsAvailable = true, CreatedDate = DateTime.Now },
        new MenuItem { Id = 20, Name = "Cheese Sandwich", Category = "Bakery", Price = 120m, Description = "Grilled cheese and vegetable sandwich", IsPopular = true, ImageUrl = "/images/cheese-sandwich.jpg", IsAvailable = true, CreatedDate = DateTime.Now },
        
        // New Category: Smoothies
        new MenuItem { Id = 21, Name = "Mango Smoothie", Category = "Smoothies", Price = 150m, Description = "Fresh mango blended with yogurt", IsPopular = true, ImageUrl = "/images/mango-smoothie.jpg", IsAvailable = true, CreatedDate = DateTime.Now },
        new MenuItem { Id = 22, Name = "Berry Blast", Category = "Smoothies", Price = 160m, Description = "Mixed berries with honey and yogurt", ImageUrl = "/images/berry-blast.jpg", IsAvailable = true, CreatedDate = DateTime.Now },
        
        // New Category: Snacks
        new MenuItem { Id = 23, Name = "French Fries", Category = "Snacks", Price = 90m, Description = "Crispy golden french fries", IsPopular = true, ImageUrl = "/images/french-fries.jpg", IsAvailable = true, CreatedDate = DateTime.Now }
    );
}
}
}
