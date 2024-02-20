public class ClientFeedback: CheckIn
{
    private bool _possibleReferal;
    private Dictionary<string, string> _feedback = new Dictionary<string, string>();
    private List<string> _experience = new List<string>{
        "Excellent",
        "Great",
        "Fair",
        "Disappointing",
        "Awful"
    };

// The customer Comments on how the customer care or attendant treated him/her
    public string ExperienceWithAttendant()
    {
                string expWithAttendant = Console.ReadLine();
                return $"{expWithAttendant} ";
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

    public string OverallExperience()
    {

        int number;
        string ans = "";
        int.TryParse(Console.ReadLine(), out number);
       
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
    public string CommentAndSuggestion()
    {
        string suggestionAndComment = Console.ReadLine();
        return $"{suggestionAndComment} ";
    }

    public bool SetAndGetReferal
    {
        get {return this._possibleReferal;}
        set {this._possibleReferal = value;}
    }

    public void AddToDictionary(string param1, string param2)
    {
        this._feedback.Add(param1, param2);
    }
    public void ExecuteClass()
    {
        Console.WriteLine("client's feedBac".ToUpper());
        Console.WriteLine($"Your Feedback Will Help us Serve you Better. \n");
        
        // The customer shares his/her experience in details with customer rep
       
        Console.WriteLine("In details, How was your experience with the attendant? ");
        Console.Write(">> ");
        // this.ExperienceWithAttendant();
        this.AddToDictionary("Experience With Attendant: ", this.ExperienceWithAttendant());

        // overall experience of the customer in one word
        this.DisplayListExperience();
        Console.WriteLine("Describe your experience in one word by typing the corresponding number to your overall experience (1-5)");
        Console.Write(">> ");
        this.AddToDictionary("Overrall Experience: ", this.OverallExperience());
        

        
        // suggestions on how to improve the quality of service
        Console.WriteLine("\nWhat do you think we (customer care and the company) can do to improve the quality of our services? ");
        this.AddToDictionary("Comment and Suggestions: ", this.CommentAndSuggestion());

        // Ask if the customer will recommend or refer our company his/her friends and family
        bool response = false;
        Console.WriteLine($"\nWould you Recommend or refer our company and products to your friends and family? ");
        Console.Write(">> ");
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

        // 
        Console.WriteLine($"\nYour Feedback Has Been Recorded. ");
        Console.WriteLine($"Thank you for Your Patronage. ");
        // Console.WriteLine($"");
    }


}