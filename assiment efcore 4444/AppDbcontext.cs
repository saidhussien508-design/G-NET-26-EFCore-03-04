using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assiment_efcore_4444
{
    #region AppDbcontext
    public class AppDbcontext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.; Database=assiment3-4; Trusted_Connection=True; TrustServerCertificate=True");
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<branch>().HasOne(x => x.Manger).WithOne(s => s.branch).HasForeignKey<branch>(o => o.mangerid);
            modelBuilder.Entity<customerAcount>().HasKey(sc => new {sc.customerid,sc.accountid});
            modelBuilder.Entity<Transaction>().HasOne(x => x.account).WithMany(z => z.Transaction).HasForeignKey(s => s.accountid);
            modelBuilder.Entity<account>().HasOne(x => x.branch).WithMany(s => s.accounts).HasForeignKey(o => o.branchid);
           
        }

        public DbSet<branch> branches { get; set; }
        public DbSet<Manger> manger { get; set; }
        public DbSet<Customer> customers { get;}

        public DbSet<account> accounts { get;}
        public DbSet<Transaction> transactions { get; set; }
    }
    #endregion
 }
