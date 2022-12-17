using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REWE.JobService.Domain.Companies
{
    public class AccountingCompany
    {
        public int Id { get; init; }
        public string Name { get; init; }

        public int DisplayId { get; init; }
        public string DisplayName { get; init; }
    }
}
