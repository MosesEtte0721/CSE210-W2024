using System;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Collections.Generic;

public class CheckOut: CheckIn
{

    private bool _purposeAccomplish;
    private string _attendantMiddleName;
    private string _remark;
    private string _attendantFirstName;
    private string _attendantLastName;
    private Dictionary<string, string> _checkOutInfo = new Dictionary<string, string>();
    private List<string> _checkin = new List<string>();

    
    public CheckOut(string remark) 
    {
        this._remark = remark;


    }

    public CheckOut()
    {

    }

    public override bool AddToDictionary(string param1, string param2)
    {
          if (!_checkOutInfo.ContainsKey(param1))
          {
               this._checkOutInfo.Add(param1, param2);
               return true;
          }
          else
          {
               Console.WriteLine("The key already exists in the dictionary.");
               return false;
          }
    }

     public override void AddCheckIn(string check)
     {
          this._checkin.Add(check);
     }


    public bool PurposeAccomplished()
    {
        return this._purposeAccomplish;
    }

    
   public string SetAndGetMiddleName
   {
        get {return this._attendantMiddleName;}
        set { this._attendantMiddleName = value;}
   }

   public string SetAndGetFirstName
   {
        get {return this._attendantFirstName;}
        set {this._attendantFirstName = value;}
   }
    public string SetAndGetLastName
   {
        get {return this._attendantLastName;}
        set {this._attendantLastName = value;}
   }

     public bool SetAndGetPurposeOfVisit
   {
        get {return this._purposeAccomplish;}
        set {this._purposeAccomplish = value;}
   }


   

   public string Remark()
   {
        return$"{this._remark}  "; 
   
    
   }

   public override string Name()
   {
        return $"{this._attendantLastName}, {this._attendantFirstName} {this._attendantMiddleName}";
   }

    public override void ExecuteClass()
    {

          Console.WriteLine("Customer care Representative's Information ".ToUpper());
          Console.WriteLine("Answering these questions will allow us serve you better: \n");
     
          Console.WriteLine("Did you Achieve Your Purpose of Visit? ");
          Console.Write(">> ");
          string yesOrNo = Console.ReadLine().ToLower();
          string response = "";
          if(yesOrNo == "yes")
          {
               this.SetAndGetPurposeOfVisit = true;
               response = this.SetAndGetPurposeOfVisit.ToString();
          }
          else if(yesOrNo == "no")
          {
               this.SetAndGetPurposeOfVisit = false;
               response = this.SetAndGetPurposeOfVisit.ToString();
          }
          else {
          Console.WriteLine("You have entered a wrong Input. ");
     }
     
     this.AddToDictionary("Purpose of visit Met: ", response);

// // Ask for customer care rep first name and then add it to a collection
          Console.WriteLine("\nEnter First Name of Attendant: ");
          Console.Write(">> ");
          this._attendantFirstName = Console.ReadLine();
          Console.WriteLine("\n");

// Ask for customer care rep middle name and then add it to a collection 
          Console.WriteLine("Enter Middle Name of Representative: ");
          Console.Write(">> ");
          this._attendantMiddleName = Console.ReadLine();
          Console.WriteLine("\n");

// Ask for customer care rep Last name and then add it to a collection
          Console.WriteLine("Enter Last Name of Representative: ");
          Console.Write(">> ");
          this._attendantLastName = Console.ReadLine();
          Console.WriteLine("\n");
          this.AddToDictionary("Name of Customer Care Representative: ", $"{this._attendantLastName}, {this._attendantFirstName} {this._attendantMiddleName}");
          this.AddCheckIn($"Name of Customer Care Representative: {this._attendantLastName}, {this._attendantFirstName} {this._attendantMiddleName}");

// Ask for the customer's remark and then add it to a collection
          Console.WriteLine("Please Enter Your Remark: ");
          Console.Write(">> ");
          this._remark = Console.ReadLine();
          this.AddToDictionary("Remark: ", this.Remark());
          this.AddCheckIn($"Remark: {this.Remark()}");

          Console.WriteLine("\nThe information has been recorded: ");
          Console.WriteLine("We look forward to seeing you agian: \n");

    }

    public override string DisplayCurrentClassInfo()
    {
          StringBuilder stringBuilder = new StringBuilder();
          Console.WriteLine("Client Check Out \n".ToUpper());
          foreach(KeyValuePair<string, string> info in this._checkOutInfo)
          {
               stringBuilder.Append($"{info.Key} {info.Value} \n");
          }
          return stringBuilder.ToString();
    }

    
     public override List<string> DisplayChickIn()
    {
        Console.WriteLine("check out session \n".ToUpper());
         List<string> temporalList = new List<string>();
        foreach (var checkin in this._checkin)
        {
            string[] keyValue = checkin.Split(": ");
            string keys = keyValue[0];
             string values = keyValue.Length > 1 ? keyValue[1] : "No Value Found";
          //   Console.WriteLine($"{keys}: {values}");
             temporalList.Add($"{keys}: {values} \n I love codding my thing");

            
        }
        this._checkin.AddRange(temporalList);
        return this._checkin;
    }
}