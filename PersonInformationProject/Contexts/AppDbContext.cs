using Microsoft.EntityFrameworkCore;
using PersonInformationProject.Configurations;
using PersonInformationProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonInformationProject.Contexts
{
    public class AppDbContext:DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdressConfiguration());
            modelBuilder.ApplyConfiguration(new PersonConfiguration());
        }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Adress> Adresses { get; set; }
    }
}
