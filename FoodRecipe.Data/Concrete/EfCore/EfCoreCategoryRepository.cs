using FoodRecipe.Data.Abstract;
using FoodRecipe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipe.Data.Concrete.EfCore
{
	public class EfCoreCategoryRepository : EfCoreGenericRepository<Category, FoodRecipeContext>, ICategoryRepository
	{
		public List<Category> GetListAll()
		{
			throw new NotImplementedException();
		}
	}
}
