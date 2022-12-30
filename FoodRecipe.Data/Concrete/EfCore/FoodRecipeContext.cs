using FoodRecipe.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FoodRecipe.Data.Concrete.EfCore
{
	public class FoodRecipeContext : DbContext
	{

		public DbSet<Food> Foods { get; set; }

		public DbSet<Category> Categories { get; set; }

		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("Server = DESKTOP-AFUMI0D\\MSSQLCNBRK; Database = FoodRecipe3_Db; User = sa; Password = 123");
		}
	}
}
