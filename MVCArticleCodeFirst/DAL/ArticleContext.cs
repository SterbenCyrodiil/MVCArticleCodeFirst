using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MVCArticleCodeFirst.Models;

namespace MVCArticleCodeFirst.DAL
{
    public class ArticleContext : DbContext
    {

        public ArticleContext() : base("ArticleContext")
        {

        }

        public DbSet<Article> Articles { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}