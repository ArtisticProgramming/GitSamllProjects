using CodeNet.Domain.Entities;
using CodeNet.Domain.Mappers;
using CodeNet.Domain.Mappers.Interfaces;
using CodeNet.Domain.Repositories;
using CodeNet.Domain.Responses;
using CodeNet.Domain.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeNet.Domain.Services
{
    public class CodeNoteService : ICodeNoteService
    {
        private readonly ICodeNoteRepository _codeNoteRepository;
        private readonly ICodeNoteMapper _codeNoteMapper;
        public CodeNoteService(ICodeNoteRepository codeNoteRepository, ICodeNoteMapper codeNoteMapper)
        {
            _codeNoteRepository = codeNoteRepository;
            _codeNoteMapper = codeNoteMapper;
        }

        public async Task<IEnumerable<CodeNoteResponse>> GetCodeNetAsync()
        {
            var codeNotes = await _codeNoteRepository.GetAsync();
            var responses = codeNotes.Select(x => _codeNoteMapper.Map(x));
            
            return responses;
        }
    }
}
