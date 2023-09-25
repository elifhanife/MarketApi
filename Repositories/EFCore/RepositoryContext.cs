using Entities.Models;
using Microsoft.EntityFrameworkCore;
using Repositories.EFCore.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore
{
	public class RepositoryContext : DbContext
	{
		public RepositoryContext(DbContextOptions options) :
			base(options)
		{ 

		}
		public DbSet<Customer> Customers { get; set; }
		public DbSet<Category> Categories { get; set; }
		public DbSet<Product> Products { get; set; }
		public DbSet<OrderedProduct> OrderedProducts { get; set; }

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.ApplyConfiguration(new CategoryConfig());
			modelBuilder.ApplyConfiguration(new ProductConfig());
		}

	}
}
