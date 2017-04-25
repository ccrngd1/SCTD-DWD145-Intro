var hasChildren = prompt("Do you have children (Y/N)");

if(hasChildren != "N") 
{
	var childCount = prompt("How many children?");
	
	if(parseInt(childCount)!=NaN && isFinite(childCount)){
	console.log("You have " + childCount + " children");
	}
	
	else{
	console.log("You entered '" + childCount + "' which is an invalid response that can not be counted in the survey")
	}
	
}

console.log("Thanks for your participation, questionnaire complete.")