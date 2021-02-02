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
            _cars = new List<Car>
            {
                new Car{Id=1,BrandId=2,ColorId=255,DailyPrice=122500,ModelYear=2017,Description="çok güzel araba"},
                new Car{Id=2,BrandId=2,ColorId=12,DailyPrice=452500,ModelYear=2020,Description="pahalı bişey"},
                new Car{Id=3,BrandId=2,ColorId=122,DailyPrice=225500,ModelYear=2021,Description="0 km"},
                new Car{Id=4,BrandId=2,ColorId=36,DailyPrice=53000,ModelYear=2006,Description="ucuz"},
                new Car{Id=5,BrandId=2,ColorId=45,DailyPrice=22000,ModelYear=1992,Description="eski"}
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carUpdate.ColorId = car.ColorId;
            carUpdate.BrandId = car.BrandId;
            carUpdate.DailyPrice = car.DailyPrice;
            carUpdate.Description = car.Description;
            carUpdate.ModelYear = car.ModelYear;

        }
    }
}
