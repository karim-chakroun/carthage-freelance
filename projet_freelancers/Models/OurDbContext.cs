using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace projet_freelancers.Models
{
    public class OurDbContext:DbContext
    {
        public DbSet<entreprise>entreprise { get; set; }
    }
}