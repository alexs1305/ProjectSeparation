using System.Collections.Generic;
using Database.People;

namespace Business
{
    public class People
    {
        public IEnumerable<Person> AllPeople()
        {
            return new List<Person>{new Person(){Forename = "John", Surname = "Doe"}};
        }
    }
}
