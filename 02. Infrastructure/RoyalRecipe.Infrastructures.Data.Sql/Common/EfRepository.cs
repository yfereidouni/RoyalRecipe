using RoyalRecipe.Core.Domain.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace RoyalRecipe.Infrastructures.Data.Sql.Common
{
    public class EfRepository<TEntity> : IRepository<TEntity> where TEntity : Entity, new()
    {
        private readonly RoyalRecipeDbContext royalRecipeDbContext;

        public EfRepository(RoyalRecipeDbContext royalRecipeDbContext)
        {
            this.royalRecipeDbContext = royalRecipeDbContext;
        }
        public bool Exists(Expression<Func<TEntity, bool>> expression)
        {
            return royalRecipeDbContext.Set<TEntity>().Any(expression);
        }

        public TEntity Get(Guid id)
        {
            return royalRecipeDbContext.Set<TEntity>().FirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return royalRecipeDbContext.Set<TEntity>().ToList();
        }

        public void Insert(TEntity entity)
        {
            royalRecipeDbContext.Set<TEntity>().Add(entity);
            //or
            //royalRecipeDbContext.Add(entity);
            royalRecipeDbContext.SaveChanges();
        }

        public void Remove(TEntity entity)
        {
            royalRecipeDbContext.Set<TEntity>().Remove(entity);
            royalRecipeDbContext.SaveChanges();
        }

        public void SaveChanges()
        {
            royalRecipeDbContext.SaveChanges();
        }

        public void Update(TEntity entity)
        {
            royalRecipeDbContext.Set<TEntity>().Update(entity);
        }
    }
}
