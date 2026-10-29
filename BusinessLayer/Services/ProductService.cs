using BusinessLayer.DTOs;
using System;
using System.Collections.Generic;
using System.Text;
using DataAccessLayer.Repositories;
using DataAccessLayer.Models;

namespace BusinessLayer.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        private ProductDto MapToDto(Product product)
        {
            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price,
                Category = product.Category,
                IsActive = product.IsActive
            };
        }
        public List<ProductDto> GetAll()
        {
            var products = _productRepository.GetAll();
            var productDtos = products.Select(p => MapToDto(p)).ToList();
            return productDtos;
        }

        public ProductDto? GetById(int id)
        {
            var product = _productRepository.GetById(id);
            if (product == null)
            {
                return null;
            }
            return MapToDto(product);
        }

        public ProductDto Add(CreateProductDto dto)
        {
            var product = new Product
            {
                Name = dto.Name,
                Price = dto.Price,
                Category = dto.Category,
                IsActive = true
            };
            _productRepository.Add(product);
            return MapToDto(product);
        }

        public bool Update(int id, CreateProductDto dto)
        {
            var existing = _productRepository.GetById(id);
            if (existing == null)
            {
                return false;
            }
            var product = new Product
            {
                Id = id,
                Name = dto.Name,
                Price = dto.Price,
                Category = dto.Category,
                IsActive = existing.IsActive
            };
            _productRepository.Update(product);
            return true;
        }

        public bool Delete(int id)
        {
            return _productRepository.Delete(id);
        }
    }
}
