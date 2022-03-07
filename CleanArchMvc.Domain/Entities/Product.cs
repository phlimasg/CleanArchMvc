using CleanArchMvc.Domain.Validation;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Entities
{
    public sealed class Product : Entity
    {       
        
        public string Description { get; private set; }
        public decimal Price { get; private set; }
        public int Stock { get; private set; }        
        public string Image { get; private set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }

        public Product(string name, string description, decimal price, int stock, string image)
        {
            ValidateDomain(name, description, price, stock, image);
        }
        public Product(int id,string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.When(id < 0, "Id size small. Min. 3 chars.");            
            ValidateDomain(name, description, price, stock, image);
            Id = id;
        }
        public void Update(string name, string description, decimal price, int stock, string image, int categoryId)
        {
            ValidateDomain(name, description, price, stock, image);
            DomainExceptionValidation.When(categoryId < 0, "Category Id size small. Min. 3 chars.");
            CategoryId = categoryId;
        }
        private void ValidateDomain(string name, string description, decimal price, int stock, string image)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid Name.");
            DomainExceptionValidation.When(name.Length < 3, "Name size small. Min. 3 chars.");

            DomainExceptionValidation.When(string.IsNullOrEmpty(description), "Invalid description.");
            DomainExceptionValidation.When(description.Length < 3, "Invalid size small. Min. 3 chars.");
            
            DomainExceptionValidation.When(price < 0, "Price size small. Min. 3 chars.");
            DomainExceptionValidation.When(stock < 0, "Stock size small. Min. 3 chars.");

            DomainExceptionValidation.When(string.IsNullOrEmpty(image), "Invalid image.");
            DomainExceptionValidation.When(image?.Length < 3, "Image size small. Min. 3 chars.");


            Name = name;
            Description = description;
            Price = price;
            Stock = stock;
            Image = image;
        }


    }
}
