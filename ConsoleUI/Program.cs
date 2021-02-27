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
            //CarTest2();
            //CarTest1();
            //DtosTest();
            //CarTest3();

          

        }

        private static void CarTest3()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetAll();

            if (result.Success == false)
            {
                foreach (var car in result.Data)
                {
                    Console.WriteLine("Araç Adı : {0} Günlük Ücreti : {1} Detaylar : {2}", car.CarName, car.DailyPrice, car.Description);

                }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }

        private static void DtosTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            ColorManager colorManager = new ColorManager(new EfColorDal());
            foreach (var car in carManager.GetCarDetails().Data)

            {
                Console.WriteLine(car.CarName + "/" + car.DailyPrice + "/" + car.ColorName + "/" + car.Description);
            }
        }

        private static void CarTest2()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            Car car1 = new Car() { Id = 6, BrandId = 1116, ColorId = 2226, ModelYear = 2006, Description = "Toyota", DailyPrice = 150 };
            carManager.Add(car1);
        }

        private static void CarTest1()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            foreach (var car in carManager.GetAll().Data)
            {
                //Console.WriteLine(car.Description + car.DailyPrice +"TL"+"/"+ car.ModelYear);
                Console.WriteLine();
            }
        }
    }
}
