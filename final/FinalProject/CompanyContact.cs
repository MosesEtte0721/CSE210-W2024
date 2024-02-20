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
    private Dictionary<string, string> _CompanyInfo = new Dictionary<string, string>();

    public CompanyContact(string opFirstName, string opLastName, string opEmail, long opManagerPhone) 
    {
        this._opFirstName = opFirstName;
        this._opLastName =  opLastName;
        this._opEmail = opEmail;
        this._opManagerPhone = opManagerPhone;
    }

    public CompanyContact( long helpPhone, string helpEmail, long whatsapp, string opFirstName = "Ekom-Obong", string opLastName = "Inam", string opEmail = "e.inam@mosarch.com", long opManagerPhone = 9848484884, string address = "N/A", string state = "Akwa Ibom", string country = "Nigeria")
    {
        this._helpDeskEmail = helpEmail;
        this._helpDeskPhone = helpPhone;
        this._whatsApp = whatsapp;
        this._address = address;
        this._state = state;
        this._country = country;
        this._opFirstName = opFirstName;
        this._opLastName = opLastName;
        this._opEmail = opEmail;
        this._opManagerPhone = opManagerPhone;
    }

    public void AddToDictionary(string param1, string param2)
    {
        this._CompanyInfo.Add(param1, param2);
    }
    public string HelpDesk()
    {
       return ($"  Email: {this._helpDeskEmail} \n   WhatsApp: {this._whatsApp} \n   Phone: {this._helpDeskPhone}");
    }

    public override string Name()
    {
        return $"{this._opFirstName} {this._opLastName}";
    }
    public  string OperationalManager()
    {
      
        return($"  Name: {this.Name()}, \n  Email: {this._opEmail} \n  Phone: {this._opManagerPhone}");
        
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

    public string HqInfo()
    {
         this._hdQuatersPhone = 080585950585859;
        return($"  Address: {this.Address()} \n  Phone: {this._hdQuatersPhone}");
    }


    public override void ExecuteClass()
    {
        Console.WriteLine("Contact informatin of our Company ".ToUpper());
        Console.WriteLine("For further Enquiries, you can contact our Headquarters, Helpdesk, and Operational Manager ");
        this.AddToDictionary("HelpDesk: \n".ToUpper(), this.HelpDesk());
        this.AddToDictionary("Operation Manager: \n".ToUpper(), this.OperationalManager());
        this.AddToDictionary("HeadQuaters Contact: \n".ToUpper(), this.HqInfo());


    }

    public void DisplayCompanyInfo()
    {
        foreach(KeyValuePair<string, string> info in this._CompanyInfo)
        {
            Console.WriteLine($"{info.Key} {info.Value} \n");
        }
        
    }
}