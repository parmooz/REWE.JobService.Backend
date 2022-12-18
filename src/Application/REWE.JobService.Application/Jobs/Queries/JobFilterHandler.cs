using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REWE.JobService.Application.Jobs.Queries
{
    public class JobFilterHandler : IRequestHandler<GetFilters>
    {
        public Task<Unit> Handle(GetFilters request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
