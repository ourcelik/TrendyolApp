namespace Entities.Concrete.Entities
{
    public class SubCategory : IEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }

}
