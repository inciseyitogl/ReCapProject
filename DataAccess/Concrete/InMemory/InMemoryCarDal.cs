using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;//Classın içinde ancak tüm metotların dışında tanımladığımız değişkene global değişken denir (bu class için global değişken)
        //Yazma standartı _ koyularak oluyor. Referans tipin (List<Car>) global değişkeni_car
        public InMemoryCarDal()//Constracter : Bellekte referans aldığı zaman çalışacak olan ilk blok // Direkt classın ismiyle olan metot constracterdır
        {
            _cars = new List<Car> {
                new Car{ BrandId=1, CarId=1,ColorId=1,DailyPrice=150000,ModelYear=2007,CarDescription="Ford"},
                new Car{ BrandId=2, CarId=2,ColorId=3,DailyPrice=200000,ModelYear=2015,CarDescription="Ford"},
                new Car{ BrandId=3, CarId=3,ColorId=2,DailyPrice=170000,ModelYear=2016,CarDescription="Hyundai"},
                new Car{ BrandId=4, CarId=4,ColorId=2,DailyPrice=300000,ModelYear=2018,CarDescription="Chevrolet"},
                new Car{ BrandId=5, CarId=5,ColorId=1,DailyPrice=250000,ModelYear=2013,CarDescription="Mercedes"},
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //_cars.Remove(car); // Bu şekilde bir liste öğesinisilemeyiz çünkü bu kod ancak bir değer tip silebilir(,nt,string..) bir referans tip silemez
            /*
            //LINQ bilmeden silme
           /Car carToDelete = null;
            foreach (var c in _cars)
            {
                if (car.CarId == c.CarId)
                {
                    carToDelete = c;
                }
            }

            _cars.Remove(carToDelete); //Bu şekilde çalışır
           */

            //LINQ ile silme
            Car carToDelete = _cars.SingleOrDefault(c=>c.CarId == car.CarId);

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

        public List<Car> GetById(int carId)
        {
            return _cars.Where(c => c.CarId == carId).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.CarId == car.CarId);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.CarDescription = car.CarDescription;
            carToUpdate.CarId = car.CarId;
        }
    }
}
