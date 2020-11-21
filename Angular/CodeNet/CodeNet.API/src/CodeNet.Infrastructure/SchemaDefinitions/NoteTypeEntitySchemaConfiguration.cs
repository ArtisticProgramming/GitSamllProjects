using CodeNet.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;


namespace CodeNet.Infrastructure.SchemaDefinitions
{
    public class NoteTypeEntitySchemaConfiguration : IEntityTypeConfiguration<NoteType>
    {
        public void Configure(EntityTypeBuilder<NoteType> builder)
        {
            builder.ToTable("NoteType");

            builder.HasKey(x => x.Id);


        }
    }
}
