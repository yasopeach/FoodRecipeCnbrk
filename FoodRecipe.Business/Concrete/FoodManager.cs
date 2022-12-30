using FoodRecipe.Business.Abstract;
using FoodRecipe.Data.Abstract;
using FoodRecipe.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipe.Business.Concrete
{
	public class FoodManager : IFoodService
	{
		private readonly IFoodRepository _foodRepository;

		public FoodManager(IFoodRepository foodRepository)
		{
			_foodRepository = foodRepository;
		}


		public void Create(Food entity)
		{
			_foodRepository.Create(entity);
		}

		public void Delete(Food entity)
		{
			_foodRepository.Delete(entity);
		}

		public List<Food> GetAll()
		{
			return _foodRepository.GetAll();
		}

		public Food GetById(int id)
		{
			return _foodRepository.GetById(id);
		}

		public List<Food> GetListAll()
		{
			return _foodRepository.GetListAll();
		}

		public void Update(Food entity)
		{
			_foodRepository.Update(entity);
		}
	}
}
