using Microsoft.AspNetCore.Mvc;
using Shop.AppData.Interfaces;
using Shop.ViewModels;

namespace Shop.Controllers
{
    public class CarsController : Controller
    {
        private readonly IAllCars _allCars;
        private readonly ICarsCategory _allCategories;
        public CarsController(IAllCars iAllCars, ICarsCategory iCarsCat)
        {
            _allCars = iAllCars;
            _allCategories = iCarsCat;
        }
        public ViewResult List()
        {
            ViewBag.Title = "Car Page";
            CarsListViewModel carsList = new CarsListViewModel();
            carsList.AllCars =  _allCars.Cars;
            carsList.currCategory = "Cars";
            return View(carsList);
        }
    }
}
