using Entities.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abstract
{
  public interface ICarDal 
    {
        List<Car> GetAll();
        void add(Car car);
        void delete(Car car);
        void update(Car car);
        List<Car> GetAllByCategory(int Id);
    }
}
