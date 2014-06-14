using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using DomainLayer;

namespace Repository
{
    public class GenericRepository<TItem> : IRepository<TItem> where TItem : class
    {
        private readonly IContext _context;

        public GenericRepository(IContext context)
        {
            this._context = context;
        }

        public virtual void Add(TItem entity)
        {
            this._context.Add(entity);
        }

        public virtual void Delete(TItem entity)
        {
            this._context.Remove(entity);
        }

        public virtual void Update(TItem entity)
        {
            this._context.Update(entity);
        }

        public IEnumerable<TItem> Find(Expression<Func<TItem, bool>> predicate)
        {
            return this._context.Find(predicate);
        }
    }
}

  
