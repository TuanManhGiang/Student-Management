using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Student_manged.Domain.Entities;

namespace Student_manged.Infrastructure.Persistence.Configurations;
public class StudentConfiguration : IEntityTypeConfiguration<Student>
{
    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.HasKey(c => c.Id);
        builder.Property(c => c.Id)
        .UseIdentityColumn(); // Enables auto-increment for the ID column
        

        builder.Property(c => c.Name).HasConversion(typeof(string));
        builder.Property(c => c.Name).HasMaxLength(100);
        builder.HasIndex(c => c.Email).IsUnique(true);
    }
}
