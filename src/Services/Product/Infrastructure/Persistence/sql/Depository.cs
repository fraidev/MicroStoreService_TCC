using System;
using System.Linq;
using NHibernate;

namespace Product.Infrastructure.Persistence.sql
{
    public class Depository: IDepository
    {
        private readonly ISession _session;
        
        public Depository(ISession session)
        {
            _session = session;
        }
        
        public void Save<TEntity>(TEntity entity) where TEntity : class
        {
            _session.Save(entity);
        }

        public void Update(object entity)
        {
            _session.Update(entity);
        }

        public void SaveOrUpdate(object entity)
        {
            _session.SaveOrUpdate(entity);
        }

        public void Delete(object entity)
        {
            _session.Delete(entity);
        }

        public T GetById<T>(Guid id)
        {
            return _session.Get<T>(id);
        }
    }
}