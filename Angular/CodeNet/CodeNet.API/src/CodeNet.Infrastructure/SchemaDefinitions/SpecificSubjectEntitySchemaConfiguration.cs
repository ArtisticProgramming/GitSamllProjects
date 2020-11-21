using CodeNet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNet.Infrastructure.SchemaDefinitions
{
    public class SpecificSubjectEntitySchemaConfiguration : IEntityTypeConfiguration<SpecificSubject>
    {
        public void Configure(EntityTypeBuilder<SpecificSubject> builder)
        {
            builder.ToTable("SpecificSubject");

            builder.HasKey(x => x.Id);

        }
    }
}
