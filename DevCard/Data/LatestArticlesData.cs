﻿using DevCard.Models;
using System.Collections.Generic;
using System.Linq;

namespace DevCard.Data
{
    public class LatestArticlesData
    {
        public static List<Article> GetArticles()
        {
            return new List<Article>
            {
                new Article(1, "آموزش Asp.net core mvc", "کاملترین پکیج آموزش asp.net core mvc به زبان فارسی",
                    "blog-post-thumb-card-1.jpg"),
                new Article(2, "آموزش Git & Github", "کاملترین پکیج آموزش Git & Github به زبان فارسی",
                    "blog-post-thumb-card-2.jpg"),
                new Article(3, "آموزش Onion Architecture", "کاملترین پکیج آموزش Onion Architecture به زبان فارسی",
                    "blog-post-thumb-card-3.jpg"),
                new Article(4, "آموزش طراحی سایت", "کاملترین پکیج آموزش طراحی سایت به زبان فارسی",
                    "blog-post-thumb-card-4.jpg"),
                new Article(5, "آموزش سی شارپ (#C)", "کاملترین پکیج آموزش سی شارپ به زبان فارسی",
                    "blog-post-thumb-card-5.jpg")
            };
        }

        public static Article GetArticleBy(long id)
        {
            return GetArticles().FirstOrDefault(x => x.Id == id);
        }
    }
}
