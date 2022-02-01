using System.Collections.Generic;
using DevCard.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevCard.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string name)
        {
            var projects = new List<Project>
            {
                new Project(1, "مای پروفشنال", "نرم افزاری چندکاره مناسب برای روزمرگی برنامه نویسان", "project-1.jpg", "همکاران سیستم"),
                new Project(2, "آروتل", "نرم افزار حرفه ای هتلداری برای هتل های بین المللی", "project-2.jpg","هتل آریا"),
                new Project(3, "میلیون (منسوخ شده)", "نرم افزار ذخیره سازی ساده اطلاعات", "project-3.jpg","گردو"),
                new Project(4, "رجیستر", "نرم افزار ثبت و ذخیره سازی اطلاعات برای مدارس","project-4.jpg", "مدرسه احرار")
            };
            return View("_Projects", projects);
        }
    }
}
