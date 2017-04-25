using System;
class MainClass {
	public static void Main (string[] args) {
		int payRate = 5;
		int hours = 50;
		double totalPay = 0;
		
		if(payRate < 10 && hours >40){
			Console.WriteLine("overtime");
			int overTimeHours = hours-40;
			double overTimePay = overTimeHours *1.5 * payRate;
			totalPay = 40*payRate + overTimePay;
		}
		else{
			Console.WriteLine("no overtime");
			totalPay = hours * payRate;
		}
		
		Console.WriteLine(totalPay);
	} 
}
      