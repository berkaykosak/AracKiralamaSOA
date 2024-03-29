﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using AracKiralama.DAL.Abstract;
using AracKiralama.DAL.EntityFramework;

namespace AracKiralama.Dal.Concrete.EntityFramework.Repository
{
    public abstract class EfGenelRepo<T> : IGenelRepo<T> where T : class
    {
        protected AracKiralamaSoaContext context;

        public T Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
            return entity;
        }

        public bool Delete(int id)
        {
            return Delete(Get(id));

        }

        public bool Delete(T entity)
        {
            context.Set<T>().Remove(entity);
            return context.SaveChanges() > 0;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool dispose)
        {
            if (dispose)
            {
                context.Dispose();
            }
        }

        public T Get(int id)
        {
            var entity = context.Set<T>().Find(id);

            context.Entry(entity).State = EntityState.Deleted;

            context.Entry(entity).State = EntityState.Modified;
            return entity;
        }

        public IQueryable<T> GetAll(System.Linq.Expressions.Expression<Func<T, bool>> predicate)
        {
            return context.Set<T>().Where(predicate).AsQueryable();
            //eturn context.Set<T>().AsNoTracking.tolist();
        }

        public List<T> GetAll()
        {
            // return context.Set<T>().AsNoTracking().ToList();
            return context.Set<T>().ToList();
        }

        public T Update(T entity)
        {
            context.Set<T>().AddOrUpdate(entity);//varsa güncelle yoksa ekle
            context.SaveChanges();
            return entity;
        }

        void IDisposable.Dispose()
        {
            throw new NotImplementedException();
        }

    }


}