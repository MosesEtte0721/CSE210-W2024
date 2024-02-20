using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
        CheckIn checkIn = new CheckIn("Moses", "Ette", "no location", "senatoette@mymail.com", 0800000000);
        CheckOut checkOut = new CheckOut("This is my remark and it is subject to change");
        ClientInfo info = new ClientInfo("LinkedIn","Twitter");
        CompanyContact companyhelp = new CompanyContact(08908478494, "helpEmail@helpEmail.com", 0994849983);
        Reference reference = new Reference("Daniel", "Ette", "Dannyette@email.com", 76373637);
        ClientFeedback feedback = new ClientFeedback();
        // companyhelp.HelpDesk();
        // companyhelp.SetAndGetHqPhone = 09894746374784;
        // Console.WriteLine();
        // Console.WriteLine("Headquaters Address and Phone Number: ");
        Console.WriteLine("______________________________________________________________");
        
        Console.WriteLine("REFERENCE ");
        Console.WriteLine($"{reference.Name()}, {reference.Address()}, {reference.Email()}, {reference.Phone()}");
        Console.WriteLine("______________________________________________________________ \n\n");

        Console.WriteLine("_______________________________________________________________ \n");
        feedback.ExecuteClass();
        Console.WriteLine("_______________________________________________________________ \n");
        

        // companyhelp.HqInfo();
        // Console.WriteLine(info.ClientSocialNetworks());

        // company.Name();

        // checkIn.DisplayClientDetails();
        // // string moses = checkIn.SetAndGetFirstName = "moses";
        // // string ette = checkIn.SetAndGetFirstName = "Ette";
        // checkOut.SetAndGetFirstName = "myFirstName";
        // checkOut.SetAndGetLastName = "myLastName";
        // checkOut.SetAndGetMiddleName = "myMiddleName";
        // checkOut.SetAndGetAddress = "No. 20 Road, Nigeria";
        // Console.WriteLine($" {checkOut.Name()} Address: {checkOut.Address()} ");
        // Console.WriteLine($"{checkOut.Remark()} By: {checkIn.Name()} {checkIn.ClientId()}");
    }
}