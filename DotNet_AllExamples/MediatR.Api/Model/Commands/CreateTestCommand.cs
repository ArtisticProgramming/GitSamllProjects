using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MediatR.Api.Model.Commands
{
    public class CreateTestCommand : IRequest<string>
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
