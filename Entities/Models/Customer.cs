using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
	public class Customer
	{
        public int CustomerId { get; set; }
		public string CustomerName { get; set; }
        public string CustomerSurname { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string CustomerAddress { get; set; }
        public string CustomerPassword { get; set; }
        public bool CustomerStatus { get; set; }
    }
}
