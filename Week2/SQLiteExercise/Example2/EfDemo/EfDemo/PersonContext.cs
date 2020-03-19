using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace EfDemo
{
    // this context class represents the whole database
    public class PersonContext : DbContext
    {
        // you need DbSet properties, one per table (one per type of data you want to store)
        public DbSet<Person> Persons { get; set; }
        public DbSet<Address> Addresses { get; set; }

        // in order to connect to any database (or many other kinds of data source)
        // we need a "connection string"

        // we need to give each DbContext instance a connection string...
        // one clumsy hardcoded easy one is OnConfiguring
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //there's multiple kinds of SQL
            //SQLite - lightweight, quick to set up, can store the DB in one file
            //SQL Server - Microsofts prefered version of SQL
            //  lowercase SQL server refers to any software that can provide access to SQL DB over internet
            //  SQL Server (capital) is Microsofts version of that software.

            //var connectionString = "Data Source=../../../persons.db";
            // need another package for this (Microsoft.EntityFrameworkCore.Sqlite)
            optionsBuilder.UseSqlServer(SecretConfiguration.ConnectionString);
            // ^ this line will have a compile error when you clone it because Secret config is gitignored.
            // youll have to remake the secret config everytime you pull the code.
        }
    }
}
