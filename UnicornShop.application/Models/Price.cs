namespace UnicornShop.Application.Models
{
    public class Price
	{
		public virtual long? Id { get; protected internal set; }
		public virtual decimal Amount { get; protected internal set; }
		public virtual string Currency { get; protected internal set; }
		public virtual Products Product { get; protected internal set; }
	}
}

