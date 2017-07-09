using Models;
using Models.Invoice;
using System;
using System.Collections.Generic;
using static LS.BL.Enums.GlobalEnums;

public class Invoice
{
    #region Private Properties
    private Guid _invoiceId;
    private DateTime _CreatedOn;

    private Guid _clientId;
    private Client _client;

    private Guid _employeeId;
    private Employee _createdBy;

    private List<ItemizedDescription> _descriptions;
    private CurrencyTypes _currencyType;

    private Guid _freightId;
    private Freight _freightDetails;
    private string _invoiceComments;
    #endregion

    #region Public Properties

    public Guid InvoiceID
    {
        get { return _invoiceId; }
    }

    public Client Client
    {
        get { return _client; }
        set
        {
            if (object.Equals(_client, value)) return;
            _client = value;
            _clientId = Client.ClientID;
        }
    }

    public DateTime CreatedOn { get { return _CreatedOn; } }

    public List<ItemizedDescription> Descriptions
    {
        get { return _descriptions; }
        set
        {
            if (!object.Equals(_descriptions, value))
                _descriptions = value;
        }
    }

    public CurrencyTypes Currency
    {
        get { return _currencyType; }
        set { if (!object.Equals(_currencyType, value)) _currencyType = value; }
    }

    public Employee Employee
    {
        get { return _createdBy; }
        set
        {
            if (object.Equals(_createdBy, value)) return;
            _createdBy = value;
            _employeeId = Employee.EmployeeID;
        }
    }

    public Freight FreightDetails
    {
        get { return _freightDetails; }
        set
        {
            if (object.Equals(_freightDetails, value)) return;
            _freightDetails = value;
            _freightId = FreightDetails.FreightID;
        }
    }

    public string InvoiceComments
    {
        get { return _invoiceComments; }
        set
        {
            if (!object.Equals(_invoiceComments, value))
                _invoiceComments = value;
        }
    }

    #endregion

    public Invoice(Client Client, Employee CreatedByEmployee, List<ItemizedDescription> Descriptions, CurrencyTypes Currency,
        Freight FreightDetails, string OptionalInvoiceComments = "Thank you for your business !")
    {
        _invoiceId = new Guid();
        _CreatedOn = DateTime.Now;
        this.Client = Client;
        this.Employee = CreatedByEmployee;
        this.Descriptions = Descriptions;
        this.Currency = Currency;
        this.FreightDetails = FreightDetails;
        this.InvoiceComments = OptionalInvoiceComments;
    }
    public Invoice()
    {
    }


}