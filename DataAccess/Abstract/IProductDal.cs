using System;
using System.Collections.Generic;
using System.Text;
using Entities.Concrete;

namespace DataAccess.Abstract
{
    public interface IProductDal
    {
        List<Product> GetAll();
        void Add(IProductDal product);
        void Update(Product product);
        void Delete(Product product);

        List<Product> GetByCategory(int categoryId);
    }
}
