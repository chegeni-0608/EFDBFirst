using EFDBFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace EFDBFirst.Data
{
    public class GenericRepository<T> where T : class
    {
        CsharpSampleDBEntities _Context = null;
        DbSet<T> table = null;

        public GenericRepository()
        {
            this._Context = new CsharpSampleDBEntities();
            table = _Context.Set<T>();
        }

        public void Insert(T t)
        {
            table.Add(t);
            _Context.SaveChanges();
        }

        public void Update(T t)
        {
            table.Attach(t);
            _Context.Entry(t).State = EntityState.Modified;
            _Context.SaveChanges();
        }

        public void Delete(object id)
        {
            T exiting = table.Find(id);
            table.Remove(exiting);
            _Context.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return table.ToList();
        }

        public T GetById(object id)
        {
            return table.Find(id);
        }

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

            if (currentPage != null)
            {
                int skipCount = (currentPage.Value - 1) * pageItemCount;
                query = query.Skip(skipCount).Take(pageItemCount);
            }
           
            return query;

        }
    }

}