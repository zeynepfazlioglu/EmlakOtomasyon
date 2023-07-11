using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Emlak.Otomasyon.Domain
{
    public class EmlakDbContext : DbContext
    {
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);
        //}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Server=.\\SQLEXPRESS;Initial Catalog=EmlakDb;Integrated Security=SSPI;TrustServerCertificate =true;");
            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Model.Entity.Emlak> Emlak { get; set; }
    }
}
