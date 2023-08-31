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
	[ApiController]
	[Route("api/customers")]
	public class CustomerController : ControllerBase
	{
		private readonly IServiceManager _manager;

		public CustomerController(IServiceManager manager)
		{
			_manager = manager;
		}

		[HttpGet]
		public IActionResult GetAllCustomer()
		{
			try
			{
				var customers = _manager.CustomerService.GetAllCustomers(false);
				return Ok(customers);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
				throw;
			}
		}

		[HttpGet("{id:length(11)}")]

		public IActionResult GetOneCustomer([FromRoute(Name = "id")] string id)
		{
			try
			{
				var customer = _manager
					.CustomerService
					.GetOneCustomerById(id, false);

				if (customer is null)
					return NotFound();

				return Ok(customer);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		[HttpPost]
		public IActionResult CreateOneCustomer([FromBody] Customer customer)
		{
			try
			{
				if (customer is null)
					return BadRequest();

				_manager.CustomerService.CreateOneCustomer(customer);

				return StatusCode(201, customer);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		[HttpPut("{id:length(11)}")]
		public IActionResult UpdateOneCustomer([FromRoute(Name = "id")] string id,
			[FromBody] Customer customer)
		{
			try
			{
				if (customer is null)
					return BadRequest();

				_manager.CustomerService.UpdateOneCustomer(id, customer, true);

				return NoContent();

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		[HttpDelete("{id:length(11)}")]
		public IActionResult DeleteOneCustomer([FromRoute(Name = "id")] string id)
		{
			try
			{
				_manager.CustomerService.DeleteOneCustomer(id, false);

				return NoContent();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		[HttpPatch("{id:length(11)}")]
		public IActionResult PartiallyUpdateOneCustomer([FromRoute(Name = "id")] string id,
			[FromBody] JsonPatchDocument<Customer> customerPatch)
		{
			try
			{
				var entity = _manager
					.CustomerService
					.GetOneCustomerById(id, true);

				if (entity is null) return NotFound();

				customerPatch.ApplyTo(entity);
				_manager.CustomerService.UpdateOneCustomer(id, entity, true);

				return NoContent();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}
	}
}
