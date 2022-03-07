using CleanArchMvc.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.DTOs
{
    public class ProductDTO
    {
        public int Id { get; set; }
        [Required]
        [MinLength(3)]
        [MaxLength(100)]
        public string Name { get; private set; }
        [Required]
        [MinLength(3)]
        [MaxLength(200)]
        public string Description { get; private set; }
        [Required]
        [Column(TypeName ="decimal(18,2)")]      
        [DisplayFormat(DataFormatString ="{0:c2}")]
        [DataType(DataType.Currency)]
        [DisplayName("Price")]
        public decimal Price { get; private set; }
        [Required]
        [Range(1, 999999)]
        public int Stock { get; private set; }        
        [MaxLength(200)]
        public string Image { get; private set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
