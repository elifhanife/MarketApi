using Entities.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
	public class OrderedProductRepository : RepositoryBase<OrderedProduct>, IOrderedProductRepository
	{
		public OrderedProductRepository(RepositoryContext context) : base(context)
		{
		}

		public void CreateOrderedProduct(OrderedProduct orderedProduct) => Create(orderedProduct);

		public IQueryable<OrderedProduct> GetOrderedProductsByCustomerId(int id, bool trackChanges) =>
			FindByCondition(o => o.CustomerId.Equals(id), trackChanges);
		public OrderedProduct GetOrderedProductsByOrderId(int id, bool trackChanges) =>
			FindByCondition(o =>o.OrderId.Equals(id), trackChanges)
			.SingleOrDefault();

		public void UpdateOrderedProduct(OrderedProduct orderedProduct) => Update(orderedProduct);
	}
}
