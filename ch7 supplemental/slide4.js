var scoresLength = 5;
var scores = new Array(scoresLength);

for(var i =0; i<scoresLength;i++){
	scores[i] = prompt("enter score value")
}

console.log("Let's print out the scores we entered")

var totalScoreString = 0;
var totalScoreInt =0;

for(var i =0; i<scoresLength;i++){
	console.log(scores[i])
	totalScoreString+=scores[i];
	totalScoreInt+=parseInt(scores[i])
}

console.log("the total score is")
console.log(totalScoreString)
console.log("the real total score is")
console.log(totalScoreInt)