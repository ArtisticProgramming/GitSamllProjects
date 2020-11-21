using CodeNet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNet.Infrastructure.SchemaDefinitions
{
    public class CodeNoteDetailEntitySchemaConfiguration : IEntityTypeConfiguration<CodeNoteDetail>
    {
        public void Configure(EntityTypeBuilder<CodeNoteDetail> builder)
        {
            builder.ToTable("CodeNoteDetail");

            builder.HasKey(x => x.Id);
          
        }
    }
}
