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
	public class CustomerManager : ICustomerService
	{
		private readonly IRepositoryManager _manager;

		public CustomerManager(IRepositoryManager manager)
		{
			_manager = manager;
		}

		public Customer CreateOneCustomer(Customer customer)
		{
			if(customer == null)
				throw new ArgumentNullException(nameof(customer));
			
			_manager.Customer.CreateOneCustomer(customer);
			_manager.Save();
			
			return customer;
		}

		public void DeleteOneCustomer(int id, bool trackChanges)
		{
			var entity = _manager.Customer.GetOneCustomerById(id, trackChanges);
			if (entity == null)
				throw new Exception($"Customer with id:{id} could not found.");
			
			_manager.Customer.DeleteOneCustomer(entity);
			_manager.Save();
		}

		public IEnumerable<Customer> GetAllCustomers(bool trackChanges)
		{
			return _manager.Customer.GetAllCustomers(trackChanges);
		}

		public Customer GetOneCustomerById(int id, bool trackChanges)
		{
			return _manager.Customer.GetOneCustomerById(id,trackChanges);
		}

		public void UpdateOneCustomer(int id, Customer customer, bool trackChanges)
		{
			var entity = _manager.Customer.GetOneCustomerById(id, trackChanges);
			if (entity == null)
				throw new Exception($"Customer with id:{id} could not found.");

			if (customer is null)
				throw new ArgumentNullException(nameof(customer));

			entity.CustomerName = customer.CustomerName;
			entity.CustomerSurname = customer.CustomerSurname;
			entity.CustomerPhoneNumber = customer.CustomerPhoneNumber;
			entity.CustomerAddress = customer.CustomerAddress;
			entity.CustomerPassword = customer.CustomerPassword;
			entity.CustomerStatus = customer.CustomerStatus;

			_manager.Customer.UpdateOneCustomer(entity);
			_manager.Save();
		}
	}
}
