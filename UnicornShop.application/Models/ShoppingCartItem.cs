namespace UnicornShop.Application.Models
{
    public class ShoppingCartItem
	{
		public virtual long? Id { get; protected internal set; }
        public virtual long? ProductId { get; protected internal set; }
		public virtual long? ProceId { get; protected internal set; }
		public virtual long? ShoppingCartId { get; protected internal set; }

		public virtual Products Product { get; protected internal set; }
		public virtual Price Price { get; protected internal set; }



    }
}

