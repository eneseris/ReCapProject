using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;
using System;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            //CarTest();
            //BrandTest();
            CarJoinTest();
        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            foreach (var brand in brandManager.GetAll())
            {
                Console.WriteLine(brand.Name);
            }
        }

        private static void CarTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());

            var result = carManager.GetCarDetails();
            if (result.Success == true)
            { 
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.DailyPrice);
            }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
        private static void CarJoinTest()
        {
            CarManager carManager = new CarManager(new EfCarDal());
            var result = carManager.GetCarDetails();
            if (result.Success == true) 
            {
            foreach (var car in result.Data)
            {
                Console.WriteLine(car.DailyPrice+" "+car.ColorName+" "+car.BrandName);
            }
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
    }
}
