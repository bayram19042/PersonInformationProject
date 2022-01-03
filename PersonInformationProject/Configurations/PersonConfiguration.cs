using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonInformationProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonInformationProject.Configurations
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(x => x.Name).IsRequired(true).HasMaxLength(100);
            builder.Property(x => x.Surname).IsRequired(true).HasMaxLength(100);
            builder.Property(x => x.Email).IsRequired(true).HasMaxLength(150);
            builder.Property(x => x.Telephone).IsRequired(true);
            builder.HasMany(x => x.Adresses).WithOne(x => x.Person).HasForeignKey(x => x.PersonId);
            
        }
    }
}
