using Entities.Models;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Controllers
{
	[Route("api/orderedproducts")]
	public class OrderedProductController : ControllerBase
	{
		private readonly IServiceManager _manager;

		public OrderedProductController(IServiceManager manager)
		{
			_manager = manager;
		}

		[HttpGet("{id:int}")]
		public IActionResult GetOrderedProductsByCustomerId([FromRoute(Name = "id")] int id)
		{
			//müşteri sepeti görüntüle butonuna basınca bu get isteği atılacak ve sepet görüntülenecek.
			try
			{
				var customer = _manager.CustomerService.GetOneCustomerById(id, false);

				if (customer is null)
					return NotFound($"Customer with id:{id} could not found.");
				else
				{
					var basket = _manager.OrderedProductService
						.GetOrderedProductsByCustomerId(id, false)
						.Where(o => o.OrderRowStatus == true && o.OrderStatus == false);

					//decimal shippingFee = 10;
					decimal basketTotal = 0;
					decimal itemTotal = 0;
					decimal productsTotal = 0;
					//basketTotal += shippingFee;

					foreach (var item in basket)
					{
						itemTotal = item.ProductPrice * item.NumberOfProduct;
						item.BasketTotal = itemTotal;
						productsTotal += itemTotal;
						item.ProductsTotal = productsTotal;
						item.TotalPrice = productsTotal + item.ShippingFee;
						_manager.OrderedProductService.UpdateOrderedProduct(item.OrderId, item, true);
					}
					return Ok(basket);
				}
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		[HttpPost()]
		public IActionResult CreateOrderedProduct([FromBody] OrderedProduct orderedProduct)
		{
			try
			{
				//ürün seçildiğinde bu post isteği atılacak ve dto nesnesi doldurulacak.
				if (orderedProduct is null)
					return BadRequest();

				var customer = _manager.CustomerService.GetOneCustomerById(orderedProduct.CustomerId, false);
				
				if (customer is null)
					return NotFound($"Customer with id:{orderedProduct.CustomerId} could not found.");
				else
				{
					//sepete eklenmesi istenen ürünü tablodan bul.
					var product = _manager.ProductService.GetOneProductById(orderedProduct.ProductId, false);

					var dto = new OrderedProduct();
					dto.CustomerId = orderedProduct.CustomerId;
					dto.ProductId = orderedProduct.ProductId;
					dto.NumberOfProduct = 0;
					dto.ProductImage = product.ProductImage;
					dto.ProductName = product.ProductName;
					dto.ProductPrice = product.ProductPrice;
					dto.BasketTotal = 0;
					dto.ShippingFee = 10;
					dto.TotalPrice = 0;
					dto.ProductsTotal = 0;
					dto.OrderStatus = false;//ürün sepette, henüz sipariş oluşturulmadı.
					dto.OrderRowStatus = true;

					//buraya kadar olan bilgiler onaylanmamış siparişe ait olduğu için sepet veritabanına kaydedilecek.
					//ürün seçildikten sonra müşteri sepete ekle butonuna basacak ve dto sepet tablosuna eklenecek.


					//eğer bir müşteri aynı ürünü tekrar eklemek isterse veritabanından o ürünü çek ve sayısını artır. Veritabanında yoksa create et.
					var customersOrders = _manager.OrderedProductService
						.GetOrderedProductsByCustomerId(dto.CustomerId, false)
						.Where(o => o.ProductId == dto.ProductId);

					if (!customersOrders.Any())//müşteri daha önce o ürünle ilgili sipariş oluşturmadıysa.
					{
						dto.NumberOfProduct = 1;//ilk defa ekleniyorsa yeni kayıt oluşturmadan önce sayısını 1 yap.
						_manager.OrderedProductService.CreateOrderedProduct(dto);
					}
					else
					{
						foreach (var order in customersOrders)
						{
							if (order.NumberOfProduct != 0)//daha önce sepete eklenmişse sayısını artır.
							{
								++order.NumberOfProduct;
								_manager.OrderedProductService.UpdateOrderedProduct(order.OrderId, order, true);//veri tabanına yeni değeri kaydet?
							}
							/*else
							{
								dto.NumberOfProduct = 1;//ilk defa ekleniyorsa yeni kayıt oluşturmadan önce sayısını 1 yap.
								_manager.OrderedProductService.CreateOrderedProduct(dto);
							}*/
						}
					}
					return StatusCode(201);
				}
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}


		[HttpPatch("{id:int}")]
		//sepeti onayla butonuna basıldığında sepetteki siparişin orderStatus true ya çekilecek.
		//Uygulamaya siparişleri görüntüleme ekranı eklendiğinde orderStatusları true olanlar siparişlerimde gösterilecek, sepette gösterilmeyecek.
		public IActionResult UpdateOrderStatus([FromRoute(Name = "id")] int id,
			[FromBody] JsonPatchDocument<OrderedProduct> orderedProductPatch)
		{
			try
			{
				/*var order = _manager.OrderedProductService
					.GetOrderedProductsByOrderId(id, true);*/
				var orders = _manager.OrderedProductService
						.GetOrderedProductsByCustomerId(id, false)
						.Where(o => o.OrderRowStatus == true && o.OrderStatus == false);

				if (!orders.Any()) return NotFound();

				foreach (var order in orders)
				{
					orderedProductPatch.ApplyTo(order);
					_manager.OrderedProductService.UpdateOrderedProduct(order.OrderId, order, true);

				
				}

				return Ok();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
