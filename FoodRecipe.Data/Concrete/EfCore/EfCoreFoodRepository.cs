using FoodRecipe.Data.Abstract;
using FoodRecipe.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipe.Data.Concrete.EfCore
{
	public class EfCoreFoodRepository : EfCoreGenericRepository<Food, FoodRecipeContext>, IFoodRepository
	{
		public List<Food> GetListAll()
		{
			using (var context = new FoodRecipeContext())
			{
				return context.Foods.Include(x => x.Category).ToList();

			}
		}
	}
}
