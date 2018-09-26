using EpsilonBank.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Linq;
using System.Web;

namespace EpsilonBank.DAL
{
    public class BankContext : DbContext
    {

        public BankContext() : base("name=BankContext")
        {

        }

        public DbSet<Detail> TBL_Detail { get; set; }
        public DbSet<Account> TBL_Account { get; set; }
        public DbSet<Transaction> TBL_Transaction { get; set; }
        public DbSet<Login> TBL_Login { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

    }
}