namespace Entities.Concrete.Entities
{
    public class CartModel : IEntity
    {
        public ProductModel Product { get; set; }
        public int Count { get; set; }
    }
}
