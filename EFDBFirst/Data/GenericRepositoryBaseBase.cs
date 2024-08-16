﻿using EFDBFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace EFDBFirst.Data
{
    public class GenericRepositoryBaseBase
    {
        CsharpSampleDBEntities _Context = null;
        DbSet<T> table = null;

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




            public T GetById(object id)
            {
                return table.Find(id);
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
            return (query);

        }
    }
}