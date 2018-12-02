using System;
using GardenMembership.SharedKernel.Interfaces;

namespace GardenMembership.Domain.Model
{
    public abstract class BaseEntity
    {
        public int Id { get; private set; }

        public string Guid { get; private set; }

        public DateTime DateCreated { get; private set; }

        public DateTime DateModified { get; private set; }

        public ObjectState ObjectState { get; private set; }

        public byte[] RowVersion { get; private set; }

        public bool? Deleted { get; private set; }
    }
}
