var posInt = prompt("Please enter a positive number");

if(posInt >0){
	//we have logic that runs here
	
	//it would be a lot of logic
	
	//more logic
	
	//lots of Math
	console.log("thanks for inputing a positive number")
}
else{
	console.log("Bad input");
	return;
}



////what about this way instead?

var posInt = prompt("Please enter a positive number");

if(posInt<0){
	console.log("Bad input");
	return;
}

//then our logic runs
//all that logic from above
//many lines of math and logic
console.log("thanks for inputing a positive number")