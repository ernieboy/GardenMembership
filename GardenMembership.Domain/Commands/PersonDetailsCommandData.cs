using System;

namespace GardenMembership.Domain.Commands
{
    public class PersonDetailsCommandData
    {
        public string Title { get; set; }

        public string Forename { get; set; }

        public string Surname { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string Country { get; set; }

        public string PostCodeOrZipCode { get; set; }
    }
}
