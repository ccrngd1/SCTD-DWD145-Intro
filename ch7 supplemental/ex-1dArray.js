var charArray = ['t','e','s','t'];
var stringArray = ["john", "chris", "tom"]

console.log("character array contents")
console.log(charArray)
console.log("")
console.log("string array contents")
console.log(stringArray)
console.log("")
console.log("")

//
//Index into our string array to show only one name
//
console.log("0th index of character array")
console.log(charArray[0])
console.log("")
console.log("0th index of string array")
console.log(stringArray[0])
console.log("")
console.log("")


//
//let's reassemble the character array into a stringArray
//
console.log("characters concatenated into a single string")
var tempString="";
for(var i =0; i<charArray.length; i++){
	tempString +=charArray[i]
}

console.log(tempString)
console.log("")
console.log("")


//
//let's print each name out individually
//
console.log("Individual names from a for loop")
for(var i =0; i<stringArray.length; i++){
	console.log(stringArray[i])
}