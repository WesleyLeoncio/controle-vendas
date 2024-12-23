﻿using System.Linq.Expressions;

namespace controle_vendas.modules.common.repository.interfaces;

public interface IRepository<T>
{
    protected IQueryable<T> GetIQueryable();
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetAsync(Expression<Func<T, bool>> predicate);
    T Create(T entity);
    T Update(T entity);
    T Delete(T entity);
}