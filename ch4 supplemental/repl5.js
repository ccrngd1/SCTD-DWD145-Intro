var hasChildren = prompt("Do you have children (Y/N)");
var childCount =0;

if(hasChildren == "Y" || hasChildren =="y") 
{
	var childCountPrompt = prompt("How many children?");
	
	if(parseInt(childCountPrompt)!=NaN && isFinite(childCountPrompt)){
		childCount = childCountPrompt;
	}
	
	else{
	console.log("You entered '" + childCount + "' which is an invalid response that can not be counted in the survey")
	}
	
}

console.log("Your survey result of " + childCount + " children has been recorded");

console.log("Thanks for your participation, questionnaire complete.")