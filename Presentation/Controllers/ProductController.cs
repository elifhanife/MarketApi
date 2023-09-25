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
	[Route("api/products")]
	public class ProductController : ControllerBase
	{
		private readonly IServiceManager _manager;

		public ProductController(IServiceManager manager)
		{
			_manager = manager;
		}

		[HttpGet]
		public IActionResult GetAllProducts()
		{
			try
			{
				var products = _manager.ProductService.GetAllProducts(false);
				return Ok(products);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		[HttpGet("{id:int}")]

		public IActionResult GetOneProduct([FromRoute(Name = "id")] int id)
		{
			try
			{
				var product = _manager
					.ProductService
					.GetOneProductById(id, false);

				if (product is null)
					return NotFound();

				return Ok(product);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		[HttpGet("getbycategory/{id:int}")]
		public IActionResult GetProductsByCategory([FromRoute(Name = "id")] int id)
		{
			try
			{
				var products = _manager.ProductService.GetProductsByCategory(id, false);
				return Ok(products);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		[HttpPost]
		public IActionResult CreateOneProduct([FromBody] Product product)
		{
			try
			{
				if (product is null)
					return BadRequest();

				_manager.ProductService.CreateOneProduct(product);

				return StatusCode(201, product);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		/*[HttpPut("{id:length(11)}")]
		public IActionResult UpdateOneProduct([FromRoute(Name = "id")] string id,
			[FromBody] Product product)
		{
			try
			{
				if (product is null)
					return BadRequest();

				_manager.ProductService.UpdateOneProduct(id, product, true);

				return NoContent();

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}*/

		/*[HttpDelete("{id:length(11)}")]
		public IActionResult DeleteOneProduct([FromRoute(Name = "id")] string id)
		{
			try
			{
				_manager.ProductService.DeleteOneProduct(id, false);

				return NoContent();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}*/

		/*[HttpPatch("{id:length(11)}")]
		public IActionResult PartiallyUpdateOneProduct([FromRoute(Name = "id")] string id,
			[FromBody] JsonPatchDocument<Product> productPatch)
		{
			try
			{
				var entity = _manager
					.ProductService
					.GetOneProductById(id, true);

				if (entity is null) return NotFound();

				productPatch.ApplyTo(entity);
				_manager.ProductService.UpdateOneProduct(id, entity, true);

				return NoContent();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}*/
	}
}
