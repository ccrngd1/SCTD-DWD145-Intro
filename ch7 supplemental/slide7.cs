using System;
class MainClass {
  public static void Main (string[] args) {
  	
  	int[] rainInches = new int[12];
  	int sum =0;
  	int average=0;
  	
  	for(int k=0; k<12;k++){
  		Console.WriteLine("Please enter rainfall for the month #" +(k+1));
  		
  		rainInches[k] = int.Parse(Console.ReadLine());
  		
  		sum = sum+rainInches[k];
  	}
  	
  	average = sum/12;
  	
  	for(int k=0; k<12; k++){
  		Console.WriteLine("Rainfall for month #" +(k+1) +" is " + rainInches[k]);
  	}
  	
  	Console.WriteLine("The average monthly rainfall is " + average);
  	
  }
}
      