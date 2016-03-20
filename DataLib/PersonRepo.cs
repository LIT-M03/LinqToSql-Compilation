using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLib
{
    public class PersonRepo
    {
        private readonly string _connectionString;

        public PersonRepo(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IEnumerable<People> GetPeople()
        {
            using (var context = new PersonCarsDataContext(_connectionString))
            {
                var loadOptions = new DataLoadOptions();
                loadOptions.LoadWith<People>(p => p.Cars);
                context.LoadOptions = loadOptions;
                return context.Peoples.ToList();
            }
        } 
    }
}
