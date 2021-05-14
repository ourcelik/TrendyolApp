namespace TrendyolApp.Models
{
    public class SubSubCategory
    {
        public int SubSubCategoryId { get; set; }
        public string CategoryName { get; set; }
        public int SubCategoryId { get; set; }
        public int CategoryId { get; set; }
        public string Url { get; set; }
    }
}