using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BlogDemo.Models
{
    public class Article
    {
        public int? ArticleId { get; set; }
        public string Titel { get; set; }
        public string Content { get; set; }
    }
}