using Repositories.Contracts;
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
		public readonly Lazy<ICustomerService> _customerService;
		public ServiceManager(IRepositoryManager repositoryManager)
		{
			_customerService = new Lazy<ICustomerService>(() => new CustomerManager(repositoryManager));
		}

		public ICustomerService CustomerService => _customerService.Value;
	}
}
