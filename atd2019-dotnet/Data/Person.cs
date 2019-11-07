using System;
using Bogus;

namespace workshop.Data
{
    public class Person
    {
        public String FirstName;
        public String LastName;
        public String ZipCode;

        public Person()
        {
            var faker = new Faker("en");
            this.FirstName = faker.Name.FirstName();
            this.LastName = faker.Name.LastName();
            this.ZipCode = faker.Address.ZipCode();
        }

        public static Person BeverlyHills()
        {
            Person person = new Person();
            person.ZipCode = "90210";
            return person;
        }
    }
}