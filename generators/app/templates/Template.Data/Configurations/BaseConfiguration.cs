using Template.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Data.Configurations
{
    public class BaseConfiguration<T> where T : BaseModel
    {
        public BaseConfiguration(EntityTypeBuilder<T> builder)
        {
            builder
                .HasKey(t => t.Id);


            builder
                .Property(m => m.Id)
                .UseIdentityColumn();
            builder.Property(c => c.CreatorUserId)
             .IsRequired();
            builder
              .Property(m => m.CreateDate)
              .IsRequired()
              .HasDefaultValueSql("getDate()");

            builder
              .Property(m => m.CreatorUserId)
              .IsRequired();
        }
    }
}
