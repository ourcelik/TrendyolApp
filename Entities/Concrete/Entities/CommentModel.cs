namespace Entities.Concrete.Entities
{
    public class CommentModel : IEntity
    {
        public int Id { get; set; }
        public string Comment { get; set; }
        public int UserId { get; set; }
    }
}
