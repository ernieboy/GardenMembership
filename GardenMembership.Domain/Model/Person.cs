using GardenMembership.Domain.Model.Enums;

namespace GardenMembership.Domain.Model
{
    public abstract class Person
    {
        public PersonTitleEnum Title { get; private set; }

    }
}
