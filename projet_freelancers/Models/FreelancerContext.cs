using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace projet_freelancers.Models
{
    public class FreelancerContext : DbContext
    {
        public DbSet<freelancer> freelancer { get; set; }
    }
}