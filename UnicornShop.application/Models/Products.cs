using System;
namespace UnicornShop.Application.Models
{

    public class Products
	{
		public virtual long? Id { get; protected internal set; }
		public virtual string Name { get; protected internal set; }
		public virtual string Description { get; protected internal set; }
		public virtual Productstatus Status { get; protected internal set; }
		public virtual int Quantity { get; protected internal set; }
		public virtual string FileId { get; protected internal set; } //better to use string for image Id
		public virtual long? categoryId { get; protected internal set; }
		public virtual long? PriceId { get; protected internal set; }
        public virtual Category Category { get; protected internal set; }
        public virtual Price Price { get; protected internal set; }

		public void ChangePrice(Price price)
		{
			if(price is null)
			{
				throw new System.Exception("Price can't be null");
			}
			if (price == price)
			{

			}
		}

    }
}

