﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Abp.Dependency;
using Abp.Linq;
using Microsoft.EntityFrameworkCore;

namespace Abp.EntityFrameworkCore.Linq
{
    public class EfCoreAsyncQueryableExecuter : IAsyncQueryableExecuter, ISingletonDependency
    {
        public Task<int> CountAsync<T>(IQueryable<T> queryable)
        {
            return queryable.CountAsync();
        }

        public int Count<T>(IQueryable<T> queryable)
        {
            return queryable.Count();
        }

        public Task<List<T>> ToListAsync<T>(IQueryable<T> queryable)
        {
            return queryable.ToListAsync();
        }

        public List<T> ToList<T>(IQueryable<T> queryable)
        {
            return queryable.ToList();
        }

        public Task<T> FirstOrDefaultAsync<T>(IQueryable<T> queryable)
        {
            return queryable.FirstOrDefaultAsync();
        }

        public T FirstOrDefault<T>(IQueryable<T> queryable)
        {
            return queryable.FirstOrDefault();
        }
    }
}
