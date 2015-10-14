﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using System.Data;
using System.Linq.Expressions;

namespace BusinessLogic.Services
{
    using BusinessLogic.Models;

    public abstract class BaseService<T> where T : class
    {
        protected IDataContext dataContext;
        protected readonly IDbSet<T> dbset;

        protected BaseService(IDataContext dataContext)
        {
            this.dataContext = dataContext;
            dbset = dataContext.Set<T>();
        }

        public virtual void Add(T entity)
        {
            dbset.Add(entity);
            dataContext.SaveChanges();
        }

        public virtual void Update(T entity)
        {
            dbset.Attach(entity);
            dataContext.Entry(entity).State = System.Data.Entity.EntityState.Modified;

            dataContext.SaveChanges();
        }

        public virtual void Delete(T entity)
        {
            dbset.Remove(entity);

            dataContext.SaveChanges();
        }

        public virtual void Delete(Expression<Func<T, bool>> where)
        {
            IEnumerable<T> objects = dbset.Where<T>(where).AsEnumerable();

            foreach (T obj in objects)
                dbset.Remove(obj);

            dataContext.SaveChanges();
        }

        public virtual T GetById(long id)
        {
            return dbset.Find(id);
        }

        public virtual T GetById(string id)
        {
            return dbset.Find(id);
        }

        public virtual IEnumerable<T> GetAll()
        {
            return dbset.ToList();
        }

        public virtual IEnumerable<T> GetMany(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).ToList();
        }

        public T Get(Expression<Func<T, bool>> where)
        {
            return dbset.Where(where).FirstOrDefault<T>();
        }
    }
}
