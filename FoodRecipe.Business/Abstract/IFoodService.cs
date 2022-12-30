using FoodRecipe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipe.Business.Abstract
{
	public interface IFoodService
	{
		Food GetById(int id);

		List<Food> GetAll();

		List<Food> GetListAll();

		void Create(Food entity);
		void Delete(Food entity);
		void Update(Food entity);

	}
}
