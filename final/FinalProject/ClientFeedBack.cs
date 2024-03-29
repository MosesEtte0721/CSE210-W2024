using System;
using System.Text;
using System.Collections.Generic;

public class ClientFeedback: CheckIn
{
    private bool _possibleReferal;
    private List<string> _checkin = new List<string>();

     
    private Dictionary<string, string> _feedback = new Dictionary<string, string>();
    private List<string> _experience = new List<string>{
        "Excellent",
        "Great",
        "Fair",
        "Disappointing",
        "Awful"
    };

    public override void AddCheckIn(string check)
     {
          this._checkin.Add(check);
     }

// The customer Comments on how the customer care or attendant treated him/her
    public string ExperienceWithAttendant(string param)
    {
                
                return $"{param} ";
    }

// Display list of one word to express the quality of service the customer received

    public void DisplayListExperience()
    {
        int item;
        for( item = 0; item < this._experience.Count; item++)
        {
            Console.WriteLine ($"{item + 1}. {this._experience[item]}");
             
        }
    }

    public string OverallExperience(int number)
    {

        
        string ans = "";
        
       
         switch (number)
                {
                    case 1:
                        ans = this._experience[0];
                        break;

                    case 2:
                        ans = this._experience[1];
                        break;
                    case 3:
                        ans = this._experience[2];
                        break;
                    case 4:
                        ans = this._experience[3];
                        break;
                    case 5:
                        ans = this._experience[4];
                        break;

                    default:
                        Console.WriteLine("You have entered an incorrect input ");
                        break;

                }

        return ans;
 
    }

// The customer suggests or recommends what can be done to improve the quality of services offered
    public string CommentAndSuggestion(string param)
    {
        
        return $"{param} ";
    }

    public bool SetAndGetReferal
    {
        get {return this._possibleReferal;}
        set {this._possibleReferal = value;}
    }

    public override bool AddToDictionary(string param1, string param2)
    {
            if (!_feedback.ContainsKey(param1))
            {
                this._feedback.Add(param1, param2);
                return true;
            }
            else
            {
                Console.WriteLine("The key already exists in the dictionary.");
                return false;
            }
    }
    public override void ExecuteClass()
    {
        Console.WriteLine("client's feedBack".ToUpper());
        Console.WriteLine($"Your Feedback Will Help us Serve you Better. \n");
        
        // The customer shares his/her experience in details with customer rep
       
        Console.WriteLine("In details, How was your experience with the attendant? ");
        Console.Write(">> ");
        string expWithAttendant = Console.ReadLine();
        // this.ExperienceWithAttendant();
        this.AddToDictionary("Experience With Attendant: ", this.ExperienceWithAttendant(expWithAttendant));
        this.AddCheckIn($"Experience With Attendant: {this.ExperienceWithAttendant(expWithAttendant)}");

        // overall experience of the customer in one word
        Console.WriteLine();
        this.DisplayListExperience();
        Console.WriteLine("Describe your experience in one word by typing the corresponding number to your overall experience (1-5)");
        Console.Write(">> ");
        int para;
        int.TryParse(Console.ReadLine(), out para);
        this.AddToDictionary("Overrall Experience: ", this.OverallExperience(para));
        this.AddCheckIn($"Overrall Experience: {this.OverallExperience(para)}");
        

        
        // suggestions on how to improve the quality of service
        Console.WriteLine("\nWhat do you think we (customer care and the company) can do to improve the quality of our services? ");
        Console.Write(">> ");
        string suggestionAndComment = Console.ReadLine();
        this.AddToDictionary("Comment and Suggestions: ", this.CommentAndSuggestion(suggestionAndComment));
        this.AddCheckIn($"Comment and Suggestions: {this.CommentAndSuggestion(suggestionAndComment)}");

        // Ask if the customer will recommend or refer our company his/her friends and family
        bool response = false;
        Console.WriteLine($"\nWould you Recommend or refer our company and products to your friends and family? ");
        // Console.Write(">> ");
        string yesOrNo = Console.ReadLine().ToLower();

        if(yesOrNo == "yes")
        {
            this.SetAndGetReferal = true;
            response = this.SetAndGetReferal;
        } 
        else if (yesOrNo == "no")
        {
            this.SetAndGetReferal = false;
            response = this.SetAndGetReferal;

        }
        this.AddToDictionary("Recommendation posibility: ",  response.ToString());
        this.AddCheckIn($"Recommendation posibility: {response.ToString()}");

        // 
        Console.WriteLine($"\nYour Feedback Has Been Recorded. ");
        Console.WriteLine($"Thank you for Your Patronage. ");
        // Console.WriteLine($"");
    }

    public override string DisplayCurrentClassInfo()
    {
        StringBuilder stringBuilder = new StringBuilder();
        Console.WriteLine("Client's Feedback \n".ToUpper());
        foreach(KeyValuePair<string, string> item in this._feedback)
        {
            stringBuilder.Append($"{item.Key} \n  {item.Value} \n");
        }
        return stringBuilder.ToString();
    }
    public override List<string> DisplayChickIn()
    {
        Console.WriteLine("Client feedback \n".ToUpper());
         List<string> temporalList = new List<string>();
        foreach (var checkin in this._checkin)
        {
            string[] keyValue = checkin.Split(": ");
            string keys = keyValue[0];
             string values = keyValue.Length > 1 ? keyValue[1] : "No Value Found";
            // Console.WriteLine($"\n{keys}: \n{values}");
             temporalList.Add($"{keys}: {values} \n I love codding my thing");

            
        }
        this._checkin.AddRange(temporalList);
        return this._checkin;
    }

}