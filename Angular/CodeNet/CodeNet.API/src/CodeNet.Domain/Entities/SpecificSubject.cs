using CodeNet.Domain.Entities.BaseClasses;
using System.Collections.Generic;

namespace CodeNet.Domain.Entities
{
    public class SpecificSubject 
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public long GeneralSubjectId { get; set; }
        public GeneralSubject GeneralSubject { get; set; }
        public ICollection<CodeNote> CodeNotes { get; set; }
    }
}