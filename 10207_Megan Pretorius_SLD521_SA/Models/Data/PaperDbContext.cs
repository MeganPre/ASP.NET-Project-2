using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _10207_Megan_Pretorius_SLD521_SA.Models.Data
{
    public class PaperDbContext: DbContext
    {
        public PaperDbContext()
            : base("PaperConnection")
            { }
        public DbSet<Paper> papers { get; set; }
        public DbSet<Topic> topics { get; set; }
    }
}