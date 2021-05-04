namespace Entities.Concrete.Entities
{
    public class Currency : IEntity
    {
        public int Id { get; set; }
        public string CurrencyType { get; set; }
    }
}
