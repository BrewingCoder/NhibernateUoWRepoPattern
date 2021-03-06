﻿using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using NHibernate;

namespace BrewingCoder.NetCore.NHibernateUowRepo.Contracts
{
    public interface IRepository<T> where T : EntityBase
    {
        IEnumerable<T> GetAll();
        IQueryable<T> Query();
        IQueryOver<T> QueryOver();
        void Create(T entity);
        Task CreateAsync(T entity);
        void Update(T entity);
        Task UpdateAsync(T entity);
        void Delete(T entity);
        Task DeleteAsync(int id, CancellationToken cancellationToken = default(CancellationToken));
        void Delete(int id);
        T Get(int id);
        Task<T> GetAsync(int id);
    }
}
