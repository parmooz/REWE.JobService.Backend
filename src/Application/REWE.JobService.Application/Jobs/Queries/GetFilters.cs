using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace REWE.JobService.Application.Jobs.Queries
{
    public record GetFilters:IRequest
    {
        public string AccountingCompanyId { get; init; } = default!;
        public List<string> AccountingCompanyIds { get; init; } = default!;
        public List<int> jobGroupIds { get; init; } = default!;
        public List<int> subJobGroupIds { get; init; } = default!;
        public List<int> jobTypeIds { get; init; } = default!;
        public List<string> provinceIdList { get; init; } = default!;
        public List<string> districtIdList { get; init; } = default!;
        public string employmentLevelId { get; init; } = default!;
        public string searchTerm { get; init; } = default!;
        public List<string> jobLevels { get; init; } = default!;
        public string jobDescriptionId { get; init; } = default!;//AccountingComany + JobType + JobNumber + PaymentClass,
        public List<string> cityList { get; init; } = default!;
        public string zip { get; init; } = default!;
        public int minWorkingHours { get; init; } = default!;
        public int maxWorkingHours { get; init; } = default!;
        public int offset { get; init; } = default!;// the number of entries to skip when paging
        public int limit { get; init; } = default!;//the maximum number of entries to return,
        public string sortField { get; init; } = default!;//field the response should be sorted by = ['Relevancy', 'Title', 'City', 'EmploymentLevel', 'AccountingCompany', 'CreationDate']
        public string sortDirection { get; init; } = default!;// order in which it should be sorted = ['Ascending', 'Descending']
        public bool includeInternal { get; init; } = default!;//wether to include internal jobs in the search

    }

}
