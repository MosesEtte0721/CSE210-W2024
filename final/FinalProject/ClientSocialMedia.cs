using System;
using System.Formats.Tar;
using System.Text;

public class ClientSocialMedia: CheckIn
{
    private string _facebook;
    private string _twitter;
    private string _instagram;
    private string _linkedIn;
    private Dictionary<string, string> _socialMedia = new Dictionary<string, string>();
    private List<string> _listOfSocialMedia = new List<string>{
        "LinkedIn",
        "Facebook",
        "Instagram",
        "X(twitter)",
        "quite".ToUpper()
    };

    public ClientSocialMedia(string facebook)
    {
        this._facebook = facebook;
    }
     public ClientSocialMedia(string facebook, string twitter)
    {
        this._facebook = facebook;
        this._twitter = twitter;
    
    } 
    public ClientSocialMedia(string facebook, string twitter, string instagram)
    {
        this._facebook = facebook;
        this._twitter = twitter;
        this._instagram = instagram;
    }

    public ClientSocialMedia(string facebook, string twitter, string instagram, string linkedin)
    {
        this._facebook = facebook;
        this._twitter = twitter;
        this._instagram = instagram;
        this._linkedIn = linkedin;
    }

    public ClientSocialMedia()
    {

    }

  

  

    public string ClientSocialNetworks()
    {
        return $"{this._facebook} \n{this._twitter} \n{this._instagram} \n{this._linkedIn}";
    }

    public override bool AddToDictionary(string param1, string param2)
    {
            if (!_socialMedia.ContainsKey(param1))
            {
                this._socialMedia.Add(param1, param2);
                return true;
            }
            else
            {
                Console.WriteLine("The key already exists in the dictionary.");
                return false;
            }

    }
    public long RecieptId()
    {
        Console.WriteLine("Enter Your Reciept ID No. ");
        long recieptId;
        long.TryParse(Console.ReadLine(), out recieptId);
        return recieptId;
    }

    public void DisplayListOfSocialMedia()
    {
        for(var i =0; i < this._listOfSocialMedia.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {this._listOfSocialMedia[i]}");
        }
    }

    public override void ExecuteClass()
    {
        Console.WriteLine("Client Social Media Handle \n".ToUpper());
        Console.WriteLine("Do you have an Active social media Account? would you like to share it with us? ");
        Console.Write(">> ");
        string yesOrNo = Console.ReadLine().ToUpper();
        switch (yesOrNo)
        {
            case "YES":
                this.DisplayListOfSocialMedia();
                Console.WriteLine("\nPlease Enter a number (1-4)  from the list that correspond with your social media platform (type 5 to quit)");
                Console.Write(">> ");
                int yes;                
                int.TryParse(Console.ReadLine().ToUpper(), out yes);
                Console.WriteLine("you can only enter up to 4 social media handle");
    // iterate 8 times for social media platforms
                while(this._socialMedia.Count < 4 ) 
                {
                    
                    if(yes == 1)
                    {
                        Console.WriteLine($"\nPlease Enter Your {this._listOfSocialMedia[0]} Username");
                        Console.Write(">> ");
                        string linkedinUsername = Console.ReadLine();
                        this._linkedIn = linkedinUsername;
                        // Check if the  KEY and VALUE are already in the dictionary or if the VALUE already exists
                            if((this._socialMedia.ContainsKey(this._listOfSocialMedia[0]+ " Username: ") && this._socialMedia.ContainsValue(this._linkedIn)) || this._socialMedia.ContainsKey(this._listOfSocialMedia[0]+ " Username: "))
                            {
                            
                                Console.WriteLine($"{this._listOfSocialMedia[0]} username already exist.");
                                // break;
                            }
                            // Add the social media handle to the dictionary if the VALUE does not exist in the dictionary
                            else if(!this._socialMedia.TryGetValue(this._linkedIn, out linkedinUsername))
                            {
                                this.AddToDictionary("LinkedIn Username: ", this._linkedIn);
                            }
                            
                        
                    
                    }
                    if(yes == 2)
                    {
                        Console.WriteLine($"\nPlease Enter Your {this._listOfSocialMedia[1] } Username");
                        Console.Write(">> ");
                        string facebookUsername = Console.ReadLine();
                        this._facebook = facebookUsername;

                        // Check if the  KEY and VALUE are already in the dictionary or if the VALUE already exists
                          if((this._socialMedia.ContainsKey(this._listOfSocialMedia[1]+ " Username: ") && this._socialMedia.ContainsValue(this._linkedIn)) || this._socialMedia.ContainsKey(this._listOfSocialMedia[1]+ " Username: "))
                            {
                                Console.WriteLine($"\n {this._listOfSocialMedia[1]} username already exist.");
                                // break;
                            }
                            // Add the social media handle to the dictionary if the VALUE does not exist in the dictionary
                            else if(!this._socialMedia.TryGetValue(this._facebook, out facebookUsername))
                            {
                                this.AddToDictionary("Facebook Username: ", this._facebook);
                            }
                    }
                    if(yes == 3)
                    {
                        Console.WriteLine($"\nPlease Enter Your {this._listOfSocialMedia[2]} Username");
                        Console.Write(">> ");
                        string instagramUsername = Console.ReadLine();
                        this._instagram = instagramUsername;
                        // Check if the  KEY and VALUE are already in the dictionary or if the VALUE already exists
                          if((this._socialMedia.ContainsKey(this._listOfSocialMedia[2]+ " Username: ") && this._socialMedia.ContainsValue(this._linkedIn)) || this._socialMedia.ContainsKey(this._listOfSocialMedia[2]+ " Username: "))
                            {
                                Console.WriteLine($"\n {this._listOfSocialMedia[2]} username already exist.");
        
                            }
                            // Add the social media handle to the dictionary if the VALUE does not exist in the dictionary

                            else if(!this._socialMedia.TryGetValue(this._instagram, out instagramUsername))
                            {
                                this.AddToDictionary("Instagram Username: ", this._linkedIn);
                            }
                    }
                    else if(yes == 4)
                    {
                        Console.WriteLine($"\nPlease Enter Your {this._listOfSocialMedia[3]} Username");
                        Console.Write(">> ");
                        string twitterUsername = Console.ReadLine();
                        this._twitter = twitterUsername;
                        // Check if the  KEY and VALUE are already in the dictionary or if the VALUE already exists
                          if((this._socialMedia.ContainsKey(this._listOfSocialMedia[3]+ " Username: ") && this._socialMedia.ContainsValue(this._linkedIn)) || this._socialMedia.ContainsKey(this._listOfSocialMedia[3]+ " Username: "))
                            {
                                
                                Console.WriteLine($"\n {this._listOfSocialMedia[3]} username already exist.");
                
                            }
                            else if(!this._socialMedia.TryGetValue(this._twitter, out twitterUsername))
                            {
                                this.AddToDictionary("X(twitter) Username: ", this._twitter);
                            }
                    }
                    else if(yes == 5)
                    {
                        Console.WriteLine($"\nWe appreciate your cooperation");
                        break;
                    }
                    else if(this._listOfSocialMedia.Count == 0)
                    {
                        Console.WriteLine("Only four social media are accepted. Thank you");
                        
                        break;
                    }
                   
                    Console.WriteLine();
                    this.DisplayListOfSocialMedia();
                    Console.WriteLine("Agian, Please Enter a number from the list that correspond with your social media platform (type 5 to quit)");
                    Console.Write(">> ");
                    int.TryParse(Console.ReadLine().ToUpper(), out yes);
                      
                }
                break;
            case "NO":
                Console.WriteLine("\nWe Value You Even Without Social Media.");
                Console.WriteLine("Thank you for Your Time.");
                break;

                
            default:
                Console.WriteLine("No Worries if you don't want to share social media account with us");
            break;
        
        }

        

    }

      public override string DisplayCurrentClassInfo()
    {   
        StringBuilder stringBuilder = new StringBuilder();
        Console.WriteLine("Client's Social Media Handle \n".ToUpper());
        foreach(KeyValuePair<string, string> info in this._socialMedia)
        {
            stringBuilder.Append($"{info.Key} {info.Value} \n");
        }
        return stringBuilder.ToString();
    }


}
