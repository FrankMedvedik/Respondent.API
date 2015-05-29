using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Respondent.Repository
{
    public partial class Person
    {
        public Person()
        {
            this.Phones = new HashSet<Phone>();
        }
    
        public System.Guid PersonId { get; set; }
        public string NamePrefix { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string NameSuffix { get; set; }
        public string Title { get; set; }
        public Nullable<System.DateTime> BirthDate { get; set; }
        public string GenderCode { get; set; }
        public Nullable<int> DataSourceId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public System.DateTime UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public string CreateUser { get; set; }
        public System.DateTime CreateDate { get; set; }
        public string ContactPrefCode { get; set; }
    
        public virtual ICollection<Phone> Phones { get; set; }
    }
}

