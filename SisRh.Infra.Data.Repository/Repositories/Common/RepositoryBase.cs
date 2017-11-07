using Microsoft.EntityFrameworkCore;
using SisRh.Domain.Base.Interfaces.Repositories;
using SisRh.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;

namespace SisRh.Infra.Data.Repository.Repositories.Common
{
    public class RepositoryBase<TEntity> : IRepositoryBase<TEntity> where TEntity : class
    {
        protected readonly SisRhContext _dt;

        public RepositoryBase(SisRhContext dt)
        {
            _dt = dt;
        }

        public virtual void Add(TEntity obj)
        {
            _dt.Set<TEntity>().Add(obj);
            _dt.SaveChanges();
        }

        public virtual void Add(TEntity obj, string auditKey)
        {
            throw new NotImplementedException();
        }

        public virtual void AddRange(IEnumerable<TEntity> objs)
        {
            throw new NotImplementedException();
        }

        public virtual void AddRange(IEnumerable<TEntity> objs, string auditKey)
        {
            throw new NotImplementedException();
        }

        public virtual int Count(Expression<Func<TEntity, bool>> match)
        {
            throw new NotImplementedException();
        }

        public virtual void Dispose()
        {
            throw new NotImplementedException();
        }

        public virtual bool Exist(Predicate<TEntity> match)
        {
            throw new NotImplementedException();
        }

        public virtual TEntity Find(Expression<Func<TEntity, bool>> match)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>> match)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<TEntity> GetAll()
        {
            return _dt.Set<TEntity>().AsNoTracking().ToList();
        }

        public virtual TEntity GetById(int id)
        {
            return _dt.Set<TEntity>().Find(id);
        }

        public virtual IEnumerable<object> GetListToSelect()
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<object> GetListToSelect(int id)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<object> GetListToSelect(Expression<Func<TEntity, bool>> match)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(TEntity obj)
        {
            _dt.Set<TEntity>().Remove(obj);
            _dt.SaveChanges();
        }

        public virtual void Remove(TEntity obj, string auditKey)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public virtual void Remove(int id, string auditKey)
        {
            throw new NotImplementedException();
        }

        public virtual void RemoveRange(IEnumerable<TEntity> objs)
        {
            throw new NotImplementedException();
        }

        public virtual void RemoveRange(IEnumerable<TEntity> objs, string auditKey)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(TEntity obj)
        {
            var original = this.GetById(Convert.ToInt32(obj.GetType().GetProperty("Codigo").GetValue(obj)));
            _dt.Entry(original).CurrentValues.SetValues(obj);
            _dt.SaveChanges();
        }

        public virtual void Update(TEntity obj, string auditKey)
        {
            throw new NotImplementedException();
        }
    }
}
