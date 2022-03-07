using CleanArchMvc.Domain.Entities;
using FluentAssertions;
using System;
using Xunit;

namespace CleanArchMvc.Domain.Tests
{
    public class ProductUnitTest1
    {
        [Fact(DisplayName = "Create Category With Valid State")]
        public void CreateProduct_WithValidparameters_ResultObjValidStates()
        {
            Action action = () => new Product(1, "Noe","descricao do produto",9.99m, 99, "Url image");
            action.Should()
                .NotThrow<CleanArchMvc.Domain.Validation.DomainExceptionValidation>();
        }

        [Fact]
        public void CreateProduct_NegativeIdValue_DomainExceptionValidationId()
        {
            Action action = () => new Product(1, "Noe", "descricao do produto", 9.99m, 99, "Url image");
            action.Should()
                .Throw<CleanArchMvc.Domain.Validation.DomainExceptionValidation>()
                .WithMessage("Value invalid.");
        }
    }
}
