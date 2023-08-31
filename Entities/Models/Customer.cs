using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
	public class Customer
	{
        public int Id { get; set; }
        public string CustomerId { get; set; }
		public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerPassword { get; set; }
        public bool CustomerStatus { get; set; }
    }
}
