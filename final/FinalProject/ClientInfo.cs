using System;

public class ClientInfo: CheckIn
{
    private string _facebook;
    private string _twitter;
    private string _instagram;
    private string _linkedIn;
    private Dictionary<string, string> _socialMedia = new Dictionary<string, string>();

    public ClientInfo(string facebook)
    {
        this._facebook = facebook;
    }
     public ClientInfo(string facebook, string twitter)
    {
        this._facebook = facebook;
        this._twitter = twitter;
    
    } 
    public ClientInfo(string facebook, string twitter, string instagram)
    {
        this._facebook = facebook;
        this._twitter = twitter;
        this._instagram = instagram;
    }

    public ClientInfo(string facebook, string twitter, string instagram, string linkedin)
    {
        this._facebook = facebook;
        this._twitter = twitter;
        this._instagram = instagram;
        this._linkedIn = linkedin;
    }

    public ClientInfo()
    {

    }

    // public void AddSocial()
    // {
    //     this._socialMedia.Add("Facebook", this._facebook);
    //     this._socialMedia.Add("Twitter", this._twitter);
    //     this._socialMedia.Add("Instagram", this._instagram);
    //     this._socialMedia.Add("LinkedIn", this._linkedIn);
    // }

    // public string DisplaySocial()
    // {
    //     KeyValuePair<string, string> 
    // }
    // // public abstract string ClientSocialNetworks()

    public string ClientSocialNetworks()
    {
        return $"{this._facebook} \n{this._twitter} \n{this._instagram} \n{this._linkedIn}";
    }

    public long RecieptId()
    {
        Console.WriteLine("Enter the Client Reciept ID ");
        long recieptId;
        long.TryParse(Console.ReadLine(), out recieptId);
        return recieptId;
    }

    

}
