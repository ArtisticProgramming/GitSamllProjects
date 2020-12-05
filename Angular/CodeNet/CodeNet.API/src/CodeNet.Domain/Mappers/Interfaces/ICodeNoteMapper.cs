using CodeNet.Domain.Entities;
using CodeNet.Domain.Requests;
using CodeNet.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodeNet.Domain.Mappers.Interfaces
{
    public interface ICodeNoteMapper
    {
        CodeNoteResponse Map(CodeNote source);
        CodeNote Map(CodeNoteRequest source);
    }
}
