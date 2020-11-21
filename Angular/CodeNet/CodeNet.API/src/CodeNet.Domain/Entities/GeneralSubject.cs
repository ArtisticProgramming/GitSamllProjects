using CodeNet.Domain.Entities.BaseClasses;
using System.Collections.Generic;

namespace CodeNet.Domain.Entities
{
    public class GeneralSubject 
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long UserId { get; set; }
        public User User { get; set; }

        public ICollection<CodeNote> CodeNotes { get; set; }
        public ICollection<SpecificSubject> SpecificSubjects { get; set; }
    }
}