using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Data.Entity;
using AutoMapper;
using eCommerceFLANCO.Dto;
using eCommerceFLANCO.Models;
using Newtonsoft.Json;

namespace eCommerceFLANCO.Areas.Admin.Controllers.api
{
    public class CategoriesController : ApiController
    {
        ApplicationDbContext db = new ApplicationDbContext();

        //Get categories admin/api/categories
        public IHttpActionResult GetCategory()
        {
            var categoryDto = db.Categories
                .ToList()
                .Select(Mapper.Map<Category, CategoryDto>);
            return Ok(categoryDto);
        }

        //Get category admin/api/categories/1
        public CategoryDto GetCategory(int id)
        {
            var category = db.Categories.SingleOrDefault(c => c.Id == id);

            if (category == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return Mapper.Map<Category, CategoryDto>(category);
        }


        //Post admin/api/category
        [HttpPost]
        public IHttpActionResult CreateCategory(CategoryDto categoryDto)
        {
            if(!ModelState.IsValid)
                return BadRequest();

            var category = Mapper.Map<CategoryDto, Category>(categoryDto);

            db.Categories.Add(category);
            db.SaveChanges();

            categoryDto.Id = category.Id;

            return Created(new Uri(Request.RequestUri + "/" + category.Id), categoryDto);
        }


        //PUT admin/category/1
        [HttpPut]
        public void UpdateCategory(int id, CategoryDto categoryDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var categoryInDb = db.Categories.SingleOrDefault(c => c.Id == id);

            if(categoryInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(categoryDto, categoryInDb);

            db.SaveChanges();
        }



        //DELETE admin/category/1
        [HttpDelete]
        public void DeleteCategory(int id)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var categoryInDb = db.Categories.SingleOrDefault(c => c.Id == id);

            if (categoryInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            db.Categories.Remove(categoryInDb);
            db.SaveChanges();
        }

    }
}
