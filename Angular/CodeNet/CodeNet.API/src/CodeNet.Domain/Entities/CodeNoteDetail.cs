using System;

namespace CodeNet.Domain.Entities
{
    public class CodeNoteDetail
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public string CodeSyntax { get; set; }
        public long ProgrammingLanguageId { get; set; }
        public long CodeNoteId { get; set; }
        public ProgrammingLanguage ProgrammingLanguage { get; set; }
        public CodeNote CodeNote{ get; set; }
    }
}