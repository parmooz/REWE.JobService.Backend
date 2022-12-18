using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REWE.JobService.Application.Jobs.Queries
{
    public class JobSearchHandler : IRequestHandler<GetJobs>
    {
        public Task<Unit> Handle(GetJobs request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
