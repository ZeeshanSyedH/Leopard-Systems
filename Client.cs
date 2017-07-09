using System;

public class Client
{
    private Guid _clientId;
    private string
        _organizationName,
        _personInCharge,
        _deptartmentInCharge,
        _address,
        _city,
        _zip,
        _phone,
        _emailAddress;

    #region Public Properties
    public Guid ClientID { get { return _clientId; } }
    public string OrganizationName
    {
        get { return _organizationName; }
        set
        {
            if (!string.Equals(_organizationName, value))
                _organizationName = value;
        }
    }

    public string PersonResponsible
    {
        get { return _personInCharge; }
        set
        {
            if (!string.Equals(_personInCharge, value))
                _personInCharge = value;
        }
    }

    public string DepartmentResponsible
    {
        get { return _deptartmentInCharge; }
        set
        {
            if (!string.Equals(_deptartmentInCharge, value))
                _deptartmentInCharge = value;
        }
    }

    public string CivicAndStreetAddress
    {
        get { return _address; }
        set
        {
            if (!string.Equals(_address, value))
                _address = value;
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

    public string Phone
    {
        get { return _phone; }
        set
        {
            if (!string.Equals(_phone, value))
                _phone = value;
        }
    }

    public string Email
    {
        get { return _emailAddress; }
        set
        {
            if (!string.Equals(_emailAddress, value))
                _emailAddress = value;
        }
    }
    #endregion

    public Client(string OrganizationName, string OptionalPersonInCharge = "", string OptionalDepartmentInCharge = "",
        string CivicAndStreetAddress, string City, string ZipCode, string PhoneNumber, string EmailAddress)
    {
        _clientId = new Guid();
        this.OrganizationName = OrganizationName;
        this.PersonResponsible = OptionalPersonInCharge;
        this.DepartmentResponsible = OptionalDepartmentInCharge;
        this.CivicAndStreetAddress = CivicAndStreetAddress;
        this.City = City;
        this.ZipCode = ZipCode;
        this.Phone = Phone;
        this.Email = Email;
    }
}
