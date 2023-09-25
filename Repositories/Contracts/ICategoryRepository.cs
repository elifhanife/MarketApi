using Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Contracts
{
	public interface ICategoryRepository : IRepositoryBase<Category>
	{
		IQueryable<Category> GetAllCategories(bool trackChanges);

		Category GetOneCategoryById(int id, bool trackChanges);

		void CreateOneCategory(Category category);
		//void UpdateOneCategory(Category category);
		//void DeleteOneCategory(Category category);
	}
}
