using Core.Utilities.Results;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abstract
{
    public interface ICarImagesService
    {
        IResult Add();
        IResult Delete();
        IResult Update();

        IDataResult<List<CarImages>> GetAll();
      
    }
}
