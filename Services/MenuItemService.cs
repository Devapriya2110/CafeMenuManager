using CafeMenuManager.Data;
using CafeMenuManager.Models;
using Microsoft.EntityFrameworkCore;

namespace CafeMenuManager.Services
{
    public class MenuItemService : IMenuItemService
    {
        private readonly IDbContextFactory<AppDbContext> _contextFactory;

        public MenuItemService(IDbContextFactory<AppDbContext> contextFactory)
        {
            _contextFactory = contextFactory;
        }

        public async Task<List<MenuItem>> GetAllMenuItemsAsync()
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.MenuItems
                .OrderBy(m => m.Category)
                .ThenBy(m => m.Name)
                .ToListAsync();
        }

        public async Task<List<MenuItem>> GetMenuItemsByCategoryAsync(string category)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.MenuItems
                .Where(m => m.Category == category && m.IsAvailable)
                .OrderBy(m => m.Name)
                .ToListAsync();
        }

        public async Task<MenuItem?> GetMenuItemByIdAsync(int id)
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.MenuItems
                .AsNoTracking()  // Important: prevent tracking issues
                .FirstOrDefaultAsync(m => m.Id == id);
        }

        public async Task AddMenuItemAsync(MenuItem menuItem)
        {
            using var context = _contextFactory.CreateDbContext();
            menuItem.CreatedDate = DateTime.Now;
            context.MenuItems.Add(menuItem);
            await context.SaveChangesAsync();
        }

        public async Task UpdateMenuItemAsync(MenuItem menuItem)
        {
            using var context = _contextFactory.CreateDbContext();
            
            // Attach and mark as modified
            context.MenuItems.Attach(menuItem);
            context.Entry(menuItem).State = EntityState.Modified;
            
            await context.SaveChangesAsync();
        }

        public async Task DeleteMenuItemAsync(int id)
        {
            using var context = _contextFactory.CreateDbContext();
            var menuItem = await context.MenuItems.FindAsync(id);
            if (menuItem != null)
            {
                context.MenuItems.Remove(menuItem);
                await context.SaveChangesAsync();
            }
        }

        public async Task<List<string>> GetCategoriesAsync()
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.MenuItems
                .Select(m => m.Category)
                .Distinct()
                .OrderBy(c => c)
                .ToListAsync();
        }

        public async Task<List<MenuItem>> GetPopularItemsAsync()
        {
            using var context = _contextFactory.CreateDbContext();
            return await context.MenuItems
                .Where(m => m.IsPopular && m.IsAvailable)
                .OrderByDescending(m => m.CreatedDate)
                .Take(8)
                .ToListAsync();
        }
    }
}