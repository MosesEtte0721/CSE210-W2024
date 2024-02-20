using System;

public class CompanyContact: CheckIn
{
    private long _helpDeskPhone;
    private string _helpDeskEmail;
    private long _whatsApp;

    private long _opManagerPhone;
    private string _opEmail;
    private string _opFirstName;
    private string _opLastName;
    private string _address;
    private string _state;
    private string _country;

    private long _hdQuatersPhone;

    // public CompanyContact(long helpPhone, string helpEmail, long whatsapp)
    // {
    //     this._helpDeskEmail = helpEmail;
    //     this._helpDeskPhone = helpPhone;
    //     this._whatsApp = whatsapp;
    // }
    
    public CompanyContact(string opFirstName, string opLastName, string opEmail, long opManagerPhone) 
    {
        this._opFirstName = opFirstName;
        this._opLastName =  opLastName;
        this._opEmail = opEmail;
        this._opManagerPhone = opManagerPhone;
    }
   
  

    public CompanyContact( long helpPhone, string helpEmail, long whatsapp, string address = "N/A", string state = "Akwa Ibom", string country = "Nigeria")
    {
        this._helpDeskEmail = helpEmail;
        this._helpDeskPhone = helpPhone;
        this._whatsApp = whatsapp;
        this._address = address;
        this._state = state;
        this._country = country;
    }
    public void HelpDesk()
    {
        Console.WriteLine("Contact the HelpDesk: ");
       Console.WriteLine ($"Email: {this._helpDeskEmail} \nWhatsApp: {this._whatsApp} \nPhone: {this._helpDeskPhone}");
    }

    public override string Name()
    {
        return $"{this._opFirstName} {this._opLastName}";
    }
    public  void OperationalManager()
    {
        Console.WriteLine("Contact the Operational Manager ");
        Console.WriteLine($"{this.Name()}");
        Console.WriteLine($"Email: {this._opEmail} \nPhone: {this._phone}");
        
    }

    public override string Address()
    {
        return $"{this._address}, {this._state}, {this._country}";
    }

    public long SetAndGetHqPhone
    {
        get {return this._hdQuatersPhone;}
        set{this._hdQuatersPhone = value;}
    }

    public void HqInfo()
    {
         this._hdQuatersPhone = 080585950585859;
        Console.WriteLine($"Address: {this.Address()} \nPhone: {this._hdQuatersPhone}");
    }

    
}