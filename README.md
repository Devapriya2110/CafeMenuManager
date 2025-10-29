# ☕ Cafe Menu Manager

A modern, responsive Blazor Server application for managing cafe menu items with real-time updates and admin functionality.


## 🚀 Features

- **Menu Display**: Beautiful grid layout showing all menu items
- **Admin Panel**: Full CRUD operations for menu management
- **Category Filtering**: Organize items by categories (Coffee, Tea, Bakery, etc.)
- **Real-time Updates**: Instant availability toggling


## 🛠️ Technology Stack

- **Frontend**: Blazor Server, HTML5, CSS3
- **Backend**: ASP.NET Core 6.0
- **Database**: SQLite with Entity Framework Core
- **Styling**: Custom CSS with responsive grid layout


## 🚀 Installation & Quick Start

### 📋 Prerequisites

- [.NET 6.0 SDK](https://dotnet.microsoft.com/download/dotnet/6.0)
- Visual Studio 2022 or VS Code

### 🏃‍♂️ How to Run

1. **Clone the repository**
```bash
   git clone https://github.com/Devapriya2110/CafeMenuManager.git
   cd CafeMenuManager
```
2. **Restore dependencies**
```bash
dotnet restore
```
3. **Run the application**
```bash
dotnet build 
dotnet run
```
4. **Open your browser and navigate**
```bash
https://localhost:7152
```
5. **There are two pages**

After opening it in browser, Please make sure to scroll down and click on go to admin page in the admin page I have used the CRUD operations for the cafe menu items and their management.


## 📱Pages

**Manager Page (/)**
- Displays all menu items in a responsive grid

- Shows item details, prices in ₹, and availability status

- Popular items are highlighted

**Admin Page (/admin)**
- Full menu management interface

- Add, edit, delete menu items

- Toggle item availability

- Search functionality


## 🗃️ Database

The application uses SQLite with the following main entity:

```csharp
public class MenuItem
{
    public int Id { get; set; }
    public string Name { get; set; }
    public string Category { get; set; }
    public decimal Price { get; set; }
    public string Description { get; set; }
    public bool IsAvailable { get; set; }
    public bool IsPopular { get; set; }
    public DateTime CreatedDate { get; set; }
}
```


## 🎯 Project Structure
```
CafeMenuManager/
├── Data/           # Database context (AppDbContext.cs)
├── Models/         # Data models (IMenuItem.cs, MenuItem.cs)
├── Services/       # Business logic (MenuItemService.cs)
├── Pages/          # Blazor components
│   ├── Index.razor    # Main menu page
│   └── Admin.razor    # Management panel
├── wwwroot/        # Static files (CSS, images)
├── Program.cs      # Application startup
└── README.md       # This file
```


## 🔧 Configuration

Database connection string in appsettings.json:

```json
{
  "ConnectionStrings": {
    "DefaultConnection": "Data Source=cafemenu.db"
  }
}
```


## 👨‍💻 Development

To modify the application:

1. **Add new menu items**: Update the seed data in AppDbContext.cs

2. **Change styling**: Modify CSS in wwwroot/css/site.css or component styles

3. **Add features**: Extend services in Services/ folder


## 📞 Support

If you encounter any issues, please create an issue in the GitHub repository.


## 📄 License

This project is for educational purposes.
