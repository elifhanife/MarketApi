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
	public class ProductManager : IProductService
	{
		private readonly IRepositoryManager _manager;

		public ProductManager(IRepositoryManager manager)
		{
			_manager = manager;
		}

		public Product CreateOneProduct(Product product)
		{
			if (product == null)
				throw new ArgumentNullException(nameof(product));

			_manager.Product.CreateOneProduct(product);
			_manager.Save();

			return product;
		}

		/*public void DeleteOneProduct(string id, bool trackChanges)
		{
			var entity = _manager.Product.GetOneProductById(id, trackChanges);
			if (entity == null)
				throw new Exception($"Product with id:{id} could not found.");

			_manager.Product.DeleteOneProduct(entity);
			_manager.Save();
		}*/

		public IEnumerable<Product> GetAllProducts(bool trackChanges)
		{
			return _manager.Product.GetAllProducts(trackChanges);
		}

		public Product GetOneProductById(int id, bool trackChanges)
		{
			return _manager.Product.GetOneProductById(id, trackChanges);
		}

		public IEnumerable<Product> GetProductsByCategory(int id, bool trackChanges)
		{
			return _manager.Product.GetProductsByCategory(id, trackChanges);
		}


		/*public void UpdateOneProduct(string id, Product product, bool trackChanges)
		{
			var entity = _manager.Product.GetOneProductById(id, trackChanges);
			if (entity == null)
				throw new Exception($"Product with id:{id} could not found.");

			if (product is null)
				throw new ArgumentNullException(nameof(product));

			entity.ProductStatus = product.ProductStatus;
			entity.ProductStock = product.ProductStock;
			entity.ProductPrice = product.ProductPrice;
			entity.ProductName = product.ProductName;
			entity.ProductImage = product.ProductImage;

			_manager.Product.UpdateOneProduct(entity);
			_manager.Save();
		}*/
	}
}
