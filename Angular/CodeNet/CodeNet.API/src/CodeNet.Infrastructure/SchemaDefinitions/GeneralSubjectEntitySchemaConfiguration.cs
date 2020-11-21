using CodeNet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNet.Infrastructure.SchemaDefinitions
{
    public class GeneralSubjectEntitySchemaConfiguration : IEntityTypeConfiguration<GeneralSubject>
    {
        public void Configure(EntityTypeBuilder<GeneralSubject> builder)
        {
            builder.ToTable("GeneralSubject");

            builder.HasKey(x => x.Id);

        }
    }
}
