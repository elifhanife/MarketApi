using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
	public interface IProductService
	{
		IEnumerable<Product> GetAllProducts(bool trackChanges);
		Product GetOneProductById(int id, bool trackChanges);
		Product CreateOneProduct(Product product);
		IEnumerable<Product> GetProductsByCategory(int id, bool trackChanges);
		//void UpdateOneProduct(int id, Product product, bool trackChanges);
		//void DeleteOneProduct(int id, bool trackChanges);
	}
}
