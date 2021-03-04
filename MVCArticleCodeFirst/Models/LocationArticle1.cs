using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCArticleCodeFirst.Models
{
    public class LocationArticle
    {

        public int Location_Id { get; set; }

        public int Article_Id { get; set; } 
    }
}