using System;
using System.Collections.Generic;

namespace Entities.Concrete.Entities
{
    public class ProductModel : IEntity
    {
        
        public int ProductId { get; set; }
        public string Brand { get; set; }
        public string ProductName { get; set; }
        public string Description { get; set; }
        public List<PhotoModel> Photos { get; set; }
        public string Seller { get; set; }
        public string ProductInfo { get; set; }
        public List<CommentModel> Comments { get; set; }
        public decimal Price { get; set; }
        public Category Category { get; set; }
        public PhotoModel TopPhoto { get; set; }
        public DateTime DeliveryDate { get; set; }
        public Currency Currency { get; set; }

    }
}
