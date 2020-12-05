using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodeNet.Domain.Entities;
using CodeNet.Domain.Responses;
using CodeNet.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CodeNet.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CodeNoteController : ControllerBase
    {
        private readonly ICodeNoteService _codeNoteService;
        public CodeNoteController(ICodeNoteService codeNoteService)
        {
            _codeNoteService = codeNoteService;
        }

        [HttpGet]
        public async Task<IEnumerable<CodeNoteResponse>> Get()
        {
            return await _codeNoteService.GetCodeNetAsync();
        }

        // GET api/<CodeNoteController>/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

    }
}
