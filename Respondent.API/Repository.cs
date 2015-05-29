using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Breeze.ContextProvider;
using Breeze.ContextProvider.EF6;
using Newtonsoft.Json.Linq;
using Respondent.Respository;

namespace Respondent.API
{
    public class Repository : IRepository
    {
        private readonly EFContextProvider<RespondentWorkEntities> _ctx = new EFContextProvider<RespondentWorkEntities>();

        public string Metadata
        {
            get { return _ctx.Metadata(); }
        }

        public SaveResult SaveChanges(JObject saveBundle)
        {
               return _ctx.SaveChanges(saveBundle);
        }

        public IQueryable<Person> People()
        {
            return _ctx.Context.People;
        }

        public IQueryable<Phone> Phones()
        {
            return _ctx.Context.Phones;
        }
        
        
    }
}

