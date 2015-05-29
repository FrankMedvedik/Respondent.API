using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Breeze.ContextProvider;
using Breeze.WebApi2;
using Newtonsoft.Json.Linq;
using Respondent.Respository;

namespace Respondent.API.Controllers
{
    [BreezeController]
    public class BreezeController : ApiController
    {
        private readonly IRepository _repo = new Repository();
        //public BreezeController(IRepository repo)
        //{
        //    _repo = repo;
        //}
        [HttpGet]
        public string Metadata()
        {
            return _repo.Metadata;

        }
        [HttpPost]
        public SaveResult SaveChanges(JObject saveBundle)
        {
            return _repo.SaveChanges(saveBundle);
        }

        [HttpGet]
        public IQueryable<Person> People()
        {
            return _repo.People();
        }
        [HttpGet]
        public IQueryable<Phone> Phones()
        {
            return _repo.Phones();
        }

    }
}
