using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVC_CodeFirst.Repository
{
    public interface IProductRepository<T> where T:class
    {
        IEnumerable<T> GetAll();  //all products
        T GetById(object Id);  //for a particular product
        void Insert(T obj);
        void Update(T obj);
        void Delete(object Id);
        void Save();
    }
}
