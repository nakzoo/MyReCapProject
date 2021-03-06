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
                new Car { Id=1, BrandId=33, ModelYear=2019, DailyPrice=112, Description="Renault Clio Hatchback Dizel  Beyaz "},
                new Car { Id=2, BrandId=8, ModelYear=2020, DailyPrice=450, Description="Dacia Sandero Hatchback Benzin/Dizel  Mavi "},
                new Car { Id=3, BrandId=23, ModelYear=2020,DailyPrice=310, Description="Skoda SuperB Sedan Otomatik  Mor "},
                new Car { Id=4, BrandId=50, ModelYear=2015, DailyPrice=180, Description="Volkswagen Polo Hatchback Otomatik Benzin Beyaz"},
                new Car { Id=5, BrandId=13, ModelYear=2020, DailyPrice=190, Description="Ford Focus Sedan Dizel Otomatik Beyaz "}

            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car deleteCar = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(deleteCar);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int id,int BrandId)
        {
            return _cars.Where(c => c.BrandId == BrandId && c.Id == id).ToList();
        }

        public void Update(Car car)
        {
            Car carUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);

            carUpdate.Id = car.Id;
            carUpdate.BrandId = car.BrandId;
            carUpdate.ModelYear = car.ModelYear;
            carUpdate.DailyPrice = car.DailyPrice;

        }


    }
}
