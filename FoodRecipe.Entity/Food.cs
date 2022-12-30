using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipe.Entity
{
	public class Food
	{
		public int Id { get; set; }

		public string FoodName { get; set; }

		public string FoodDescription { get; set;}

		public string Ingredients { get; set; }

		public int CategoryId { get; set; }

		public Category Category { get; set; }
	}
}
