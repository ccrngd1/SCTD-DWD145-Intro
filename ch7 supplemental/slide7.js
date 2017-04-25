var rain = new Array(12)
var sum = 0;
var average =0;

for(var k=0; k<12; k++){
	rain[k] = prompt("enter rainfall for month " + (k+1))

	sum = sum+parseInt(rain[k]);
} 

average = sum/12;

for(var k=0; k<12; k++){
	console.log("Rainfall for month " + (k+1) + " is " + rain[k])
}

console.log("The average monthly rainfall is " + average)

