using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using RealTimeProducts.Models;
using AutoMapper;

namespace RealTimeProducts.Controllers.API
{
    public class ProductController : ApiController
    {
        private ApplicationDbContext _context;

        public ProductController()
        {
            _context = new ApplicationDbContext();
        }

        //Get /API/Products
        public IEnumerable<Product> GetProducts()
        {
            return _context.Products.ToList();
        }

        //GET /API/Products/1
        public Product GetProduct(int id)
        {
            var product = _context.Products.SingleOrDefault(p => p.Id == id);

            if (product == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);


            return product;
        }

        //POST /API/Products
        [HttpPost]
        public Product CreateProduct(Product product)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            _context.Products.Add(product);
            _context.SaveChanges();
            return product;
        }

        //PUT /API/Products/1
        [HttpPut]
        public void UpdateProduct(int id, Product product)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var productInDB = _context.Products.SingleOrDefault(p => p.Id == id);

            if (productInDB == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            productInDB.Name = product.Name;
            productInDB.Imagen = product.Imagen;
            productInDB.Description = product.Description;
            productInDB.Price = product.Price;
            productInDB.DateAdded = product.DateAdded;
            productInDB.Stock = product.Stock;

            _context.SaveChanges();
        }

        // DELETE /API/Products/1
        public void DeleteProduct(int id)
        {
            var productInDB = _context.Products.SingleOrDefault(p => p.Id == id);

            if (productInDB == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            _context.Products.Remove(productInDB);
            _context.SaveChanges();

        }
    }
}
