using System;

public class Reference: CheckIn
{

    private string _refEmail;
    private long _refPhone;
    private string _refAddress;
    private string _refFirstName;
    private string _refLastName;

    public Reference(string fname, string lName, string email,  long phone, string address = "N/A" )
    {
        this._refFirstName = fname;
        this._refLastName = lName;
        this._refEmail = email;
        this._refAddress = address;
        this._refPhone = phone;
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



}