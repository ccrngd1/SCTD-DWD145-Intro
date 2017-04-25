var hasChildren = prompt("Do you have children (Y/N)");

if(hasChildren == "Y" || hasChildren=="y") 
{
	var childCount = prompt("How many children?");
	
	if(parseInt(childCount)!=NaN && isFinite(childCount)){
	console.log("You have " + childCount + " children");
	
	
	}
	
}

console.log("Thanks for your participation, questionnaire complete.")