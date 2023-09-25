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
		Customer GetOneCustomerById(int id, bool trackChanges);
		Customer CreateOneCustomer(Customer customer);
		void UpdateOneCustomer(int id, Customer customer, bool trackChanges);
		void DeleteOneCustomer(int id, bool trackChanges);
	}
}
