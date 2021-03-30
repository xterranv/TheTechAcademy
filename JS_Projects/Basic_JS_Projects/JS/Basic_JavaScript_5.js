//displays the test "string"
document.write(typeof "word");

//displays the number 3
document.write(3, "<br>");

//Displays NaN after clicking the CLICK HERE
function myFunction() {
    document.getElementById("test").innerHTML = 0 / 0;
}

//Displays True after clicking the CLICK HERE
function myFunction2() {
    document.getElementById("test2").innerHTML = isNaN('This is a string');
}

//Displays False after clicking the CLICK HERE
function myFunction3() {
    document.getElementById("test3").innerHTML = isNaN('007');
}

//displays infinity
document.write("<br>", 2E310);

//displays -infinity
document.write("<br>", -3E310, "<br>");

//boolean logic result = true
document.write(50 > 2, "<br>");

//boolean logic result = false
document.write(50 < 2);

//display the result 4 in the console
console.log(2 + 2);

//coercion results in 5050
document.write("<br>", "50" + 50, "<br>");

//display false in console using boolean logic and console.log
console.log(10 < 2);

//using dbl equal signs to compare data, display result True
document.write(10 == 10, "<br>");

//using dbl equal signs to compare data, displays result False
document.write(10 == 3, "<br><br>");

//triple equal signs to compare data, displays true
var x = 10;
var y = 10;
document.write(x === y, "<br>");

//triple equal signs to compare data, displays false
var x = 20;
var y = "10";
document.write(x === y, "<br>");

//triple equal signs to compare data, displays False
var x = 20;
var y = "twenty";
document.write(x === y, "<br>");

//triple equal signs to compare data, displays False
var x = "twenty";
var y = "thirty";
document.write(x === y, "<br><br>");

//AND logical operator &&, displays true
document.write(15 > 2 && 100 > 99, "<br>");

//AND logical operator &&, displays False
document.write(15 > 20 && 100 > 99, "<br>");

//OR logical operator ||, displays True
document.write(15 > 20 || 100 > 99, "<br>");

//OR logical operator ||, displays False
document.write(15 > 20 || 100 > 999, "<br><br>");

//NOT operator
function notFunction() {
    document.getElementById("Not1").innerHTML = !(20 > 10);
}

function notFunction2() {
    document.getElementById("Not2").innerHTML = !(5 > 10);
}