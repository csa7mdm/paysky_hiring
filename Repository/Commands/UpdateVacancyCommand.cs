using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Commands
{
    public class UpdateVacancyCommand : IRequest<Vacancy>
    {
        public Vacancy entity { get; set; }

        public UpdateVacancyCommand(Vacancy entity)
        {
            this.entity = entity;
        }
    }
}
