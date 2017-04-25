using System;
class MainClass {
  public static void Main (string[] args) {
  	
  	int[] weeklySales = new int[51];
  	
  	for(int K=0; K<=51; K++){
  		Console.WriteLine("Enter sales for  week #"+(K+1));
  		weeklySales[K] = int.Parse(Console.ReadLine());
  	}
  	
  }
}
  