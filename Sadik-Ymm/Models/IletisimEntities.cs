using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace Sadik_Ymm.Models
{
    public class IletisimEntities : DbContext
    {
        public IletisimEntities()
            : base("server=CASPER;database=IletisimVerileri;Integrated Security = SSPI;")
        {

        }
        public DbSet<Iletisim> Iletisim { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
        
    }
}