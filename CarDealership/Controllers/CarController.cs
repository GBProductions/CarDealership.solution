using Microsoft.AspNetCore.Mvc;
using CarDealership.Models;
using System.Collections.Generic;

namespace CarDealership.Controllers
{
  public class CarsController : Controller
  {

    [HttpGet("/cars")]
    public ActionResult Index()
    {
      List<Car> allCars = Car.GetAll();
      return View(allCars);
    }

    [HttpGet("/cars/new")]
    public ActionResult CreateForm()
    {
        return View();
    }

    [HttpPost("/cars")]
    public ActionResult Create(string description, int price)
    {
        Car myCar = new Car(description, price);
        return RedirectToAction("Index");
    }
  }
}