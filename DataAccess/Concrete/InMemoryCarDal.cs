using DataAccess.Abstract;
using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _car;
        public InMemoryCarDal()
        {
            _car = new List<Car>
            {
                new Car {Id = 1,BrandId = 1,ColorId = 0,DailyPrice = 124000,Description = "Spor Araba",ModelYear = 2015},
                new Car {Id = 2,BrandId = 2,ColorId = 2,DailyPrice = 92000,Description = "SUV",ModelYear = 2017},
                new Car {Id = 3,BrandId = 2,ColorId = 3,DailyPrice = 85000,Description = "hatchback",ModelYear = 2020},
                new Car {Id = 4,BrandId = 3,ColorId = 0,DailyPrice = 124000,Description = "pikap ",ModelYear = 2010}
            };
        }
        
        public void add(Car car)
        {
            _car.Add(car);
           
        }

        public void delete(Car car)
        {
            Car carDelete = _car.SingleOrDefault(c => c.Id == car.Id);
        }

        public List<Car> GetAll()
        {
            return _car;
        }

        public List<Car> GetAllByCategory(int Id)
        {
            return _car.Where(c => c.Id == Id).ToList();
        }

        public void update(Car car)
        {
            Car carToUpdate = _car.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.Id = car.Id;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
            carToUpdate.ModelYear = car.ModelYear;
        }
    }
}
