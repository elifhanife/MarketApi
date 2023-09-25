using Entities.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.EFCore.Config
{
	public class ProductConfig : IEntityTypeConfiguration<Product>
	{
		public void Configure(EntityTypeBuilder<Product> builder)
		{
			builder.HasData(
				new Product { ProductId = 1, ProductName = "Furniture", ProductImage = "~/MarketApp/WebApi/Images/CategoryHome.jfif"
				, ProductStock = 10, ProductPrice = 25, ProductStatus = true , CategoryId = 1}
				);
		}
	}
}
