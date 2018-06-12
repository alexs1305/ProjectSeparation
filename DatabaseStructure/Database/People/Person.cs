using System;
using System.Collections.Generic;

namespace Database.People
{
    public class Person
    {
        public Guid Id { get; set; } 
        public string Forename { get; set; }
        public ICollection<OtherName> OtherNames { get; set; }
        public string Surname { get; set; }
        public Gender Gender { get; set; }
    }
}
