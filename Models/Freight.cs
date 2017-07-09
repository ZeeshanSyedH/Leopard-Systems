using System;

namespace Models
{
    public class Freight
    {
        private Guid _freightId;

        private string _initialOrganizationName;
        private string _destinationOrganizationName;

        private Models.Address.Address _initialAddress;
        private Models.Address.Address _destinationAddress;

        #region Public Properties
        public Guid FreightID
        {
            get { return _freightId; }
            set
            {
                if (!object.Equals(_freightId, value))
                    _freightId = value;
            }
        }

        public string InitialOrganizationName
        {
            get { return _initialOrganizationName; }
            set
            {
                if (!string.Equals(_initialOrganizationName, value))
                    _initialOrganizationName = value;
            }
        }
        public string DestinationOrganizationName
        {
            get { return _destinationOrganizationName; }
            set
            {
                if (!string.Equals(_destinationOrganizationName, value))
                    _destinationOrganizationName = value;
            }
        }
        public Models.Address.Address InitialAddress
        {
            get { return _initialAddress; }
            set
            {
                if (!object.Equals(_initialAddress, value))
                    _initialAddress = value;
            }
        }
        public Models.Address.Address DestinationAddress
        {
            get { return _destinationAddress; }
            set
            {
                if (!object.Equals(_destinationAddress, value))
                    _destinationAddress = value;
            }
        }

        #endregion

        public Freight(string InitialOrganizationName, string DestinationOrganizationName,
            Models.Address.Address InitialAddress, Models.Address.Address DestinationAddress)
        {
            this.InitialOrganizationName = InitialOrganizationName;
            this.DestinationOrganizationName = DestinationOrganizationName;
            this.InitialAddress = InitialAddress;
            this.DestinationAddress = DestinationAddress;
        }
    }
}
