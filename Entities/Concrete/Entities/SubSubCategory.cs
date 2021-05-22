namespace Entities.Concrete.Entities
{
    public class SubSubCategory : IEntity
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public int SubCategoryId { get; set; }
        public int CategoryId { get; set; }
        public string Url { get; set; }
        public SubCategory SubCategory { get; set; }
        public Category Category { get; set; }
    }

}
