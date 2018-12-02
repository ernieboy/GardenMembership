using GardenMembership.Domain.Model.Enums;

namespace GardenMembership.Domain.Model
{
    public abstract class Person : BaseEntity
    {
        public PersonTitleEnum Title { get; private set; }

    }
}
