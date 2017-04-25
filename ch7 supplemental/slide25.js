var scores = new Array(5) 
for(var i=0; i<5; i++){
	scores[i] = new Array(2)
}

for(var student=0;student<5;student++){
	for(var test=0;test<2;test++){
		scores[student][test] = prompt("Enter student #" + student + "'s test #" + test +" score");
	}
}