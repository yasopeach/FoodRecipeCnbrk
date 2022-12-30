using FoodRecipe.Business.Abstract;
using FoodRecipe.Entity;
using Microsoft.AspNetCore.Mvc;

namespace FoodRecipe.WebUI.Controllers
{
	public class CategoryController : Controller
	{
		private readonly IFoodService _foodService;
		private readonly ICategoryService _categoryService;

		public CategoryController(IFoodService foodService, ICategoryService categoryService)
		{
			_foodService = foodService;
			_categoryService = categoryService;
		}


		public IActionResult Index()
		{
			return View();
		}

		public IActionResult CategoryList()
		{
			var values = _categoryService.GetAll();
			return View(values);
		}

		//AddCat Get
		public IActionResult AddCategory(int id)
		{
			
			return View();
		}

		//AddCat Post
		[HttpPost]
		public IActionResult AddCategory(Category category)
		{
			_categoryService.Create(category);
			return RedirectToAction("CategoryList", "Category");
		}


		//UpdateCat GET
		public IActionResult UpdateCategory(int id)
		{
			var value = _categoryService.GetById(id);
			return View(value);
		}

		//UpdateCat POST
		[HttpPost]
		public IActionResult UpdateCategory(Category category)
		{
			var entity = _categoryService.GetById(category.CategoryId);
			entity.CategoryName = category.CategoryName;
			_categoryService.Update(entity);
			return RedirectToAction("CategoryList", "Category");

		}

		//Delete Cat
		public IActionResult DeleteCategory(int id)
		{
			var entity = _categoryService.GetById(id);
			_categoryService.Delete(entity);
			return RedirectToAction("CategoryList", "Category");
		}


	}
}
