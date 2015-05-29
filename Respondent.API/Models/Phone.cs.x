using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Respondent.Repository
{
    public class Phone
    {

        public System.Guid PhoneId { get; set; }
        public string PhoneNumber { get; set; }
        public Nullable<bool> IsDefault { get; set; }
        public Nullable<System.DateTime> UpdateDate { get; set; }
        public string UpdateUser { get; set; }
        public string CreateUser { get; set; }
        public System.DateTime CreateDate { get; set; }
        public System.Guid PersonId { get; set; }
        public string PhoneTypeCode { get; set; }

        public virtual Person Person { get; set; }
    }
}