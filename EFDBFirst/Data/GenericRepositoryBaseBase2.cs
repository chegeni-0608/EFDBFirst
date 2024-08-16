using EFDBFirst.Models;
using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace EFDBFirst.Data
{
    public class GenericRepositoryBaseBase2
    {
        CsharpSampleDBEntities _Context = null;

        public IQueryable<T> GetAsQueryable(
            Expression<Func<T, bool>> predicate = null, //where
            Func<IQueryable<T>, IOrderedQueryable<T>> orderBy = null, //orderby
            string includes = null, int? currentPage = null, int pageItemCount = 10)

        {

            IQueryable<T> query = _Context.Set<T>();
            if (predicate != null)
            {
                query = query.Where(predicate);
            }

            if (orderBy != null)
            {
                query = orderBy(query);
            }

            if (includes != null)
            {
                var array = includes.Split(',');
                foreach (var item in array)
                {
                    query = query.Include(item);
                }
            }

            return (query);

        }
    }
}