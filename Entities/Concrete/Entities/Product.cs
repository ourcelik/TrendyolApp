using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete.Entities
{
    public class Product : IEntity
    {

        public int Id { get; set; }
        public string Brand { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public string Seller { get; set; }
        public string ProductInfo { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public int TopPhotoId { get; set; }
        public int CurrencyId { get; set; }
        public int SubCategoryId { get; set; }
        public int SubSubCategoryId { get; set; }
        public Category Category { get; set; }
        [NotMapped]
        public Photo TopPhoto { get; set; }
        public Currency Currency { get; set; }
        public List<Photo> Photos { get; set; }
        public SubCategory SubCategory { get; set; }
        public SubSubCategory SubSubCategory { get; set; }
    }

}
