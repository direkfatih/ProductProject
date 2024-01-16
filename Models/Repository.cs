using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProductProject.Models
{
    public static class Repository
    {
        private static readonly List<Product> _products = new();
        private static readonly List<Category> _categories = new();

        static Repository()
        {
            _categories.Add(new Category{
                CategoryId = 1,
                Name = "Telefon"
            });
            _categories.Add(new Category{
                CategoryId = 2,
                Name = "Bilgisayar"
            });  

            _products.Add(new Product{
                ProductId = 1,
                Name = "Iphone 13",
                Price = 40000,
                IsActive = true,
                Image = "1.jpg",
                CategoryId = 1
            });

            _products.Add(new Product{
                ProductId = 2,
                Name = "Iphone 14",
                Price = 50000,
                IsActive = true,
                Image = "2.jpg",
                CategoryId = 1
            });

            _products.Add(new Product{
                ProductId = 3,
                Name = "Iphone 15",
                Price = 60000,
                IsActive = true,
                Image = "3.jpg",
                CategoryId = 1
            });

            _products.Add(new Product{
                ProductId = 4,
                Name = "Iphone 16",
                Price = 80000,
                IsActive = true,
                Image = "4.jpg",
                CategoryId = 1
            });

            _products.Add(new Product{
                ProductId = 5,
                Name = "Macbook Pro M2 16",
                Price = 69000,
                IsActive = true,
                Image = "5.jpg",
                CategoryId = 2
            });

            _products.Add(new Product{
                ProductId = 5,
                Name = "Macbook Pro M3 16",
                Price = 90000,
                IsActive = true,
                Image = "6.jpg",
                CategoryId = 2
            });

        }

        

        public static List<Product> Products
        {
            get{
                return _products;
            }
        }

        public static List<Category> Categories
        {
        
            get{
                return _categories;
            }
        
        }

        public static void CreateProduct(Product entity)
        {
            _products.Add(entity);
        }

        public static void EditProduct(Product updatedProduct)
        {
            var entity = _products.FirstOrDefault(p => p.ProductId == updatedProduct.ProductId);
            if (entity != null)
            {
                entity.Name = updatedProduct.Name;
                entity.Price = updatedProduct.Price;
                entity.Image = updatedProduct.Image;
                entity.CategoryId = updatedProduct.CategoryId;
                entity.IsActive = updatedProduct.IsActive;
            }
        }

        public static void DeleteProduct(Product deletedProduct)
        {
            var entity = _products.FirstOrDefault( p => p.ProductId == deletedProduct.ProductId);

            if(entity != null)
            {
                _products.Remove(entity);
            }
        }

    }
}