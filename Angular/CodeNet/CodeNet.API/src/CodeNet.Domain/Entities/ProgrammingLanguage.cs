using CodeNet.Domain.Entities.BaseClasses;
using System.Collections.Generic;

namespace CodeNet.Domain.Entities
{
    public class ProgrammingLanguage
    {
        public long Id { get; set; }
        public string Name { get; set; }

        public ICollection<CodeNoteDetail> CodeNoteDetails { get; set; }

    }
}