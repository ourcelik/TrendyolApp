using System.ComponentModel.DataAnnotations.Schema;

namespace Entities.Concrete.Entities
{
    public class Photo : IEntity
    {
        public int Id { get; set; }
        public string Url { get; set; }
        public int ProductId { get; set; }
        [NotMapped]
        public Product Product { get; set; }
    }
}
