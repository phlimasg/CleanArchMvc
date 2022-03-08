using CleanArchMvc.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Products.Queries
{
    public class GetproductByIdQuery : IRequest<Product>
    {
        public int Id { get; set; }
        public GetproductByIdQuery(int id)
        {
            Id = id;       
        }
    }
}
