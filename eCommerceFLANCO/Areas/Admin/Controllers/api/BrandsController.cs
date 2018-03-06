using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AutoMapper;
using eCommerceFLANCO.Dto;
using eCommerceFLANCO.Models;

namespace eCommerceFLANCO.Areas.Admin.Controllers.api
{
    public class BrandsController : ApiController
    {
        ApplicationDbContext db = new ApplicationDbContext();

        //GET brands list
        public IHttpActionResult GetBrands()
        {
            var brands = db.Brands
                .ToList()
                .Select(Mapper.Map<Brand, BrandDto>);

            return Ok(brands);

        }

        //GET brand details
        public BrandDto GetBrand(int id)
        {
            var brand = db.Brands.SingleOrDefault(b => b.Id == id);

            if (brand == null)
            {
               throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return Mapper.Map<Brand, BrandDto>(brand);
        }


        //Post brand
        [HttpPost]
        public IHttpActionResult CreateBrand(BrandDto brandDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var brand = Mapper.Map<BrandDto, Brand>(brandDto);

            db.Brands.Add(brand);
            db.SaveChanges();

            brandDto.Id = brand.Id;

            return Created(new Uri(Request.RequestUri + "/" + brand.Id), brandDto);
        }

        //PUT admin/category/1
        [HttpPut]
        public void UpdateBrand(int id, BrandDto brandDto)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var brandInDb = db.Brands.SingleOrDefault(c => c.Id == id);

            if (brandInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            Mapper.Map(brandDto, brandInDb);

            db.SaveChanges();
        }



        //DELETE admin/category/1
        [HttpDelete]
        public void DeleteBrand(int id)
        {
            if (!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var brandInDb = db.Brands.SingleOrDefault(b => b.Id == id);

            if (brandInDb == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);
            db.Brands.Remove(brandInDb);
            db.SaveChanges();
        }

    }
}
