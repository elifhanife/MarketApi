using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
	public interface IOrderedProductRepository : IRepositoryBase<OrderedProduct>
	{
		IQueryable<OrderedProduct> GetOrderedProductsByCustomerId(int id, bool trackChanges);
		OrderedProduct GetOrderedProductsByOrderId(int id, bool trackChanges);
		void CreateOrderedProduct(OrderedProduct orderedProduct);
		void UpdateOrderedProduct(OrderedProduct orderedProduct);

	}
}
