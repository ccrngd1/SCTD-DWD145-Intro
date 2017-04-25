using System;
class MainClass {
	public static void Main (string[] args) {
		Console.WriteLine("Enter a positive number");
		
		int positiveNumberAsInt =0;
		string positiveNumber = Console.ReadLine();
		
		positiveNumberAsInt = int.Parse(positiveNumber);
		
		if(positiveNumberAsInt > 0){
			//Logic
			
			//a lot of work
			
			//a lot of lines
			
			//makes this very long
		}
		else{
			Console.WriteLine("Bad input");
		}
		
		
		
		//Doesn't this way look better?
		if(positiveNumberAsInt<0){
			Console.WriteLine("Bad Input");
			return;
		}
		
			//Logic
			
			//a lot of work
			
			//a lot of lines
			
			//makes this very long
	} 
}
      