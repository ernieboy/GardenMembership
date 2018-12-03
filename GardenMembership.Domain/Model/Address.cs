using System.Collections.Generic;

namespace GardenMembership.Domain.Model
{
    public class Address : ValueObject
    {
        public Address(
            string addressLine1, string addressLine2, string addressLine3, string addressLine4,
            string country, string county, string town, string postcodeOrZipCode)
        {
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            AddressLine3 = addressLine3;
            AddressLine4 = addressLine4;
            Country = country;
            County = county;
            Town = town;
            PostCodeOrZipCode = postcodeOrZipCode;
        }

        public string AddressLine1 { get; private set; }
										
        public string AddressLine2 { get; private set; }
									
        public string AddressLine3 { get; private set; }
									
        public string AddressLine4 { get; private set; }

        public string Country { get; private set; }

        public string County { get; private set; }

        public string Town { get; private set; }

        public string PostCodeOrZipCode { get; private set; }

        protected override IEnumerable<object> GetAtomicValues()
        {
            yield return AddressLine1;
            yield return AddressLine2;
            yield return AddressLine3;
            yield return AddressLine4;
            yield return Country;
            yield return County;
            yield return Town;
            yield return PostCodeOrZipCode;
        }
    }
}
