using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCArticleCodeFirst.Models;

namespace MVCArticleCodeFirst.DAL
{
    public class ArticleInitializer : DropCreateDatabaseIfModelChanges<ArticleContext>
    {
        //I just placed this here so that it serves as reference, as my purpose here is to make Code-First with EF Migrations
        protected override void Seed(ArticleContext context)
        {
            var articles = new List<Article>()
            {
                new Article{ Id = 1, Name = "Razer Whatever", Price = 420.00},
            new Article { Id = 1, Name = "Krom Kom", Price = 69.00 },
            new Article { Id = 1, Name = "Gaming Overpriced", Price = 129.99 }
        };

            articles.ForEach(a => context.Articles.Add(a));
            context.SaveChanges();

        }

    }
}