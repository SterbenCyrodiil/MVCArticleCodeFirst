using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MVCArticleCodeFirst.Models
{
    public class Location
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Article { get; set; }

        [ForeignKey("ArticleI")]
        public int Article_Id { get; set; }

        public virtual Article ArticleI{get; set; }

    }
}