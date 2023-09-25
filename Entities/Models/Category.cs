using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
	public class Category
	{
        public int CategoryId { get; set; }
		public string? CategoryName { get; set; }
		public string? CategoryImage { get; set; }
        public bool? CategoryStatus { get; set; }
    }
}
