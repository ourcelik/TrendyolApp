namespace Entities.Concrete.Entities
{
    public class Currency : IEntity
    {
        public int CurrenyId { get; set; }
        public string CurrencyType { get; set; }
    }
}
