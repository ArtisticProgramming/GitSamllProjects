using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace MediatR.Api.Model.Commands
{
    public class CreateTestCommandHandler : IRequestHandler<CreateTestCommand, string>
    {
        public Task<string> Handle(CreateTestCommand request, CancellationToken cancellationToken)
        {
            Console.WriteLine($"Id is {request.Id}, Name is {request.Name}");

            return Task.FromResult(request.Name);
        }
    }
}
