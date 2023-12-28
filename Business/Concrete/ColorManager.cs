using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;

namespace Business.Concrete
{
    public class ColorManager : IColorService
    {
        IColorDal _colorDal;

        public ColorManager(IColorDal colorDal)
        {
            _colorDal = colorDal;
        }

        public void Add(Color color)
        {
            // Implemente etmek istediğiniz işlemleri burada gerçekleştirin
            _colorDal.Add(color);
        }

        public void Add(System.Drawing.Color color)
        {
            throw new NotImplementedException();
        }

        public void Delete(Color color)
        {
            // Implemente etmek istediğiniz işlemleri burada gerçekleştirin
            _colorDal.Delete(color);
        }

        public void Delete(System.Drawing.Color color)
        {
            throw new NotImplementedException();
        }

        public List<Color> GetAll()
        {
            // Implemente etmek istediğiniz işlemleri burada gerçekleştirin
            return _colorDal.GetAll();
        }

        // ColorManager.cs
        public Color GetById(int colorId)
        {
            return _colorDal.Get(c => c.ColorId == colorId);
        }


        public void Update(Color color)
        {
            // Implemente etmek istediğiniz işlemleri burada gerçekleştirin
            _colorDal.Update(color);
        }

        public void Update(System.Drawing.Color color)
        {
            throw new NotImplementedException();
        }

        List<System.Drawing.Color> IColorService.GetAll()
        {
            throw new NotImplementedException();
        }

        System.Drawing.Color IColorService.GetById(int colorId)
        {
            throw new NotImplementedException();
        }
    }
}
