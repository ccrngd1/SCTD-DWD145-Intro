using System;
class MainClass {
	public static void Main (string[] args) {
		int ageAsInt = 0;
		string Eligibility = "";
		
		string age = Console.ReadLine();
		
		ageAsInt = int.Parse(age);
		
		if(ageAsInt >=18){
			Eligibility = "Yes";
		}
		else if(ageAsInt >15){
			Eligibility ="Maybe";
		}
		else{
			Eligibility = "No";
		}
		
		Console.WriteLine(Eligibility);
	} 
}
      