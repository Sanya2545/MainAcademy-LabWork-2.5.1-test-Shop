using Shop.AppData.Interfaces;
using Shop.AppData.Models;

namespace Shop.AppData.Mocks
{
    public class MockCategory : ICarsCategory
    {
        public IEnumerable<Category> allCategories
        {
            get 
            {
                return new List<Category>
                {
                    new Category{CategoryName = "ElectroCars", Description = "Future transport" },
                    new Category{CategoryName = "ClassicCars", Description = "Transport with internal combustion engine"}
                };
            }
        }
    }
}
