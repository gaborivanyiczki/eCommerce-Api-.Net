using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using eCommerceFLANCO.Dto;
using eCommerceFLANCO.Models;

namespace eCommerceFLANCO.Areas.Admin.Controllers.api
{
    public class ProductsController : ApiController
    {
        ApplicationDbContext db = new ApplicationDbContext();

        //Get products list admin/products
        public IHttpActionResult GetProducts()
        {
            var productsDto = db.Products
                .Include(p => p.Category)
                .Include(s => s.Supplier)
                .Include(b => b.Brand)
                .ToList()
                .Select(Mapper.Map<Product, ProductDto>);
            return Ok(productsDto);
        }

        //Get product details admin/products/id
        public ProductDto GetProduct(int id)
        {
            var product = db.Products.SingleOrDefault(p => p.Id == id);
            if (product == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }
            return Mapper.Map<Product, ProductDto>(product);
        }

        //Post product admin/products
        public IHttpActionResult CreateProduct(ProductDto productDto)
        {
            if (!ModelState.IsValid)
                return BadRequest();
            var product = Mapper.Map<ProductDto, Product>(productDto);
            db.Products.Add(product);
            db.SaveChanges();

            productDto.Id = product.Id;

            return Created(new Uri(Request.RequestUri + "/" + product.Id), productDto);

        }

        //PUT admin/products/1
        [HttpPut]
        public void UpdateProduct(int id, ProductDto productDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var productInDb = db.Products.SingleOrDefault(c => c.Id == id);

            if (productInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(productDto, productInDb);

            db.SaveChanges();
        }

        //DELETE product admin/products/id
        [HttpDelete]
        public void DeleteProduct(int id)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);
            var productInDB = db.Products.SingleOrDefault(p => p.Id == id);

            if(productInDB == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            db.Products.Remove(productInDB);
            db.SaveChanges();

        }
    }
}
