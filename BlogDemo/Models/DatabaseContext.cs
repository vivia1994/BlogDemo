using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogDemo.Models
{
    public class DatabaseContext : DbContext
    {
        public DbSet<Article> Articles { get; set; }
    }
}