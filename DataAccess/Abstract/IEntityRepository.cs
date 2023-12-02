﻿using Entities.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
        //T çalışacağımız tip
    {

        //Filtreler yazmamızı sağlar
        List<T> GetAll(Expression<Func<T, bool>> filter = null);

        T Get(Expression<Func<T, bool>> filter);

        //List<T> GetById(int CarId);-->Buna ihtiyaç yok
        //Arabaları CarId göre filtrele


        void Add(T entity);

        void Update(T entity);

        void Delete(T entity);
    }
}