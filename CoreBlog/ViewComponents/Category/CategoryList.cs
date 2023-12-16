using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CoreBlog.ViewComponents.Category
{
	public class CategoryList : ViewComponent
	{
		CategoryManager cm = new CategoryManager(new EfCategoryRepository());
		public IViewComponentResult Invoke() 
		{
			var values = cm.GetList();
			return View(values);
		}
	}
}
