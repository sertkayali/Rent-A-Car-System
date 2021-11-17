using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>()
            {
                new Car() { BrandId = 1, ColorId = 1, DailyPrice = 100, Description = "ınmemoryHyundai Accent", Id = 1, ModelYear = 2000},
                new Car() { BrandId = 1, ColorId = 2, DailyPrice = 120, Description = "ınmemoryHyundai Elantra", Id = 2, ModelYear = 2005},
                new Car() { BrandId = 2, ColorId = 3, DailyPrice = 130, Description = "ınmemoryFord Focus", Id = 3, ModelYear = 2008},
                new Car() { BrandId = 2, ColorId = 4, DailyPrice = 150, Description = "ınmemoryFord Mondeo", Id = 4, ModelYear = 2012},
                new Car() { BrandId = 3, ColorId = 4, DailyPrice = 200, Description = "ınmemoryBMW 320d", Id = 5, ModelYear = 2017},
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

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(c=>c.Id == Id).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c=>c.Id==car.Id);
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.Description = car.Description;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.ColorId = car.ColorId;
           
        }
    }
}
