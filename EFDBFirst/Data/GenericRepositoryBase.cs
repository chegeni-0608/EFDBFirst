using EFDBFirst.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;

namespace EFDBFirst.Data
{
    public class GenericRepositoryBase : GenericRepositoryBaseBase2
    {
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
    }
}

