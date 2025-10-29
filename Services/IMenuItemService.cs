using CafeMenuManager.Models;

namespace CafeMenuManager.Services
{
    public interface IMenuItemService
    {
        Task<List<MenuItem>> GetAllMenuItemsAsync();
        Task<List<MenuItem>> GetMenuItemsByCategoryAsync(string category);
        Task<MenuItem?> GetMenuItemByIdAsync(int id);
        Task AddMenuItemAsync(MenuItem menuItem);
        Task UpdateMenuItemAsync(MenuItem menuItem);
        Task DeleteMenuItemAsync(int id);
        Task<List<string>> GetCategoriesAsync();
        Task<List<MenuItem>> GetPopularItemsAsync();
    }
}
