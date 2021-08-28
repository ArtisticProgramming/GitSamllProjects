using CodeNote.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNote.Domain.Entities
{
    public class Code : EntityBase
    {
        public long Description { get; set; }
        public string CodeSnippet { get; set; }
        public string ProgrammingLanguages { get; set; }
        public NoteCode NoteCode { get; set; }
    }
}
