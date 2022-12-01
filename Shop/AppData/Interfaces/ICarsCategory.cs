using Shop.AppData.Models;

namespace Shop.AppData.Interfaces
{
    public interface ICarsCategory
    {
        IEnumerable<Category> allCategories { get; }
    }
}
