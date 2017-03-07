using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Sadik_Ymm.Areas.Yazar.Models
{
    public class MakaleVerileri : DbContext
    {
         public MakaleVerileri()
            : base("server=CASPER;database=MakaleVerileri;Integrated Security = SSPI;")
        {

        }
        public DbSet<Yazar> Yazar { get; set; }

        public DbSet<Makale> Makale { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }

      
    }
}