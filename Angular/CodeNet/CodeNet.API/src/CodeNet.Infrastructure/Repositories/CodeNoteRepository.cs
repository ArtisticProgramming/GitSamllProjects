using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using CodeNet.Domain.Entities;
using CodeNet.Domain.Repositories;
using Microsoft.EntityFrameworkCore;
using CodeNet.Domain.Repositories.BaseClasses;
using System.Linq;

namespace CodeNet.Infrastructure.Repositories
{
    public class CodeNoteRepository : ICodeNoteRepository
    {
        private readonly CodeNetContext _codeNetContext;
        public IUnitOfWork UnitOfWork => _codeNetContext;

        public CodeNoteRepository(CodeNetContext catalogContext)
        {
            _codeNetContext = catalogContext;
        }

        public CodeNote Add(CodeNote codeNote)
        {
            return _codeNetContext.CodeNote.Add(codeNote).Entity;
        }

        public async Task<IEnumerable<CodeNote>> GetAsync()
        {
            var model = await _codeNetContext.CodeNote.AsNoTracking().ToListAsync();
            return model;
        }

        public async Task<CodeNote> GetAsync(long id)
        { 
            var model = await _codeNetContext.CodeNote.FindAsync(id);

            if (model == null)
                return null;

            _codeNetContext.Entry(model).State = EntityState.Detached;

            return model;
        }
    }
}