﻿using Portal.Domain.Entities;
using Portal.Domain.Interfaces;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Data.Entity;

namespace Portal.Domain.Repositorio
{
    public class Repositorio<T> : IRepositorio<T>, IDisposable where T : class
    {
        private Contexto Context;
        protected Repositorio()
        {
            Context = new Contexto();
        }
        public IQueryable<T> GetTodos()
        {
            return Context.Set<T>();
        }
        public IQueryable<T> Get(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().Where(predicate);
        }
        public T Procurar(params object[] key)
        {
            return Context.Set<T>().Find(key);
        }
        public T Primeiro(Expression<Func<T, bool>> predicate)
        {
            return Context.Set<T>().Where(predicate).FirstOrDefault();
        }
        public void Adicionar(T entity)
        {
            Context.Set<T>().Add(entity);
        }
        public void Atualizar(T entity)
        {
            Context.Entry(entity).State = EntityState.Modified;
        }
        public void Deletar(Func<T, bool> predicate)
        {
            Context.Set<T>()
           .Where(predicate).ToList()
           .ForEach(del => Context.Set<T>().Remove(del));
        }
        public void Commit()
        {
            Context.SaveChanges();
        }
        public void Dispose()
        {
            if (Context != null)
            {
                Context.Dispose();
            }
            GC.SuppressFinalize(this);
        }
    }
}
