using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace _10207_Megan_Pretorius_SLD521_SA.Models.Data
{
    public class DataDbContext: DbContext
    {
        public DataDbContext()
            : base("DataConnection")
        { }

        //public DbSet<Datas> datas { get; set; }
    }
}