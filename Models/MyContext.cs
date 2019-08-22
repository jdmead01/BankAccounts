using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System;

namespace BankAccounts.Models
{
    public class MyContext : DbContext
    {
        // base() calls the parent class' constructor passing the "options" parameter along
        public MyContext(DbContextOptions options) : base(options) { }
		// "users" table is represented by this DbSet "Users"
        public DbSet<User> users {get;set;}
        public DbSet<Login> logins {get; set;}
        public DbSet<Register> registers {get; set;}
        public DbSet<Transactions> transactions {get; set;}
        public object Transactions { get; internal set; }
        //  DO THIS FOR EVERY DATABASE MODEL, ALL MODELS ARE SINGULAR PASCAL-CASE, AND ALL TABLE NAMES PLURAL PASCAL-CASE
    }
}