using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CodeNet.Domain.Entities;
using CodeNet.Domain.Repositories.BaseClasses;

namespace CodeNet.Domain.Repositories
{
    public interface ICodeNoteRepository : IRepository
    {
        Task<IEnumerable<CodeNote>> GetAsync();
        Task<CodeNote> GetAsync(long Id);
        CodeNote Add(CodeNote codeNote);

    }
}
