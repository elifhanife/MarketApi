﻿using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
	public class RepositoryManager : IRepositoryManager
	{
		//save işlemi yapmak için bir context e ihtiyacımız var.
		private readonly RepositoryContext _context;
		//Lazy loading yaparak ihtiyaç duyduğumuz bilgileri tek seferde değil, lazım olduğunda istiyoruz.
		//Böylece yerden tasarruf ediyoruz.
		private readonly Lazy<ICustomerRepository> _customerRepository;
		private readonly Lazy<ICategoryRepository> _categoryRepository;
		private readonly Lazy<IProductRepository> _productRepository;
		private readonly Lazy<IOrderedProductRepository> _orderedProductRepository;

		public RepositoryManager(RepositoryContext context)
		{
			_context = context;
			_customerRepository = new Lazy<ICustomerRepository>(() => new CustomerRepository(_context));
			_categoryRepository = new Lazy<ICategoryRepository>(() => new CategoryRepository(_context));
			_productRepository = new Lazy<IProductRepository>(() => new ProductRepository(_context));
			_orderedProductRepository = new Lazy<IOrderedProductRepository>(() => new OrderedProductRepository(_context));
		}

		//Her bir repo için IOC kaydı yapmamak için burada merkezi bir new leme yapıyoruz.
		//İsteseydik her repo için IOC kaydı yapardık ama bu zayıf bağlı bir uygulama olurdu.
		//Aşağıdaki kodla birlikte Customer artık bir repoya karşılık geliyor.
		//public ICustomerRepository Customer => new CustomerRepository(_context);

		//Aşağıdaki kodla beraber artık manager ın bir customer nesnesi var.
		//Managerdan customer nesnesi istendiği anda ona değeri dönecek.
		//Yani lazy loading yapmış olduk.
		public ICustomerRepository Customer => _customerRepository.Value;
		public ICategoryRepository Category => _categoryRepository.Value;
		public IProductRepository Product => _productRepository.Value;
		public IOrderedProductRepository OrderedProduct => _orderedProductRepository.Value;
		public void Save() => _context.SaveChanges();
	}
}
