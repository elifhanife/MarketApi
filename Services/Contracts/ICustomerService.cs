using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Contracts
{
	public interface ICustomerService
	{
		IEnumerable<Customer> GetAllCustomers(bool trackChanges);
		Customer GetOneCustomerById(string id, bool trackChanges);
		Customer CreateOneCustomer(Customer customer);
		void UpdateOneCustomer(string id, Customer customer, bool trackChanges);
		void DeleteOneCustomer(string id, bool trackChanges);
	}
}
