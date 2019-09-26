using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using Agca.ECommerce.Core.Entities;
using Agca.ECommerce.DataAccess.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Agca.ECommerce.Core.DataAccess.EntityFramework
{

    public class EfEntityRepositoryBase<TEntity, TContext> : IEntityRepository<TEntity>
     where TEntity : class, IEntity, new()
     where TContext : DbContext, new()

    {
        public void Add(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Add<TEntity>(entity);
                context.SaveChanges();
            }
        }

        public void Delete(TEntity entity)
        {
            using (var context = new TContext())
            {

                context.Remove<TEntity>(entity);
                context.SaveChanges();
            }
        }

        public TEntity Get(Expression<Func<TEntity, bool>> filter)
        {
            using (var context = new TContext())
            {
                return context.Set<TEntity>().SingleOrDefault(filter);
            }
        }

        public List<TEntity> GetList(Expression<Func<TEntity, bool>> filter = null)
        {
            using (var context = new TContext())
            {
                return filter == null
                    ? context.Set<TEntity>().ToList()
                    : context.Set<TEntity>().Where(filter).ToList();
            }
        }

        public void Update(TEntity entity)
        {
            using (var context = new TContext())
            {
                context.Update<TEntity>(entity);
                context.SaveChanges();
            }
        }


        public IEnumerable<TEntity> GetWithAllNavigations(Expression<Func<TEntity, bool>> predicate = null)
        {

            using (var context = new TContext())
            {
                var query = context.Set<TEntity>()
                 .Include(context.GetIncludePaths(typeof(TEntity)));
                if (predicate != null)
                    query = query.Where(predicate);
                return query.ToList();
            }

            
        }

    }

}
