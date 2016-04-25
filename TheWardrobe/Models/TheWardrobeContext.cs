using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TheWardrobe.Models
{
    public class TheWardrobeContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx
    
        public TheWardrobeContext() : base("name=TheWardrobeContext")
        {
        }

        public System.Data.Entity.DbSet<TheWardrobe.Models.Tops> Tops { get; set; }

        public System.Data.Entity.DbSet<TheWardrobe.Models.Bottoms> Bottoms { get; set; }

        public System.Data.Entity.DbSet<TheWardrobe.Models.Shoes> Shoes { get; set; }

        public System.Data.Entity.DbSet<TheWardrobe.Models.Accessories> Accessories { get; set; }
    }
}
