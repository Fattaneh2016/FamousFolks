using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WebFamousFolks.Models
{
    public class WebFamousFolksContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public WebFamousFolksContext() : base("name=WebFamousFolksContext")
        {
        }

        public System.Data.Entity.DbSet<WebFamousFolks.Models.Folk> Folks { get; set; }
    }
}
