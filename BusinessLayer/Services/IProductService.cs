using BusinessLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessLayer.Services
{
    public interface IProductService
    {
        List<ProductDto> GetAll();
        ProductDto? GetById(int id);
        ProductDto Add(CreateProductDto dto);
        bool Update(int id, CreateProductDto dto);
        bool Delete(int id);
    }
}
