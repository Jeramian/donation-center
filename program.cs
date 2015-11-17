using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace donationCenter {
  
  class Program {
    
    Dictionary<string, int> newAccount = new Dictionary<string. int>();
    
    public static int donations;
    
    
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
            break;
          }
          else if(userAge >= 18)
          {
            Thread.Sleep(1600);
            Console.WriteLine("Awesome! your account has been created!\n");
            Console.WriteLine("Would you like to make a donation today?");
            string donateToday = Console.ReadLine();
            
            if(donateToday = "Yes")
            {
              Console.WriteLine("Perfect, please enter the amount you wish to donate");
              string donationAmount = Console.ReadLine();
              
              int donationAmount = Int32.Parse(donationAmount);
              
              if(donationAmount > 0)
              {
                Thread.Sleep(1777);
                Console.WriteLine("Thank you! We greatly appreciate your donation");
                donations = donations + donationAmount;
              }
              else if(donationAmount <= 0)
              {
                Console.WriteLine("You did not enter an amount!");
                continue;
              }
            }
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
        //User can make a private donation
        Console.Write("Would you like to make a private donation?");
        string privateDonation = Console.ReadLine();
        
        if(privateDonation == "Yes")
        {
          Console.WriteLine("Please enter your age");
          string privateDonationAge = Console.ReadLine();
          
          int privateDonationAge = Int32.Parse(privateDonationAge);
          
          if(privateDonationAge < 18)
          {
            Console.WriteLine("You must be at least 18 to donate");
            break;
          }
          else if(privateDonationAge >= 18)
          {
            Console.WriteLine("Great! Please enter the amount you wish to donate");
            string privateDonationAmount = Consosle.ReadLine();
            
            int privateDonationAmount = Int32.Parse(privateDonationAmount);
            
            if(privateDonationAmount > 0)
            {
              Console.WriteLine("Awesome! We greatly appreciate your donation");
              donations = donations + privateDonationAmount
            }
            else if(privateDonationAmount <= 0)
            {
              Console.WriteLine("You did not enter an amount!")
              continue;
            }
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
