using System.Collections.Generic;

namespace CarDealership.Models
{
  public class Car
  {
    public string Description { get; set; }
    public int Price { get; set; }
    private static List<Car> _instances = new List<Car> { };

    public Car(string description, int price)
    {
      Description = description;
      Price = price;
      _instances.Add(this);
    }

    public static List<Car> GetAll()
    {
      return _instances;
    }

    public static void ClearAll()
    {
      _instances.Clear();
    }
    
  }
}