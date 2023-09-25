using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Models
{
	public class OrderedProduct
	{
		[Key]
		public int OrderId { get; set; }
		public int CustomerId { get; set; }
		public int ProductId { get; set; }
		public string ProductName { get; set; }
		public string? ProductImage { get; set; }
		public decimal ProductPrice { get; set; }
		public int NumberOfProduct { get; set; }
		public decimal ProductsTotal { get; set; }
		public decimal BasketTotal { get; set; }
		public decimal ShippingFee { get; set; }
		public decimal TotalPrice { get; set; }
        public bool OrderStatus { get; set; } //0 sa sepette (yani henüz satın almadı, ekledi), 1 se siparişlerde (satın aldı, tekrar sepette gösterme).
        public bool OrderRowStatus { get; set; } //1 olanları göster(sipariş oluşturuldu), 0 olanları gösterme(sepetten sildi).
    }
}
