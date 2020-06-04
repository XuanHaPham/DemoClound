using RetailAPI.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace RetailAPI.Models
{
    public class ProductViewModel
    {
        public int Id { get; set; } 
        public string Name { get; set; } 
        public double Price { get; set; } 
        public int? CategoryId { get; set; } 
        public string Brand { get; set; } 
        public string Description { get; set; } 
        public DateTime? TimeCreated { get; set; } 
        public string Creater { get; set; } 
        public bool? Status { get; set; }
        public ProductViewModel(Product product)
        {
            Id = product.Id;
            Name = product.Name;
            Price = product.Price;
            CategoryId = product.CategoryId;
            Brand = product.Brand;
            Description = product.Description;
            TimeCreated = product.TimeCreated;
            Creater = product.Creater;
            Status = product.Status;
        }
    }
}