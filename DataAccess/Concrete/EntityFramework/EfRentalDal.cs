using Core.DataAccess.EntityFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfRentalDal : EfEntityRepositoryBase<Rental, RentACarContext>,IRentalDal
    {
        //public List<RentalDetailDto> GetRentalDetails()
        //{
        //    //using (RentACarContext context = new RentACarContext())
        //    //{
        //    //    //var result = from c in context.Cars
        //    //    //             join r in context.Rentals
        //    //    //             on  c
        //    //}
        //}
      
    }
}
