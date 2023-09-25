using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
	public class OrderedProductManager : IOrderedProductService
	{
		public readonly IRepositoryManager _manager;

		public OrderedProductManager(IRepositoryManager manager)
		{
			_manager = manager;
		}

		public OrderedProduct CreateOrderedProduct(OrderedProduct orderedProduct)
		{
			if (orderedProduct is null)
				throw new ArgumentNullException(nameof(orderedProduct));

			_manager.OrderedProduct.CreateOrderedProduct(orderedProduct);
			_manager.Save();

			return orderedProduct;
		}

		public IEnumerable<OrderedProduct> GetOrderedProductsByCustomerId(int id, bool trackChanges)
		{
			return _manager.OrderedProduct.GetOrderedProductsByCustomerId(id, trackChanges);
		}

		public OrderedProduct GetOrderedProductsByOrderId(int id, bool trackChanges)
		{
			return _manager.OrderedProduct.GetOrderedProductsByOrderId(id, trackChanges);
		}

		public void UpdateOrderedProduct(int id, OrderedProduct orderedProduct, bool trackChanges)
		{
			var newOrder = _manager.OrderedProduct
					.GetOrderedProductsByOrderId(id, trackChanges);
			//var entity = _manager.OrderedProduct.GetOrderedProductsByCustomerId(id, trackChanges);

			if (orderedProduct is null)
				throw new ArgumentNullException(nameof(orderedProduct));

			newOrder.CustomerId = orderedProduct.CustomerId;
			newOrder.ProductId = orderedProduct.ProductId;
			newOrder.ProductName = orderedProduct.ProductName;
			newOrder.ProductImage = orderedProduct.ProductImage;
			newOrder.ProductPrice = orderedProduct.ProductPrice;
			newOrder.ProductsTotal = orderedProduct.ProductsTotal;
			newOrder.NumberOfProduct = orderedProduct.NumberOfProduct;
			newOrder.BasketTotal = orderedProduct.BasketTotal;
			newOrder.ShippingFee = orderedProduct.ShippingFee;
			newOrder.TotalPrice = orderedProduct.TotalPrice;
			newOrder.OrderStatus = orderedProduct.OrderStatus;
			newOrder.OrderRowStatus = orderedProduct.OrderRowStatus;

			_manager.OrderedProduct.UpdateOrderedProduct(newOrder);
			_manager.Save();
		}
	}
}
