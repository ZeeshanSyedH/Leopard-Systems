using Models.Address;
using System;

public class Client
{
    private Guid _clientId;
    private Address _address;
    private string
        _organizationName,
        _personInCharge,
        _deptartmentInCharge,
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

    public Address Address
    {
        get { return _address; }
        set
        {
            if (!string.Equals(_address, value))
                _address = value;
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

    public Client(string OrganizationName, Address Address, string PhoneNumber, 
        string EmailAddress, string OptionalPersonInCharge = "", string OptionalDepartmentInCharge = "")
    {
        _clientId = new Guid();
        this.OrganizationName = OrganizationName;
        this.PersonResponsible = OptionalPersonInCharge;
        this.DepartmentResponsible = OptionalDepartmentInCharge;
        this.Address = Address;
        this.Phone = Phone;
        this.Email = Email;
    }
}
