using FoodRecipe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipe.Business.Abstract
{
	public interface ICategoryService
	{
		Category GetById(int id);

		List<Category> GetAll();

		List<Category> GetListAll();

		void Create(Category entity);
		void Delete(Category entity);
		void Update(Category entity);
	}
}
