using System;
using GardenMembership.SharedKernel.Interfaces;
using GardenMembership.SharedKernel.Validation;

namespace GardenMembership.Domain.Model
{
    public abstract class BaseEntity
    {
        protected BaseEntity()
        {
            UpdateGuid(Guid.NewGuid());
            DateCreated = DateTime.Now;
        }

        public int Id { get; protected set; }

        public Guid Guid { get; private set; }

        public DateTime DateCreated { get; private set; }

        public DateTime? DateModified { get; private set; }

        public ObjectState ObjectState { get; private set; }

        public byte[] RowVersion { get; private set; }

        public bool? Deleted { get; private set; }

        protected void UpdateGuid(Guid newGuid)
        {
            Guard.AgainstEmptyGuid(newGuid);
            Guid = newGuid;
        }

        protected void UpdateObjectState(ObjectState newObjectState)
        {
            ObjectState = newObjectState;
        }

        protected void UpdateDateModified(DateTime modifiedDate)
        {
            DateModified = modifiedDate;
        }
    }
}
