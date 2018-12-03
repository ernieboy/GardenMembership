using System;
using GardenMembership.Domain.Model.Enums;
using GardenMembership.SharedKernel.Validation;

namespace GardenMembership.Domain.Model
{
    public class Person : BaseEntity
    {
        public PersonTitleEnum Title { get; private set; }

        public string Forename { get; private set; }

        public string Surname { get; private set; }

        public DateTime DateOfBirth { get; private set; }

        public Address Address { get; protected set; }

        public void SetAddress(Address newAddress)
        {
            Guard.AgainstArgumentNull(newAddress);
        }

    }
}
