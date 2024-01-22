using Business.Abstract;
using Business.Constants;
using Core.Utilities.Results;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class BrandManager : IBrandService
    {
        private readonly IBrandDal _brandDal;

        public BrandManager(IBrandDal brandDal)
        {
            _brandDal = brandDal;
        }

        public IResult Add(Brand brand)
        {
            if (string.IsNullOrEmpty(brand.BrandName))
            {
                return new ErrorResult(Messages.BrandNameInvalid);
            }

            _brandDal.Add(brand);
            return new SuccessResult(Messages.BrandAdded);
        }

        public IResult Update(Brand brand)
        {
            _brandDal.Update(brand);
            return new SuccessResult(Messages.BrandUpdated);
        }

        public IResult Delete(Brand brand)
        {
            _brandDal.Delete(brand);
            return new SuccessResult(Messages.BrandDeleted);
        }

        public IDataResult<List<Brand>> GetAll()
        {
            var brands = _brandDal.GetAll();
            return new SuccessDataResult<List<Brand>>(brands, Messages.BrandsListed);
        }

        public IDataResult<Brand> GetById(int brandId)
        {
            var brand = _brandDal.Get(b => b.BrandId == brandId);
            return new SuccessDataResult<Brand>(brand, Messages.BrandsListed);
        }

        IDataResult<List<Brand>> IBrandService.GetById(int BrandId)
        {
            throw new NotImplementedException();
        }
    }
}
