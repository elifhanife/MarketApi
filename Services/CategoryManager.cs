using Entities.Models;
using Repositories.Contracts;
using Services.Contracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
	public class CategoryManager : ICategoryService
	{
		private readonly IRepositoryManager _manager;

		public CategoryManager(IRepositoryManager manager)
		{
			_manager = manager;
		}

		public Category CreateOneCategory(Category category)
		{
			if (category == null)
				throw new ArgumentNullException(nameof(category));

			_manager.Category.CreateOneCategory(category);
			_manager.Save();

			return category;
		}

		/*public void DeleteOneCategory(string id, bool trackChanges)
		{
			var entity = _manager.Category.GetOneCategoryById(id, trackChanges);
			if (entity == null)
				throw new Exception($"Category with id:{id} could not found.");

			_manager.Category.DeleteOneCategory(entity);
			_manager.Save();
		}*/

		public IEnumerable<Category> GetAllCategories(bool trackChanges)
		{
			return _manager.Category.GetAllCategories(trackChanges);
		}

		public Category GetOneCategoryById(int id, bool trackChanges)
		{
			return _manager.Category.GetOneCategoryById(id, trackChanges);
		}

		/*public void UpdateOneCategory(string id, Category category, bool trackChanges)
		{
			var entity = _manager.Category.GetOneCategoryById(id, trackChanges);
			if (entity == null)
				throw new Exception($"Category with id:{id} could not found.");

			if (category is null)
				throw new ArgumentNullException(nameof(category));

			entity.CategoryName = category.CategoryName;
			entity.CategoryStatus = category.CategoryStatus;
			entity.CategoryImage = category.CategoryImage;

			_manager.Category.UpdateOneCategory(entity);
			_manager.Save();
		}*/
	}
}
