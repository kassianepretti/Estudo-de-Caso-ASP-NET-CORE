using System;
using System.Collections.Generic;
using System.Linq.Expressions;

namespace SisRh.Domain.Base.Interfaces.Repositories
{
    public interface IRepositoryBase<TEntity> where TEntity : class
    {
        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>> match);
        TEntity Find(Expression<Func<TEntity, bool>> match);
        bool Exist(Predicate<TEntity> match);
        int Count(Expression<Func<TEntity, bool>> match);
        IEnumerable<object> GetListToSelect();
        IEnumerable<object> GetListToSelect(int id);
        IEnumerable<object> GetListToSelect(Expression<Func<TEntity, bool>> match);
        void Add(TEntity obj);
        void Add(TEntity obj, string auditKey);
        void AddRange(IEnumerable<TEntity> objs);
        void AddRange(IEnumerable<TEntity> objs, string auditKey);
        void Update(TEntity obj);
        void Update(TEntity obj, string auditKey);
        void Remove(TEntity obj);
        void Remove(TEntity obj, string auditKey);
        void Remove(int id);
        void Remove(int id, string auditKey);
        void RemoveRange(IEnumerable<TEntity> objs);
        void RemoveRange(IEnumerable<TEntity> objs, string auditKey);
        void Dispose();
    }
}
