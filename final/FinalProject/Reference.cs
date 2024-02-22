using System;
using System.Text;

public class Reference: CheckIn
{

    private string _refEmail;
    private long _refPhone;
    private string _refAddress;
    private string _refFirstName;
    private string _refLastName;

    private Dictionary<string, string> _refererInfo = new Dictionary<string, string>();
    private List<string> _checkin = new List<string>();

    public Reference(string fname, string lName, string email,  long phone, string address = "N/A" )
    {
        this._refFirstName = fname;
        this._refLastName = lName;
        this._refEmail = email;
        this._refAddress = address;
        this._refPhone = phone;
    }

    public Reference():this(string.Empty,string.Empty,string.Empty,0,string.Empty)
    {

    }

    public override void AddCheckIn(string check)
    {
        this._checkin.Add(check);
    }

    public override bool AddToDictionary(string param1, string param2)
    {
            if (!_refererInfo.ContainsKey(param1))
            {
                this._refererInfo.Add(param1, param2);
                return true;
            }
            else
            {
                Console.WriteLine("The key already exists in the dictionary.");
                return false;
            }
    }

    public override string Name()
    {
        return $"{this._refFirstName} {this._refLastName}";
    }

    public override string Email()
    {
        return this._refEmail;
    }

    public override long Phone()
    {
        return this._refPhone;

    }

    public override string Address()
    {
        return this._refAddress;
    }

    public override void ExecuteClass()
    {
        Console.WriteLine("Reference ".ToUpper());
        Console.Write("Providing the following information will help us show gratitude to the person who recommended us to you \n");
        // Ask for customer care rep first name and then add it to a collection
          Console.WriteLine("\nEnter First Name of Your referer: ");
          Console.Write(">> ");
          this._refFirstName = Console.ReadLine();
          Console.WriteLine("\n");


          // Ask for customer care rep's last name and then add it to a collection
          Console.WriteLine("\nEnter last Name of Your referer: ");
          Console.Write(">> ");
          this._refLastName = Console.ReadLine();
          this.AddToDictionary("Referer's Name: ", $"{this._refFirstName} {this._refLastName}");
          this.AddCheckIn($"Referer's Name: {this._refFirstName} {this._refLastName}");
          Console.WriteLine("\n");
          


          // Ask for customer care rep's Address and then add it to a collection
          Console.WriteLine("\nEnter Address of Your referer: ");
          Console.Write(">> ");
          this._refAddress = Console.ReadLine();
          this.AddToDictionary("Address Of Referer (optional): ", this.Address());
          this.AddCheckIn($"Address Of Referer (optional): {this.Address()}");
          Console.WriteLine("\n");

          // Ask for customer care rep's Email Address and then add it to a collection
          Console.WriteLine("\nEnter Email of Your referer: ");
          Console.Write(">> ");
          this._refEmail = Console.ReadLine();
          this.AddToDictionary("Email Of Referer: ", this.Email());
          this.AddCheckIn($"Email Of Referer: {this.Email()}");
          Console.WriteLine("\n");

          // Ask for customer care rep' Phone number and then add it to a collection
          Console.WriteLine("\nEnter Phone Number of Your referer: ");
          Console.Write(">> ");
          long.TryParse(Console.ReadLine(), out this._refPhone);
          this.AddToDictionary("Phone Number Of Referer: ", this._refPhone.ToString());
          this.AddCheckIn($"Phone Number Of Referer: {this._refPhone.ToString()}");
          Console.WriteLine("\n");

          Console.WriteLine("\nYour Referer's Details have Been Recorded. ");
          Console.WriteLine("We Invite you Recommend Our Products and Services to Your Friends too. ");
    }

      public override string DisplayCurrentClassInfo()
    {
        StringBuilder stringBuilder = new StringBuilder();
        Console.WriteLine("Referer Information \n".ToUpper());
        foreach(KeyValuePair<string, string> info in this._refererInfo)
        {
            stringBuilder.Append($"{info.Key} {info.Value} \n");
        }
        return stringBuilder.ToString();
        
    }

   public override List<string> DisplayChickIn()
    {
        Console.WriteLine("Referer Information \n".ToUpper());
        foreach (var checkin in this._checkin)
        {
            
            string[] keyValue = checkin.Split(": ");
            string keys = keyValue[0];
            string values = keyValue[1];
            Console.WriteLine($"{keys} {values}");
            // Console.WriteLine($"{checkin.DisplayCurrentClassInfo()}");

            
        }
        return this._checkin;
    }

}