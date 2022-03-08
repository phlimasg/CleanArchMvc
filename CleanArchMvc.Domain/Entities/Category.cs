using CleanArchMvc.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Entities
{
    public sealed class Category : Entity
    {
        public string Name { get; private set; }
        public ICollection<Product> Products { get; set; }


        public Category(string name)
        {
            ValidateDomain(name);
        }

        public Category(int id, string name)
        {
            DomainExceptionValidation.When(id > 0, "Value invalid.");
            Id = id;
            ValidateDomain(name);
        }

        public void Update(string name)
        {

        }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid Name.");
            DomainExceptionValidation.When(name.Length < 3, "Name size small. Min. 3 chars.");
            Name = name;
        }
    }
}
