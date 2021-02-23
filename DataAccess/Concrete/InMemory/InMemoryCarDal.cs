using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> { 
                new Car{Id=1, BrandId=11, ColorId=21, ModelYear=2020, Description="VOLVO" },
                 new Car{Id=2, BrandId=12, ColorId=22, ModelYear=2010, Description="BMW" },
                  new Car{Id=3, BrandId=13, ColorId=23, ModelYear=2008, Description="KİA" },
                   new Car{Id=4, BrandId=14, ColorId=24, ModelYear=2004, Description="RENAULT" },
                    new Car{Id=5, BrandId=15, ColorId=25, ModelYear=2005, Description="MAZDA" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = null;
            carToDelete = _cars.SingleOrDefault(c=> c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;

        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.Description = car.Description;

        }

        List<Car> ICarDal.GetById(int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId).ToList();
        }
    }
}
