namespace Entities.Concrete.Entities
{
    public class Cart : IEntity
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        public int Count { get; set; }
        public Product Product { get; set; }
    }
}
