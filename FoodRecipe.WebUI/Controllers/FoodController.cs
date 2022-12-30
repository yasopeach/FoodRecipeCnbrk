using FoodRecipe.Business.Abstract;
using FoodRecipe.Entity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.Linq;

namespace FoodRecipe.WebUI.Controllers
{
	public class FoodController : Controller
	{
		private readonly IFoodService _foodService;
		private readonly ICategoryService _categoryService;

		public FoodController(IFoodService foodService, ICategoryService categoryService)
		{
			_foodService = foodService;
			_categoryService = categoryService;
		}

		public IActionResult Index()
		{
			return View();
		}


		public IActionResult FoodList()
		{

			var values = _foodService.GetListAll();
			
			return View(values);
		}


		//AddFood GET
		public IActionResult AddFood(int id)
		{
			List<SelectListItem> value1 = (from x in _categoryService.GetAll()
										   select new SelectListItem
										   {
											   Text = x.CategoryName,
											   Value = x.CategoryId.ToString()

										   }).ToList();
			ViewBag.cv = value1;
			var value2 = _foodService.GetById(id);
			return View(value2);

		}


		//AddFood POST
		[HttpPost]
		public IActionResult AddFood(Food food)
		{
			_foodService.Create(food);
			return RedirectToAction("FoodList", "Food");
		}

		//UpdateFood Get
		public IActionResult UpdateFood(int id)
		{

			List<SelectListItem> value1 = (from x in _categoryService.GetAll()
										   select new SelectListItem
										   {
											   Text = x.CategoryName,
											   Value = x.CategoryId.ToString()

										   }).ToList();
			ViewBag.cv = value1;
			var value2 = _foodService.GetById(id);
			return View(value2);
		}


		//UpdateFood Post
		[HttpPost]
		public IActionResult UpdateFood(Food food)
		{
			var entity = _foodService.GetById(food.Id);
			entity.FoodName = food.FoodName;
			entity.FoodDescription = food.FoodDescription;
			entity.Ingredients = food.Ingredients;
			entity.CategoryId = food.CategoryId;
			_foodService.Update(entity);
			return RedirectToAction("FoodList", "Food");

		}


		//DeleteFood
		public IActionResult DeleteFood(int id)
		{
			var entity = _foodService.GetById(id);
			_foodService.Delete(entity);
			return RedirectToAction("FoodList", "Food");


		}


	}
}
