using FoodRecipe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipe.Data.Abstract
{
	public interface IFoodRepository : IRepository<Food>
	{
		List<Food> GetListAll();
		
	}
}
