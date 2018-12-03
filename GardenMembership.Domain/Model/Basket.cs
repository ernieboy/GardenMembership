using System;
namespace GardenMembership.Domain.Model
{
    public class Basket : AggregateRoot
    {  
      public Basket(GardenMembership gardenMembership, Person payer)
        {
            GardenMembership = gardenMembership;
            Payer = payer;
        }

        public GardenMembership GardenMembership { get; protected set; }

        public Person Payer { get; protected set; }

        public bool IsProcessedInternally { get; protected set; }
    }
}
