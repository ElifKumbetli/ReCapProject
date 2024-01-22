using Core.Utilities.Results;
using Entities.Concrete; // Assuming your Color class is in the Entities.Concrete namespace
using System.Collections.Generic;

namespace Business.Abstract
{
    public interface IColorService
    {
        IDataResult<List<Color>> GetAll();
        IDataResult<Color> GetById(int colorId);
        IResult Add(Color color);
        IResult Update(Color color);
        IResult Delete(Color color);
    }
}
