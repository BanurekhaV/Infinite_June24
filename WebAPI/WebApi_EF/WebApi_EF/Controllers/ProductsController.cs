using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using WebApi_EF.Models;

namespace WebApi_EF.Controllers
{
    public class ProductsController : ApiController
    {
        private InfiniteDBEntities db = new InfiniteDBEntities();

        // GET: api/Products
        public IQueryable<Product> GetProducts()
        {
            return db.Products;
        }

        // GET: api/Products/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult GetProduct(int id)
        {
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            return Ok(product);
        }

        // PUT: api/Products/5
        [ResponseType(typeof(void))]
        public IHttpActionResult PutProduct(Product product)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            //if (id != product.productId)
            //{
            //    return BadRequest();
            //}

            db.Entry(product).State = EntityState.Modified;

            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                //if (!ProductExists(id))
                //{
                    return NotFound();
                //}
                //else
                //{
                //    throw;
                //}
            }

            return StatusCode(HttpStatusCode.NoContent);
        }

        //// POST: api/Products
        //[ResponseType(typeof(Product))]
        //public IHttpActionResult PostProduct(Product product)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest("Validation Failed");
        //    }

        //    db.Products.Add(product);

        //    try
        //    {
        //        db.SaveChanges();
        //    }
        //    catch (DbUpdateException)
        //    {
        //        if (ProductExists(product.productId))
        //        {
        //            return Conflict();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return CreatedAtRoute("DefaultApi", new { id = product.productId }, product);
        //}
        [HttpPost]
        public IHttpActionResult PostNewProduct([FromBody]Product p)
        {
            if(!ModelState.IsValid)
            {
                return BadRequest("validations Failed");
            }
            db.Products.Add(new Product()
            {
                productId=p.productId,
                Productname=p.Productname,
                Price=p.Price,
                QuantityAvailable = p.QuantityAvailable,
            });
            db.SaveChanges();
            return Ok("Success");
        }

        // DELETE: api/Products/5
        [ResponseType(typeof(Product))]
        public IHttpActionResult DeleteProduct(int id)
        {
            Product product = db.Products.Find(id);
            if (product == null)
            {
                return NotFound();
            }

            db.Products.Remove(product);
            db.SaveChanges();

            return Ok(product);
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }

        private bool ProductExists(int id)
        {
            return db.Products.Count(e => e.productId == id) > 0;
        }
    }
}