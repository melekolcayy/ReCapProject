using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
   public class InMemoryProductDal:IProductDal
    {
        List<Product> _products;

        public InMemoryProductDal()
        {
            _products = new List<Product>
            {
                new Product{Id=1,ColorId="kırmızı",BrandId="1",DailyPrice=200,ModelYear=2021,Description="BMW"},
                new Product{Id=2,ColorId="siyah",BrandId="2",DailyPrice=1000,ModelYear=2020,Description="Porche"},
                new Product{Id=3,ColorId="mor",BrandId="3",DailyPrice=300,ModelYear=2019,Description="Mercedes"},
            };
        }
        public void Add(Product product)
        {
            _products.Add(product);
        }
        public void Delete(Product product)
        {
            Product productToDelete = productToDelete = _products.SingleOrDefault(p=> product.Id == product.Id);

            _products.Remove(productToDelete);
        }
        public List<Product> GetAll()
        {
            return _products;
        }
        public void Update(Product product)
        {
            Product productToUpdate = _products.SingleOrDefault(p=> product.Id == product.Id);
            productToUpdate.Id = product.Id;
            productToUpdate.BrandId = product.BrandId;
            productToUpdate.ColorId = product.ColorId;
            productToUpdate.ModelYear = product.ModelYear;
            productToUpdate.DailyPrice = product.DailyPrice;
            productToUpdate.Description = product.Description;

        }
        public List<Product> GetByCategory(int categoryId)
        {
            return _products.Where(p=>p.Id == categoryId).ToList();
        }

        public void Add(IProductDal product)
        {
            throw new NotImplementedException();
        }
    }
}
