using Entities.Models;
using Repositories.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
	public class CustomerRepository : RepositoryBase<Customer>, ICustomerRepository
	{
		public CustomerRepository(RepositoryContext context) : base(context)
		{

		}

		public void CreateOneCustomer(Customer customer) => Create(customer);

		public void DeleteOneCustomer(Customer customer) => Delete(customer);

		public IQueryable<Customer> GetAllCustomers(bool trackChanges) => 
			FindAll(trackChanges);

		public Customer GetOneCustomerById(int id, bool trackChanges) =>
			FindByCondition(c => c.CustomerId.Equals(id), trackChanges)
			.SingleOrDefault();

		public void UpdateOneCustomer(Customer customer) => Update(customer);
	}
}
