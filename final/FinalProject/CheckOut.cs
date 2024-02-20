using System;
using System.ComponentModel.DataAnnotations;

public class CheckOut: CheckIn
{

    private bool _purposeAccomplish;
    private string _attendantMiddleName;
    private string _remark;
    private string _attendantFirstName;
    private string _attendantLastName;

    
    public CheckOut(string remark) 
    {
        this._remark = remark;


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

   

   public string Remark()
   {
        return$"{this._remark}  "; 
   
    
   }

   public override string Name()
   {
        return $"{this._attendantLastName}, {this._attendantFirstName} {this._attendantMiddleName}";
   }

}