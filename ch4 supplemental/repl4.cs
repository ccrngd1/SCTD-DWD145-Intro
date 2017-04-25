using System;
class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine("Do you have children? (Y/N)");
    string hasChildren = Console.ReadLine();
    
    if(hasChildren != "N" || hasChilren != "n"){
    	int childCountAsInt =0;
    
    	Console.WriteLine("How many children?");
    	string childCount = Console.ReadLine();
    	
    	if(int.TryParse(childCount, out childCountAsInt)){
    		Console.WriteLine("You have " + childCountAsInt + " children.");
    	}
    	else{
    		Console.WriteLine("You entered an incorrect answer of '" + childCount + "', sorry.");
    	}
    }
    
    Console.WriteLine("Thanks for your participation, questionaire complete.");
    }
  } 
      