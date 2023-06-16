using MediatR;
using Microsoft.AspNetCore.Http.Features;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repository.Queries
{
    public class GetByIdQuery<T>: IRequest<T>
    {
        public int Id { get; set; }
    }
}
