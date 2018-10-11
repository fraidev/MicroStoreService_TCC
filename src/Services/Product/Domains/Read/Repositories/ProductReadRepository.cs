using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using NHibernate;
using Product.Domains.Read.Models;
using Product.Infrastructure;
using Product.Infrastructure.Persistence.sql;

namespace Product.Domains.Read.Repositories
{
    public class ProductReadRepository
    {
        private readonly IDepository _depository;
        
        public ProductReadRepository(IDepository depository)
        {
            /*List<ProductModel> usuarios;

            var sessionFactory =  ;
            using (ISession session = sessionFactory.OpenSession())  // Open a session to conect to the database
            {
                usuarios = session.Query<Usuario>().ToList(); //  Querying to get all the books
            }
            return _unitOfWork.Query<RoleMappingModel>().FirstOrDefault(x => x.Id == id && x.Deleted == false); */
            
            _depository = depository;
                //var depository = new Depository(NHibernateHelper.CreateSessionFactory().OpenSession());
        }
            
        public ProductModel GetById(Guid id)
        {
            return _depository.GetById<ProductModel>(id);
        }
    }
}