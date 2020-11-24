using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using CodeNet.Domain.Entities;
using CodeNet.Infrastructure.SchemaDefinitions;
using CodeNet.Domain.Repositories.BaseClasses;
using System.Threading.Tasks;
using System.Threading;

namespace CodeNet.Infrastructure
{
   public class CodeNetContext : DbContext, IUnitOfWork
    {
        public DbSet<CodeNote> CodeNote { get; set; }
        public DbSet<CodeNoteDetail> CodeNoteDetail { get; set; }
        public DbSet<GeneralSubject> GeneralSubject { get; set; }
        public DbSet<SpecificSubject> SpecificSubject { get; set; }
        public DbSet<NoteType> NoteType { get; set; }
        public DbSet<ProgrammingLanguage> ProgrammingLanguage { get; set; }
        public DbSet<Project> Project { get; set; }
        public DbSet<User> User { get; set; }

        public CodeNetContext(DbContextOptions<CodeNetContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CodeNoteDetailEntitySchemaConfiguration());
            modelBuilder.ApplyConfiguration(new CodeNoteEntitySchemaConfiguration());
            modelBuilder.ApplyConfiguration(new GeneralSubjectEntitySchemaConfiguration());
            modelBuilder.ApplyConfiguration(new NoteTypeEntitySchemaConfiguration());
            modelBuilder.ApplyConfiguration(new ProgrammingLanguageEntitySchemaConfiguration());
            modelBuilder.ApplyConfiguration(new ProjectEntitySchemaConfiguration());
            modelBuilder.ApplyConfiguration(new SpecificSubjectEntitySchemaConfiguration());
            modelBuilder.ApplyConfiguration(new UserEntitySchemaConfiguration());

            base.OnModelCreating(modelBuilder);
        }

        public async Task<bool> SaveEntitiesAsync(CancellationToken cancellationToken = default)
        {
            await base.SaveChangesAsync(cancellationToken);
            return true;
        }
    }
}

