using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Commands
{
    public class CreateVacancyCommand : IRequest<Vacancy>
    {
        Vacancy entity;

        public CreateVacancyCommand(Vacancy entity)
        {
            this.entity = entity;
        }
    }
}
