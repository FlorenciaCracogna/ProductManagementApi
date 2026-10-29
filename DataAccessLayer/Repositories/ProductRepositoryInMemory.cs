using DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.Repositories
{
    public class ProductRepositoryInMemory : IProductRepository
    {
        private static List<Product> _products = new List<Product>
        {
            new Product { Id = 1, Name = "Notebook Lenovo", Price = 850000.00m, Category = "Electrónica", IsActive = true },
            new Product { Id = 2, Name = "Mouse inalámbrico", Price = 15999.99m, Category = "Electrónica", IsActive = true },
            new Product { Id = 3, Name = "Silla de oficina", Price = 120500.50m, Category = "Muebles", IsActive = true },
            new Product { Id = 4, Name = "Escritorio de madera", Price = 230000.00m, Category = "Muebles", IsActive = false }
        };
        public Product Add(Product product)
        {
            if (_products.Count == 0)
            {
                product.Id = 1;
            }
            else
            {
                product.Id = _products.Max(p => p.Id) + 1;
            }
            _products.Add(product);
            return product;
        }

        public bool Delete(int id)
        {
            var existing = _products.FirstOrDefault(p => p.Id == id);
            if (existing == null)
            {
                return false;
            }
                _products.Remove(existing);
                return true;
        }

        public List<Product> GetAll()
        {
            return _products.ToList();
        }

        public Product? GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }

        public bool Update(Product product)
        {
            var existing = _products.FirstOrDefault(p => p.Id == product.Id);
            if (existing == null)
            {
                return false;
            }
                existing.Name = product.Name;
                existing.Price = product.Price;
                existing.Category = product.Category;
                existing.IsActive = product.IsActive;
                return true;
        }
    }
}
