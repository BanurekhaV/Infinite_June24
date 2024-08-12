using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVC_CodeFirst.Models;
using System.Data.Entity;

namespace MVC_CodeFirst.Repository
{
    public class ProductRepository<T> : IProductRepository<T> where T : class
    {
        ProductsContext db;
        DbSet<T> dbset;
        public ProductRepository()
        {
            db = new ProductsContext();
            dbset = db.Set<T>();
        }
        public void Delete(object Id)
        {
            // Products p = db.Product.Find(Id);
           // db.Product.Remove(p);
            T getmodel = dbset.Find(Id);           
            dbset.Remove(getmodel);
        }

        public IEnumerable<T> GetAll()
        {
            return dbset.ToList();
        }

        public T GetById(object Id)
        {
            return dbset.Find(Id);
        }

        public void Insert(T obj)
        {
            dbset.Add(obj);
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(T obj)
        {
            db.Entry(obj).State = EntityState.Modified;
        }
    }

}