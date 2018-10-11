using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using NHibernate;

namespace Product.Infrastructure.Persistence.sql
{
    public interface IDepository
    {
        void Save<TEntity>(TEntity entity) where TEntity : class;
        /*TEntity Merge<TEntity>(TEntity entity) where TEntity : class; */
        void Update(object entity);
        void SaveOrUpdate(object entity);
        void Delete(object entity);
        /* void Delete(params object[] entities);
         void Clear();
         void Flush(); */
         T GetById<T>(Guid id);
         //IQueryable<T> Query<T>();
         /* ISQLQuery CreateSqlQuery(string sql);
          IQuery GetNamedQuery(string namedQuery);
          object Get(Type type, object id);
          IList List(Type t);
          bool Contains(object entity);
          bool IsMapped(Type type);*/
    }
}