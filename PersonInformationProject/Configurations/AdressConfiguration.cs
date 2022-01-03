using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PersonInformationProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PersonInformationProject.Configurations
{
    public class AdressConfiguration : IEntityTypeConfiguration<Adress>
    {
        public void Configure(EntityTypeBuilder<Adress> builder)
        {
            builder.Property(x => x.City).IsRequired(true).HasMaxLength(200);
            builder.Property(x => x.District).IsRequired(true).HasMaxLength(200);
            builder.Property(x => x.Content).IsRequired(true).HasMaxLength(400);
            builder.Property(x => x.Postcode).IsRequired(true);

        }
    }
}
