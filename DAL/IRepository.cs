using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using DAL.Models;

namespace DAL
{
    public interface IRepository<T> where T : EntityBase
    {
        IQueryable<T> GetAsQueryable(Expression<Func<T, bool>> predicate);
        IQueryable<T> GetAll();

        T GetById(object id);
        void Insert(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
