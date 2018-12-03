using System;
namespace GardenMembership.SharedKernel.Validation
{
    public static class Guard
    {
        public static void AgainstArgumentNull(object target)
        {
            if (target == null) throw new ArgumentNullException(nameof(target));
        }

        public static void AgainstEmptyGuid(Guid target)
        {
            if (target == Guid.Empty) throw new  ArgumentException("Guid can't be empty");
        }
    }
}
