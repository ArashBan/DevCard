using DevCard.Models;
using System.Collections.Generic;
using System.Linq;

namespace DevCard.Data
{
    public class ProjectData
    {
        public static List<Project> GetProjects()
        {
            return new List<Project>
            {
                new Project(1, "مای پروفشنال", "نرم افزار چند کاره مناسب برای روزمرگی برنامه نویسان پیشرفته", "project-1.jpg", "همکاران سیستم"),
                new Project(2, "آروتل", "نرم افزار حرفه ای هتلداری برای هتل های بین المللی", "project-2.jpg","هتل آریا"),
                new Project(3, "میلیون (منسوخ شده)", "نرم افزار ذخیره سازی ساده اطلاعات", "project-3.jpg","گردو"),
                new Project(4, "رجیستر", "نرم افزار ثبت و ذخیره سازی اطلاعات برای مدارس","project-4.jpg", "مدرسه احرار")
            };
        }

        public static Project GetProjectBy(long id)
        {
            return GetProjects().FirstOrDefault(x => x.Id == id);
        }
    }
}
