public class CheckIn
{
    protected long _phone;
    protected string _email;
    protected string _address;
    private int _clientId;
    protected string _firstName;
    protected string _lastName;


    public CheckIn( string fName, string lName, string address, string email, long phone)
    {
        this._email = email;
        this._address = address;
        this._phone = phone;
        this._firstName = fName;
        this._lastName = lName;
    }

    public CheckIn()
    {
        
    }
    public int ClientId()
    {
        Random random = new Random();
        int rand = random.Next(1, int.MaxValue);
        return this._clientId = rand;

    }

    public virtual string Name()
    {
        return $"{this._firstName} {this._lastName}";
    }

    public string PurposeOfVisit()
    {
        return "I want to make enquiry about the services you offer";
    }

    public string Reference()
    {
        return "I was not refered by anyone. I saw the sign post, so I decided to stop by ";
    }

    public string ClientDetails()
    {
        return $"{this._firstName} {this._lastName} \n {this._address} {this._email} {this._phone}";
    }

     public void DisplayClientDetails()
    {
        Console.WriteLine("Details of Clients ");
        Console.WriteLine($"Name: {this._firstName} {this._lastName} \nPhone: {this._address} \nEmail: {this._email} \nPhone: {this._phone} \nPurpose: {this.PurposeOfVisit()} \n{this.Reference()}");
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
}