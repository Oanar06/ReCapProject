using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using Entities.Concrete;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car() { Id=6, BrandId=1116, ColorId=2226, ModelYear=2006,Description="Toyota", DailyPrice=150 };
            carManager.Add(car1);

            //CarManager carManager = new CarManager(new EfCarDal());
            //foreach (var car in carManager.GetAll())
            //{
            //    //Console.WriteLine(car.Description + car.DailyPrice +"TL"+"/"+ car.ModelYear);
            //    Console.WriteLine();
            //}
           
        }
    }
}
