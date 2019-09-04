﻿using System;
using System.Linq;
using System.Linq.Expressions;

namespace Portal.Domain.Repository.Interfaces
{
    public interface IRepository<T> where T : class
    {
        IQueryable<T> GetTodos();
        IQueryable<T> Get(Expression<Func<T, bool>> predicate);
        T Procurar(params object[] key);
        T Primeiro(Expression<Func<T, bool>> predicate);
        void Adicionar(T entity);
        void Atualizar(T entity);
        void Deletar(Func<T, bool> predicate);
        void Commit();
        void Dispose();
    }
}
