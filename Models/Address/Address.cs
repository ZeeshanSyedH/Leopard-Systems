using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Models.Address
{
    public class Address
    {
        private string _civic, _street, _city, _zip, _country;

        #region Public Properties
        public string Civic
        {
            get { return _civic; }
            set
            {
                if (!string.Equals(_civic, value))
                    _civic = value;
            }
        }
        public string Street
        {
            get { return _street; }
            set
            {
                if (!string.Equals(_street, value))
                    _street = value;
            }
        }
        public string City
        {
            get { return _city; }
            set
            {
                if (!string.Equals(_city, value))
                    _city = value;
            }
        }
        public string ZipCode
        {
            get { return _zip; }
            set
            {
                if (!string.Equals(_zip, value))
                    _zip = value;
            }
        }
        public string Country
        {
            get { return _country; }
            set
            {
                if (!string.Equals(_country, value))
                    _country = value;
            }
        }
        #endregion

        public Address(string CivicNumber, string Street, string City, string ZipCode, string Country)
        {
            this.Civic = CivicNumber;
            this.Street = Street;
            this.City = City;
            this.ZipCode = ZipCode;
            this.Country = Country;
        }

    }
}
