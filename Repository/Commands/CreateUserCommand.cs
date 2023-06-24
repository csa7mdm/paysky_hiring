using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Commands
{
    public class CreateUserCommand: IRequest<ApplicationUser>
    {
        ApplicationUser entity;

        public CreateUserCommand(ApplicationUser entity)
        {
            this.entity = entity;
        }
    }
}
