using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
       
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

        MenuList menuList = new MenuList();

        List<CheckIn> checkinList = new List<CheckIn>();
        checkinList.Add(checkIn);
        checkinList.Add(socialMedia);
        checkinList.Add(reference);
        checkinList.Add(feedback);
        checkinList.Add(checkOut);

        Console.WriteLine("Welcome To Customer Experience Improvement Application".ToUpper());
        Console.WriteLine("We Encourage you to Answer the Prompts to Enable Us Improve our Quality of Service.");

        Console.WriteLine(checkIn.DisplayChickIn());
        foreach(var item in checkIn.DisplayChickIn())
        {
            Console.WriteLine("______________________________________________________________ \n");
            Console.WriteLine(item);
            
        }

        foreach (CheckIn item in checkinList)
                {
                     Console.WriteLine("______________________________________________________________ \n");
                    Console.WriteLine(item.DisplayCurrentClassInfo());
                    Console.WriteLine("______________________________________________________________ \n");
                    // Console.WriteLine("Processing...");
                    menuList.ShowSpinner(500);
                    Console.WriteLine("______________________________________________________________ \n");
                    


                }


                List<string> listStrings = new List<string>();
                    foreach (CheckIn checkin in checkinList)
                    {
                        // Convert the CheckIn object to a string in the way that's appropriate for the parameter in SaveToDictionaryToFile()
                        
                        string listString = checkin.ToString();
                        //  Add the converted CheckIn Object
                        listStrings.Add(listString);
                    }
    

                SaveDictionaryToFile saveDictionary = new SaveDictionaryToFile();
                Console.WriteLine("Create Name for the file: ");
                Console.WriteLine(">> ");
                string fileName = Console.ReadLine();
                saveDictionary.SaveDictionary(listStrings,fileName);
                
                
                
          
        
        // Console.WriteLine();
        // menuList.DisplayMenuList();
        // Console.WriteLine($"\nWhat would you like to do? Select 1-3 (number only)");
        // Console.Write(">> ");
        // int choice;
        // int.TryParse(Console.ReadLine(), out choice);
        // while(true)
        // {
        //     if(choice == 1)
        //     {
        //         foreach (CheckIn item in checkinList)
        //         {
        //             Console.WriteLine("______________________________________________________________ \n");
        //             item.ExecuteClass();
        //             Console.WriteLine("______________________________________________________________ \n");

        //         }
        //     } 
        //     else if(choice == 2)
        //     {
        //         foreach (CheckIn item in checkinList)
        //         {
        //              Console.WriteLine("______________________________________________________________ \n");
        //             Console.WriteLine(item.DisplayCurrentClassInfo());
        //             Console.WriteLine("______________________________________________________________ \n");
        //             // Console.WriteLine("Processing...");
        //             menuList.ShowSpinner(500);
        //             Console.WriteLine("______________________________________________________________ \n");
                    


        //         }
        //     }
        //     else if(choice == 3)
        //     {

        //         // create a new list to store converted CheckIn obje
        //             List<string> listStrings = new List<string>();
        //             foreach (CheckIn checkin in checkinList)
        //             {
        //                 // Convert the CheckIn object to a string in the way that's appropriate for the parameter in SaveToDictionaryToFile()
        //                 string listString = checkin.ToString();
        //                 //  Add the converted CheckIn Object
        //                 listStrings.Add(listString);
        //             }
    

        //         SaveDictionaryToFile saveDictionary = new SaveDictionaryToFile();
        //         Console.WriteLine("Create Name for the file: ");
        //         Console.WriteLine(">> ");
        //         string fileName = Console.ReadLine();
        //         foreach(var check in checkinList)
        //         {
        //             saveDictionary.SaveDictionary(listStrings,fileName);
        //         }
                
                
        //     }
                
        //     else if(choice == 4)
        //     {
        //         break;
        //     }
        //     else if(choice == 5)
        //     {
        //         Console.WriteLine("Thank you and Goodbye".ToUpper());
        //         break;
        //     }
            
        //     Console.WriteLine("Welcome To Customer Experience Improvement Application".ToUpper());
        //     Console.WriteLine("We Encourage you to Answer the Prompts to Enable Us Improve our Quality of Service.");
           
           
        //     Console.WriteLine();
        //     menuList.DisplayMenuList();
        //     Console.WriteLine($"\nWhat would you like to do? Select 1-3 (number only)");
        //     Console.Write(">> ");
        //     int.TryParse(Console.ReadLine(), out choice);
        // }
        
        
       
    }
}