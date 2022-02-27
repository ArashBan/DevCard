using DevCard.Data;
using Microsoft.AspNetCore.Mvc;

namespace DevCard.ViewComponents
{
    public class LatestArticlesViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var articles = LatestArticlesData.GetArticles();
            return View("_LatestArticles", articles);
        }
    }
}