using System;
using System.Net.Mail;

public class CheckIn
{
    private long _phone;
    private string _email;
    private string _address;
    private static int _lastClientId;
    private int _clientId;
    private string _firstName;
    private string _lastName;
    private Dictionary<string, string> _checkInDict = new Dictionary<string, string>();


    public CheckIn( string fName, string lName, string address, string email, long phone)
    {
        this._email = email;
        this._address = address;
        this._phone = phone;
        this._firstName = fName;
        this._lastName = lName;
        this._clientId = ++_lastClientId;
    }

    public CheckIn(): this(string.Empty, string.Empty, string.Empty, string.Empty, 0)
    {
        
    }

    public virtual bool AddToDictionary(string param1, string param2)
    {
         if (!_checkInDict.ContainsKey(param1))
    {
        this._checkInDict.Add(param1, param2);
        return true;
    }
    else
    {
        Console.WriteLine("The key already exists in the dictionary.");
        return false;
    }
    }
   

    public virtual string Name()
    {
        return $"{this._firstName} {this._lastName}";
    }

    public string PurposeOfVisit(string param)
    {
        // Console.WriteLine("How Can We be of Help? ");
        return param;
    }

    public bool Reference(bool param)
    {
        // Console.WriteLine("Where refered by a friend or family member? ");
        return param;
    }

    public string ClientDetails()
    {
        return $"{this._firstName} {this._lastName} \n {this._address} {this._email} {this._phone}";
    }

     public void DisplayClientDetails()
    {
        Console.WriteLine("Details of Clients ");
        Console.WriteLine($"\n{this._clientId}Name: {this._firstName} {this._lastName} \nAddress: {this._address} \nEmail: {this._email} \nPhone: {this._phone} \n{this.PurposeOfVisit} \n{this.Reference}");

    }

    public  long SetAndGetPhone
    {
        get {return this._phone;}
        set {this._phone = value;}
    }

 
    public  string SetAndGetFirstName
    {
        get{ return this._firstName;}
        set{ this._firstName = value;}
    }

     public string SetAndGetLastName
    {
        get{ return this._lastName;}
        set{ this._lastName = value;}
    }

    public string SetAndGetAddress
    {
        get{ return this._address;}
        set{ this._address = value;}
    }

    public string SetAndGetEmail
    {
        get{ return this._email;}
        set{ this._email = value;}
    }

    public virtual string Email()
    {
        return $"{this._email}";

    }

    public virtual string Address()
    {
        return $"{this._address}";
    }

    public virtual long Phone()
    {
        return this._phone;
    }

    private bool ValidEmail(string email)
{
    try
    {
        var addr = new MailAddress(email);
        return addr.Address == email;
    }
    catch
    {
        return false;
    }
}
    public virtual void ExecuteClass()
    {
        this.AddToDictionary("Session ID: ", this._clientId.ToString());
        Console.WriteLine("What is Your First Name?");
        Console.Write(">> ");
        this.SetAndGetFirstName = Console.ReadLine();

        Console.WriteLine("\nWhat is Your Last Name?");
        Console.Write(">> ");
        this.SetAndGetLastName = Console.ReadLine();
        this.AddToDictionary("Name", $"{this.SetAndGetFirstName} {this.SetAndGetLastName}");

        Console.WriteLine("\nWhat is Your Address?");
        Console.Write(">> ");
        this.SetAndGetAddress = Console.ReadLine();
        this.AddToDictionary("Address: ", $"{this.SetAndGetAddress}");
       
        

        Console.WriteLine("\nWhat is Your Phone Number? ");
        long phone;
        Console.Write(">> ");
        if(long.TryParse(Console.ReadLine(), out phone))
        {
            this.SetAndGetPhone = phone; 
            this.AddToDictionary("Phone Number: ", $"{phone}");
        } else {
            Console.WriteLine("Invalid Phone Number: ");
        }
        

        
        

        Console.WriteLine("\nWhat is Your Email Address?");
        Console.Write(">> ");
        string emailAddress = Console.ReadLine();
        if(this.ValidEmail(emailAddress))
        {
            this._email = emailAddress;
            this.AddToDictionary("Email: ", $"{this._email}");
        } else {
            Console.WriteLine("Enter a valid Email Address");
        }

        Console.WriteLine("\nHow can we be of help?");
        Console.WriteLine(">> ");
        string purpose = Console.ReadLine();
        string aim = this.PurposeOfVisit(purpose);
        this.AddToDictionary("Purpose of visit: ", $"{aim}");

        Console.WriteLine("\nWhere refered by somebody?");
        Console.WriteLine(">> ");
        string goal = Console.ReadLine().ToLower();
        bool starm;
        if(goal == "yes")
        {
            
            starm = this.Reference(true);
            this.AddToDictionary("Purpose of visit: ", $"{starm}");
        }
        else if(goal == "no")
        {
            starm = this.Reference(false);
            this.AddToDictionary("Purpose of visit: ", $"{starm}");
        }
        
    }

    public virtual void DisplayCurrentClassInfo()
    {
        foreach(KeyValuePair<string, string> item in this._checkInDict)
        {
            Console.WriteLine($"\n{item.Key} {item.Value}");
        }
    }
}