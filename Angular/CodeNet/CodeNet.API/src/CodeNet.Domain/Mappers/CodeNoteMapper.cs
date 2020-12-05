using CodeNet.Domain.Entities;
using CodeNet.Domain.Mappers.Interfaces;
using CodeNet.Domain.Requests;
using CodeNet.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNet.Domain.Mappers
{
    public class CodeNoteMapper : ICodeNoteMapper
    {
        public CodeNoteResponse Map(CodeNote source)
        {
            return new CodeNoteResponse
            {
                Id = source.Id,
                Title = source.Title,
                Description = source.Description,
                ProjectId = source.ProjectId,
                NoteTypeId = source.NoteTypeId,
                GeneralSubjectId = source.GeneralSubjectId,
                SpecificSubjectId = source.SpecificSubjectId,
                IsBookMarked = source.IsBookMarked,
                CreatedDate = source.CreatedDate,
                ModifiedDate = source.ModifiedDate,
                UserId = source.UserId,
            };
        }

        public CodeNote Map(CodeNoteRequest source)
        {
            return new CodeNote
            {
                Id = source.Id,
                Title = source.Title,
                Description = source.Description,
                ProjectId = source.ProjectId,
                NoteTypeId = source.NoteTypeId,
                GeneralSubjectId = source.GeneralSubjectId,
                SpecificSubjectId = source.SpecificSubjectId,
                IsBookMarked = source.IsBookMarked,
                CreatedDate = source.CreatedDate,
                ModifiedDate = source.ModifiedDate,
                UserId = source.UserId,
            };
        }
    }
}
