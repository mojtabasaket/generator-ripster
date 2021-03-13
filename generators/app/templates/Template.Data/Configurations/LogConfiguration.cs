using Template.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Template.Data.Configurations
{
 
    class LogConfiguration : BaseConfiguration<Log>
    {
        public LogConfiguration(EntityTypeBuilder<Log> builder) : base(builder)
        {


 

            builder
                    .ToTable("Log");

        }

    }
}
