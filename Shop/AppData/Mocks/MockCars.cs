using Microsoft.AspNetCore.Mvc.Formatters;
using Shop.AppData.Interfaces;
using Shop.AppData.Models;

namespace Shop.AppData.Mocks
{
    public class MockCars : IAllCars
    {
        private readonly ICarsCategory _categoryCars = new MockCategory();
        public IEnumerable<Car> Cars 
        {
            get
            {
                return new List<Car>
                {
                    new Car {
                        Name = "Tesla Model S",
                        ShortDescription = "Fast car",
                        LongDescription = "Beautiful, fast and very silent car",
                        Img = "/img/tesla.jpg",
                        Price = 45000,
                        IsFavorite = true,
                        Available = true,
                        Category = _categoryCars.allCategories.First()
                    },
                    new Car {
                        Name = "Ford Fiesta",
                        ShortDescription = "Silent and calm",
                        LongDescription = "Comfortable car for city living",
                        Img = "/img/ford.jpg",
                        Price = 11000,
                        IsFavorite = false,
                        Available = true,
                        Category = _categoryCars.allCategories.Last()
                    },
                    new Car {
                        Name = "BMW M3",
                        ShortDescription = "cheeky and stylish",
                        LongDescription = "Comfortable car for city living",
                        Img = "/img/bmw.jpg",
                        Price = 65000,
                        IsFavorite = true,
                        Available = true,
                        Category = _categoryCars.allCategories.Last()
                    },
                    new Car {
                        Name = "Mercedes C class",
                        ShortDescription = "Cozy and big",
                        LongDescription = "Comfortable car for city living",
                        Img = "/img/mercedes.jpg",
                        Price = 40000,
                        IsFavorite = false,
                        Available = false,
                        Category = _categoryCars.allCategories.Last()
                    },
                    new Car {
                        Name = "Nissan Leaf",
                        ShortDescription = "silent and economical",
                        LongDescription = "Comfortable car for city living",
                        Img = "/img/nissan.jpg",
                        Price = 14000,
                        IsFavorite = true,
                        Available = true,
                        Category = _categoryCars.allCategories.First()
                    },
                };  
            }
        }
        public IEnumerable<Car> getFavCars { get; set; }

        public Car GetCarById(int carId)
        {
            throw new NotImplementedException();
        }
    }
}
