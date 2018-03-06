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
    public class SuppliersController : ApiController
    {
        ApplicationDbContext db = new ApplicationDbContext();

        //Get Suppliers admin/suppliers
        public IHttpActionResult GetSuppliers()
        {
            var suppliers = db.Suppliers
                .ToList()
                .Select(Mapper.Map<Supplier, SupplierDto>);         
            return Ok(suppliers);
        }

        //Get Supplier admin/suppliers/id
        public SupplierDto GetSupplier(int id)
        {
            var supplier = db.Suppliers.SingleOrDefault(s => s.Id == id);

            if (supplier == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            return Mapper.Map<Supplier, SupplierDto>(supplier);

        }

        //Post Supplier admin/suppliers/create
        [HttpPost]
        public IHttpActionResult CreateSupplier(SupplierDto supplierDto)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest();
            }

            var supplier = Mapper.Map<SupplierDto, Supplier>(supplierDto);

            db.Suppliers.Add(supplier);
            db.SaveChanges();

            supplierDto.Id = supplier.Id;

            return Created(new Uri(Request.RequestUri + "/" + supplier.Id), supplierDto);
        }

        //Put supplier admin/suppliers/id
        [HttpPut]
        public void PutSupplier(int id, SupplierDto supplierDto)
        {
            if (!ModelState.IsValid)
            {
               throw new HttpResponseException(HttpStatusCode.BadRequest);
            }

            var supplierInDb = db.Suppliers.SingleOrDefault(s => s.Id == id);

            if (supplierInDb == null)
            {
                throw new HttpResponseException(HttpStatusCode.NotFound);
            }

            Mapper.Map(supplierDto, supplierInDb);

            db.SaveChanges();
        }

        //Delete supplier admin/suppliers/id
        [HttpDelete]
        public void DeleteSupplier(int id)
        {
            if(!ModelState.IsValid)
                throw new HttpResponseException(HttpStatusCode.BadRequest);

            var supplier = db.Suppliers.SingleOrDefault(s => s.Id == id);

            if (supplier == null)
                throw new HttpResponseException(HttpStatusCode.NotFound);

            db.Suppliers.Remove(supplier);
            db.SaveChanges();
        }
    }
}
