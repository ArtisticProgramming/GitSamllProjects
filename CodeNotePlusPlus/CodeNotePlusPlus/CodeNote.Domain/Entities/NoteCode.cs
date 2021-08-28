using CodeNote.Domain.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNote.Domain.Entities
{
    public class NoteCode : EntityBase
    {
        public string Title { get; set; }
        public NoteType Type { get; set; }

        public ICollection<Code> Codes { get; set; }

    }
}
