using System;
class MainClass {
	public static void Main (string[] args) {
		Console.WriteLine("Do you have children? (Y/N)");
		
		int childCountAsInt =0;
		string hasChildren = Console.ReadLine();
		
		if(hasChildren == "Y" || hasChildren == "y"){
		
			Console.WriteLine("How many children?");
			string childCount = Console.ReadLine();
			
			if(!int.TryParse(childCount, out childCountAsInt)){
				Console.WriteLine("You entered an incorrect answer of '" + childCount + "', sorry.");
			}
		}
		
		Console.WriteLine("Your answer of " + childCountAsInt + " children has been recorded.");
		Console.WriteLine("Thanks for your participation, questionaire complete.");
	} 
}
      