using Shop.AppData.Models;

namespace Shop.AppData.Interfaces
{
    public interface IAllCars
    {
        IEnumerable<Car> Cars { get;}
        IEnumerable<Car> getFavCars { get; set; }
        Car GetCarById(int carId);
    }
}
