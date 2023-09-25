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
	[Route("api/categories")]
	public class CategoryController : ControllerBase
	{
		private readonly IServiceManager _manager;

		public CategoryController(IServiceManager manager)
		{
			_manager = manager;
		}

		[HttpGet]
		public IActionResult GetAllCategories()
		{
			try
			{
				var categories = _manager.CategoryService.GetAllCategories(false);
				return Ok(categories);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		[HttpGet("{id:int}")]

		public IActionResult GetOneCategory([FromRoute(Name = "id")] int id)
		{
			try
			{
				var category = _manager
					.CategoryService
					.GetOneCategoryById(id, false);

				if (category is null)
					return NotFound();

				return Ok(category);
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}

		[HttpPost]
		public IActionResult CreateOneCategory([FromBody] Category category)
		{
			try
			{
				if (category is null)
					return BadRequest();

				_manager.CategoryService.CreateOneCategory(category);

				return StatusCode(201, category);
			}
			catch (Exception ex)
			{
				return BadRequest(ex.Message);
			}
		}

		/*[HttpPut("{id:length(11)}")]
		public IActionResult UpdateOneCategory([FromRoute(Name = "id")] string id,
			[FromBody] Category category)
		{
			try
			{
				if (category is null)
					return BadRequest();

				_manager.CategoryService.UpdateOneCategory(id, category, true);

				return NoContent();

			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}*/

		/*[HttpDelete("{id:length(11)}")]
		public IActionResult DeleteOneCategory([FromRoute(Name = "id")] string id)
		{
			try
			{
				_manager.CategoryService.DeleteOneCategory(id, false);

				return NoContent();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}*/

		/*[HttpPatch("{id:length(11)}")]
		public IActionResult PartiallyUpdateOneCategory([FromRoute(Name = "id")] string id,
			[FromBody] JsonPatchDocument<Category> categoryPatch)
		{
			try
			{
				var entity = _manager
					.CategoryService
					.GetOneCategoryById(id, true);

				if (entity is null) return NotFound();

				categoryPatch.ApplyTo(entity);
				_manager.CategoryService.UpdateOneCategory(id, entity, true);

				return NoContent();
			}
			catch (Exception ex)
			{
				throw new Exception(ex.Message);
			}
		}*/
	}
}
