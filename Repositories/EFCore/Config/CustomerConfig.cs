using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Config
{
	public class CustomerConfig : IEntityTypeConfiguration<Customer>
	{
		public void Configure(EntityTypeBuilder<Customer> builder) 
		{
			builder.HasData(
				new Customer { Id=1, CustomerId = "01234567890", CustomerName = "Elif", CustomerSurname = "Aydoğan", CustomerPassword = "1234", CustomerStatus = true },
				new Customer { Id=2, CustomerId = "12345678987", CustomerName = "Doğan", CustomerSurname = "Cüceloğlu", CustomerPassword = "12345", CustomerStatus = true },
				new Customer { Id=3, CustomerId = "98765432101", CustomerName = "Zülfü", CustomerSurname = "Livaneli", CustomerPassword = "123456", CustomerStatus = true }
				);
		}
	}
}
