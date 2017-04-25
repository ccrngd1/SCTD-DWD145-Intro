using System;
class MainClass {
  public static void Main (string[] args) {
  	
  	int ScoresLength = 5;
  	int[] scores = new int[ScoresLength];
  	
  	Console.WriteLine("Enter 5 scores");
  	
  	for(int i=0; i<ScoresLength; i++){
  		scores[i] = int.Parse(Console.ReadLine());
  	}
  	
  	Console.WriteLine("Let's print out those scores");
  	
  	int totalScore=0;
  	
  	for(int j=0; j<ScoresLength; j++){
  		Console.WriteLine("Score " + j + " :" + scores[j]);
  		totalScore+=scores[j];
  	}
  	
  	Console.WriteLine("Total score is: " + totalScore); 
  }
}
      