using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        List<Car> GetByModelear(decimal min, decimal max);
        List<Car> GetCarsByBrandId(int BrandId);
        List<Car> GetCarsByColorId(int ColorId);
        void Add(Car car);
        void Delete(Car car);
    }
}
