using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
	public class Product
	{
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string? ProductImage { get; set; }
        public decimal ProductStock { get; set; }
        public decimal ProductPrice { get; set; }
        public bool? ProductStatus { get; set; }
		public int CategoryId { get; set; }
        //public Category ProductCategory { get; set; }

	}
}
