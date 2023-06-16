using Domain.Models;
using MediatR;
using Repository.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Handlers
{
    public class CreateUserHandler : IRequestHandler<CreateUserCommand, User>
    {
        public Task<User> Handle(CreateUserCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
