using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donationCenter {
  
  class Program {
    
    Dictionary<string, int> newAccount = new Dictionary<string. int>();
    
    
   static void Main(string[] args)
   {
      ProgramName();
      while(true)
      {
        
      //user has option to create a new account
      Console.WriteLine("Would you like to create a new account");
      string newAccountOption = Console.ReadLine();
      
      if(newAccountOption == "Yes")
      {
        Console.Write("Please enter your name");
        string userName = Console.ReadLine();
        
        if(userName.Length == 0)
        {
          Console.WriteLine("You did not enter your name");
        }
        else
        {
          Console.WriteLine("Great! Now please enter your age");
          string userAge = Console.ReadLine();
          
          int userAge = Int32.Parse(userAge);
          
          if(userAge < 18)
          {
            Console.WriteLine("You must be at least 18 to donate");
          }
          else if(userAge >= 18)
          {
            Thread.Sleep(1600);
            Console.WriteLine("Awesome! your account has been created!\n");
            Console.WriteLine("Would you like to make a donation today?");
          }
          else
          {
            ErrorMessage();
          }
          
          newAccount.Add(username, userAge);
         
        }
      }
      else if(newAccountOption == "No") 
      {
        Console.Write("Would you like to make a private donation?");
        string privateDonation = Console.Readline();
        
        if(privateDonation == "Yes")
        {
          Console.WriteLine("Please enter your age");
          string privateDonationAge = Console.Readline();
          
          int privateDonationAge = Int32.Parse(privateDonationAge);
          
          if(privateDonationAge < 18)
          {
            Console.WriteLine("You must be at least 18 to donate");
          }
          else if(privateDonationAge >= 18)
          {
            Console.WriteLine("Great! Please enter the amount you wish to donate");
          }
        }
      }
    }
   }
   
   public static void ProgramName() 
   {
     Console.WriteLine("Donation Center");
   }
   public static void ErrorMessage()
   {
     Console.WriteLine("We are sorry, something went wrong, please try your request again");
   }
  }
}
