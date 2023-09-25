using Repositories.Contracts;
using Repositories.EFCore;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
	public class ServiceManager : IServiceManager
	{
		private readonly IRepositoryManager _manager;

		public readonly Lazy<ICustomerService> _customerService;
		public readonly Lazy<ICategoryService> _categoryService;
		public readonly Lazy<IProductService> _productService;
		public readonly Lazy<IOrderedProductService> _orderedProductService;
		public ServiceManager(IRepositoryManager repositoryManager)
		{
			_customerService = new Lazy<ICustomerService>(() => new CustomerManager(repositoryManager));
			_categoryService = new Lazy<ICategoryService>(() => new CategoryManager(repositoryManager));
			_productService = new Lazy<IProductService>(() => new ProductManager(repositoryManager));
			_orderedProductService = new Lazy<IOrderedProductService>(() => new OrderedProductManager(repositoryManager));
		}

		public ICustomerService CustomerService => _customerService.Value;

		public ICategoryService CategoryService => _categoryService.Value;

		public IProductService ProductService => _productService.Value;

		public IOrderedProductService OrderedProductService => _orderedProductService.Value;

	}
}
