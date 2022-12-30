using FoodRecipe.Entity;
using System.Collections.Generic;

namespace FoodRecipe.WebUI.Models
{
	public class FoodModel
	{
		public int Id { get; set; }

		public string FoodName { get; set; }

		public string FoodDescription { get; set; }

		public string Ingredients { get; set; }

		public List<Category> SelectedCategory { get; set; }
	}
}
