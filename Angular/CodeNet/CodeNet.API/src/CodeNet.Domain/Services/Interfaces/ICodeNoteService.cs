using CodeNet.Domain.Entities;
using CodeNet.Domain.Responses;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace CodeNet.Domain.Services.Interfaces
{
    public interface ICodeNoteService
    {
        Task<IEnumerable<CodeNoteResponse>> GetCodeNetAsync();
    }
}
