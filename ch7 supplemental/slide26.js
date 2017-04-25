var scores = new Array(5) 
for(var i=0;i<5;i++){
	scores[i] = new Array(2);
}

scores[0][0]=100;
scores[0][1]=99;

scores[1][0]=90;
scores[1][1]=89;

scores[2][0]=86;
scores[2][1]=87;

scores[3][0]=98;
scores[3][1]=97;

var studentChoice = prompt("enter a student # to get test scores or 999 to quit")

while(studentChoice!=999){
	for(var i=0; i<2; i++){
		console.log(scores[studentChoice][i])
	}
	
	studentChoice = prompt("enter a student # to get test scores or 999 to quit")
}