using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using SisRh.Domain.Core.Interfaces.Services;
using SisRh.Domain.Core.Interfaces.Repositories;
using SisRh.Domain.Core.Util;

namespace SisRh.Domain.Core.Service
{
    public class ServiceBase<TEntity> : IServiceBase<TEntity> where TEntity : class
    {
        private readonly IRepositoryBase<TEntity> _repository;
        private List<MensagemValidation> _listaMensagensValidacao;

        public ServiceBase(IRepositoryBase<TEntity> repository)
        {
            _repository = repository;
            this._listaMensagensValidacao = new List<MensagemValidation>();
        }

        public bool TemMensagemValidacao()
        {
            return this._listaMensagensValidacao.Count != 0;
        }

        public void AddMensagem(string campo, string mensagem)
        {
            this._listaMensagensValidacao.Add(MensagemValidation.GetObjeto(campo, mensagem));
        }

        public List<MensagemValidation> GetListaMensagensValidation()
        {
            return this._listaMensagensValidacao;
        }

        public void Add(TEntity obj)
        {
            _repository.Add(obj);
        }

        public void Add(TEntity obj, string auditKey)
        {
            _repository.Add(obj, auditKey);
        }

        public void AddRange(IEnumerable<TEntity> objs)
        {
            _repository.AddRange(objs);
        }

        public void AddRange(IEnumerable<TEntity> objs, string auditKey)
        {
            _repository.AddRange(objs, auditKey);
        }

        public int Count(Expression<Func<TEntity, bool>> match)
        {
            return _repository.Count(match);
        }

        public void Dispose()
        {
            _repository.Dispose();
        }

        public bool Exist(Predicate<TEntity> match)
        {
            return _repository.Exist(match);
        }

        public TEntity Find(Expression<Func<TEntity, bool>> match)
        {
            return _repository.Find(match);
        }

        public IEnumerable<TEntity> FindAll(Expression<Func<TEntity, bool>> match)
        {
            return _repository.FindAll(match);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _repository.GetAll();
        }

        public TEntity GetById(int id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<object> GetListToSelect()
        {
            return _repository.GetListToSelect();
        }

        public IEnumerable<object> GetListToSelect(int id)
        {
            return _repository.GetListToSelect(id);
        }

        public IEnumerable<object> GetListToSelect(Expression<Func<TEntity, bool>> match)
        {
            return _repository.GetListToSelect(match);
        }

        public void Remove(TEntity obj)
        {
            _repository.Remove(obj);
        }

        public void Remove(TEntity obj, string auditKey)
        {
            _repository.Remove(obj, auditKey);
        }

        public void Remove(int id)
        {
            _repository.Remove(id);
        }

        public void Remove(int id, string auditKey)
        {
            _repository.Remove(id, auditKey);
        }

        public void RemoveRange(IEnumerable<TEntity> objs)
        {
            _repository.RemoveRange(objs);
        }

        public void RemoveRange(IEnumerable<TEntity> objs, string auditKey)
        {
            _repository.RemoveRange(objs, auditKey);
        }

        public void Update(TEntity obj)
        {
            _repository.Update(obj);
        }

        public void Update(TEntity obj, string auditKey)
        {
            _repository.Update(obj, auditKey);
        }
    }
}
