using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello FinalProject World!");
        CheckIn checkIn = new CheckIn("Moses", "Ette", "no location", "senatoette@mymail.com", 0800000000);
        CheckOut checkOut = new CheckOut("This is my remark and it is subject to change");
        CheckOut checkOutEmpty = new CheckOut();
        ClientSocialMedia socialMedia = new ClientSocialMedia("LinkedIn","Twitter");
        ClientSocialMedia socialMediaEmpty = new ClientSocialMedia();
        CompanyContact companyHelp = new CompanyContact(08908478494, "helpEmail@helpEmail.com", 0994849983);
        Reference reference = new Reference("Daniel", "Ette", "Dannyette@email.com", 76373637);
        Reference referenceEmpty = new Reference();
        ClientFeedback feedback = new ClientFeedback();
        CheckIn checkInEmpty = new CheckIn();

        Console.WriteLine("______________________________________________________________ \n");
        checkInEmpty.ExecuteClass();
        Console.WriteLine("______________________________________________________________ \n\n");

        Console.WriteLine("______________________________________________________________ \n");
        Console.WriteLine("Checkin Information".ToUpper());
        checkInEmpty.DisplayCurrentClassInfo();
        Console.WriteLine("______________________________________________________________ \n\n");
        // companyhelp.HelpDesk();
        // companyhelp.SetAndGetHqPhone = 09894746374784;
        // Console.WriteLine();
        // Console.WriteLine("Headquaters Address and Phone Number: ");
        // Console.WriteLine("_____________________________________________________________ \n");
        
        // // Console.WriteLine("REFERENCE ");
        // // Console.WriteLine($"{reference.Name()}, {reference.Address()}, {reference.Email()}, {reference.Phone()}");
        // reference.ExecuteClass();
        // Console.WriteLine("______________________________________________________________ \n\n");

        // Console.WriteLine("REFERENCE ");
        // // Console.WriteLine($"{reference.Name()}, {reference.Address()}, {reference.Email()}, {reference.Phone()}");
        // reference.DisplayReferInfo();
        // Console.WriteLine("______________________________________________________________ \n\n");


        // Console.WriteLine("______________________________________________________________ \n");
        // feedback.ExecuteClass();
        // Console.WriteLine("______________________________________________________________ \n\n");

        // Console.WriteLine("______________________________________________________________ \n");
        // feedback.DisplayClientFeedback();
        // Console.WriteLine("______________________________________________________________ \n\n");

        
        //  Console.WriteLine("______________________________________________________________ \n");
        // socialMediaEmpty.ExecuteClass();
        // Console.WriteLine("______________________________________________________________ \n\n");

        // Console.WriteLine("______________________________________________________________ \n");
        // socialMediaEmpty.DisplaySocialMedia();
        // Console.WriteLine("______________________________________________________________ \n\n");


        // Console.WriteLine("_____________________________________________________________ \n");
        // checkOutEmpty.ExecuteClass();
        // Console.WriteLine("_____________________________________________________________ \n");


        // Console.WriteLine("_____________________________________________________________ \n");
        // referenceEmpty.ExecuteClass();
        // Console.WriteLine("_____________________________________________________________ \n");

        // companyHelp.ExecuteClass();
        // Console.WriteLine("\n");

        // companyHelp.DisplayCompanyInfo();

    //    Console.WriteLine("_____________________________________________________________ \n");
    //     checkOutEmpty.ExecuteClass();
    //     Console.WriteLine();
    //    Console.WriteLine("_____________________________________________________________ \n");


    //    Console.WriteLine("_____________________________________________________________ \n");
    //     checkOutEmpty.DisplayCheckOutInfo();
    //    Console.WriteLine("_____________________________________________________________ \n");
       
        // company.Name();

       
    }
}