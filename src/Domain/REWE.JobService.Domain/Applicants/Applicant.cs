using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REWE.JobService.Domain.Applicants
{
    public class Applicant
    {
        public string  TitleCode { get; init; }
        public string FirstName { get; init; }
        public string LastName { get; init; }
        public string Gender { get; init; }
        public string Nationality { get; init; }
        public string TelephoneNumber { get; init; }
        public string Email { get; init; }

        public DateTime BirthDate { get; init; }

        public string CountryCode { get; init; }

        public string Zip { get; init; }
        public string City { get; init; }
        public bool WorkPermit { get; init; }
        public string DriversLincenseClasses { get; init; }
        public bool EmployedBefore { get; init; }
        public bool MilitaryServiceFinished { get; init; }

        public IEnumerable<Document> Documents { get; init;}


    }
}

