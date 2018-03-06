using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using AutoMapper;
using eCommerceFLANCO.Dto;
using eCommerceFLANCO.Models;

namespace eCommerceFLANCO.App_Start
{
    public class MappingProfile:Profile
    {

        public MappingProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();
            CreateMap<Product, ProductDto>();
            CreateMap<ProductDto, Product>();
            CreateMap<Supplier, SupplierDto>();
            CreateMap<SupplierDto, Supplier>();
            CreateMap<CategoryDto, CategoryDto>();
            CreateMap<Brand, BrandDto>();
            CreateMap<BrandDto, Brand>();

        }
    }
}