using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNet.Domain.Entities
{
    public class CodeNote
    {
        public long Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public long ProjectId { get; set; }
        public long NoteTypeId { get; set; }
        public long GeneralSubjectId { get; set; }
        public long? SpecificSubjectId { get; set; }
        public bool IsBookMarked { get; set; }
        public DateTimeOffset CreatedDate { get; set; }
        public DateTimeOffset ModifiedDate { get; set; }
        public long UserId { get; set; }

        public GeneralSubject GeneralSubject { get; set; }
        public NoteType NoteType { get; set; }
        public SpecificSubject SpecificSubject { get; set; }
        public Project Project { get; set; }
        public User User { get; set; }

        public ICollection<CodeNoteDetail> CodeNetDetails { get; set; }

    }
}
