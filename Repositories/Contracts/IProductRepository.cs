using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
	public interface IProductRepository : IRepositoryBase<Product>
	{
		IQueryable<Product> GetAllProducts(bool trackChanges);

		Product GetOneProductById(int id, bool trackChanges);

		IQueryable<Product> GetProductsByCategory(int id, bool trackChanges);
		void CreateOneProduct(Product product);
		//void UpdateOneProduct(Customer customer);
		//void DeleteOneProduct(Customer customer);
	}
}
