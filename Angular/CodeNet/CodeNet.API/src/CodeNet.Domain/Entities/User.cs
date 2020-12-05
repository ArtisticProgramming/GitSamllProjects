using CodeNet.Domain.Entities.BaseClasses;
using System.Collections.Generic;

namespace CodeNet.Domain.Entities
{
    public class User 
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string UserName { get; set; }
        public long IsActive { get; set; }
        public ICollection<CodeNote> CodeNotes { get; set; }
        public ICollection<NoteType> NoteTypes { get; set; }
        public ICollection<GeneralSubject> GeneralSubjects { get; set; }
        public ICollection<Project> Projects { get; set; }
    }
}