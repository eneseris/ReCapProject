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
            //CarJoinTest();
            //RentDetailsTest();
            RentTest();

        }

        private static void BrandTest()
        {
            BrandManager brandManager = new BrandManager(new EfBrandDal());
            var result = brandManager.GetAll();
            foreach (var brand in result.Data)
            {
                Console.WriteLine(brand.Name);
            }
        }

        private static void RentDetailsTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetRentalDetails();
            if (result.Success == true)
            {
                foreach (var rent in result.Data)
                {
                    Console.WriteLine("CustomerName:{0} - CarName:{1} - CompanyName:{2} - RentDate:{3} - ReturnDate:{4}",
                        rent.CustomerName, rent.CarName, rent.CustomerName, rent.RentDate, rent.ReturnDate);
                }
                Console.WriteLine(result.Message);
            }
            else
            {
                Console.WriteLine(result.Message);
            }
        }
        private static void RentTest()
        {
            RentalManager rentalManager = new RentalManager(new EfRentalDal());
            var result = rentalManager.GetAll(); 
            foreach (var r in result.Data)
            {
                Console.WriteLine(r.CarId+ " " + r.CustomerId+" "+ r.RentDate);
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
