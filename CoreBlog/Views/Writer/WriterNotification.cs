using Microsoft.AspNetCore.Mvc;

namespace CoreBlog.Views.Writer
{
    public class WriterNotification : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
