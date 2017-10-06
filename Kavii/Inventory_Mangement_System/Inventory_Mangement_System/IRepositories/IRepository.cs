﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using System.Threading.Tasks;

namespace Inventory_Mangement_System.IRepositories
{
    public interface IRepository<TEntity> where TEntity : class
    {
        TEntity Get(long ID);
        IEnumerable<TEntity> GetAll();
        IEnumerable<TEntity> Search(Expression<Func<TEntity, bool>> Predicate);

        void Add(TEntity Entity);
        void AddRange(IEnumerable<TEntity> Entities);

        void Remove(TEntity Entity);
        void RemoveRange(IEnumerable<TEntity> Entities);

    }
}