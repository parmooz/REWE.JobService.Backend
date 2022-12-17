using REWE.JobService.Domain.Areas;
using REWE.JobService.Domain.Common;
using REWE.JobService.Domain.Companies;
using REWE.JobService.Domain.JobGroups;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REWE.JobService.Domain.Jobs
{
    public class Job
    {
        public string Id { get; set; }
        public string Title { get; set; }

        public int Number { get; set; } 

        public string CountryCode { get; set; }
        public string ZipCode { get; set; }
        public City City { get; set; }
        public Province Province { get; set; }
        public District District { get; set; }

        public JobGroup Group { get; set; }
        public int PaymentClass { get; set; }   

        public DateTime StartDate { get; set; }
        public DateTime CreateDate { get; set; }

        public int hours { get; set; }
        public int Minhours { get; set; }

        public int AmountOfJobs { get; set; }

        public List<Store> Stores { get; set; }
        public List<Synonym> Synonyms { get; set; }

        public List<JobLevel> JobLevels { get; set; }

        public string ShortDescription { get; set; }

        public EmploymentLevel Level { get; set; }

        public JobDescription Description { get; set; }

        public JobType Type { get; set; }

        public AccountingCompany Company { get; set; }
    }
}
