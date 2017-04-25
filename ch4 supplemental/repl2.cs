using System;
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Do you have children? (Y/N)");
    string hasChildren = Console.ReadLine();
    
    if(hasChildren == "Y" || hasChildren=="y"){
    
    	Console.WriteLine("How many children?");
    	string childCount = Console.ReadLine();
    	Console.WriteLine("You have " + childCount + " children.");
    }
    
    Console.WriteLine("Thanks for your participation, questionaire complete.");
    }
  } 
      