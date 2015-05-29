using System.Linq;
using Breeze.ContextProvider;
using Newtonsoft.Json.Linq;
using Respondent.Respository;

namespace Respondent.API
{
    public interface IRepository
    {
        string Metadata { get; }
        SaveResult SaveChanges(JObject saveBundle);
        IQueryable<Person> People();
        IQueryable<Phone> Phones();

    }
}