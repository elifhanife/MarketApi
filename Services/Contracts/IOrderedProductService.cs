using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
	public interface IOrderedProductService
	{
		IEnumerable<OrderedProduct> GetOrderedProductsByCustomerId(int id, bool trackChanges);
		OrderedProduct GetOrderedProductsByOrderId(int id, bool trackChanges);
		OrderedProduct CreateOrderedProduct(OrderedProduct orderedProduct);
		void UpdateOrderedProduct(int id, OrderedProduct orderedProduct, bool trackChanges);
	}
}
