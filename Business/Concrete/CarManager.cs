using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carDal;
        public CarManager(ICarDal carDal)
        {
            _carDal = carDal;
        }

        public void Add(Car car)
        {
            if (car.Description.Length>=2 && car.DailyPrice > 0)

            {
                _carDal.Add(car);
                Console.WriteLine("Araba eklendi:" + car.Description);
            }
            else
            {
                Console.WriteLine("Araba ismi minimum 2 karakter olmalı veAraba fiyatı 0'dan büyük olmalı");
            }
        }

        public void Delete(Car car)
        {
            _carDal.Delete(car);
        }

        public List<Car> GetAll()
        {
           return _carDal.GetAll();
        }

        public List<Car> GetByModelear(decimal min, decimal max)
        {
            return _carDal.GetAll(c => c.ModelYear >= min && c.ModelYear <= max);
        }

      

        public List<Car> GetCarsByBrandId(int BrandId)
        {
            return _carDal.GetAll(c => c.BrandId == BrandId);
        }

        public List<Car> GetCarsByColorId(int ColorId)
        {
           return  _carDal.GetAll(c => c.ColorId == ColorId);
        }
    }
}
