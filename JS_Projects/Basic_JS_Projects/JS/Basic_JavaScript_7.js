//Global variable
var X = 10;

function addNbrs_1() {
    document.write(20 + X + "<br>");
}

function addNbrs_2() {
    document.write(X + 100 + "<br>");
}
addNbrs_1();
addNbrs_2();

//Local variable
function addNbr3() {
    var Y = 10;
    document.write(45 + Y + "<br>");
}

function addNbr4() {
    document.write(Y + 200);
}
addNbr3();
addNbr4();

//Local variable-Console.log output for debug
function addNbr5() {
    var Z = 10;
    console.log(45 + Y + "<br>");
}

function addNbr6() {
    console.log(Z + 200);
}
addNbr3();
addNbr4();

//basic IF statement that time hour, if less than 2300 hours, 11pm, say greeting
function get_date() {
    if (new Date().getHours() < 23) {
        document.getElementById("greet").innerHTML = "How are you today?";
    }
}

//Basic IF statement to get month
function myMonthFunc() {
    if (new Date().getMonth() == 7) {
        document.getElementById("HappyMonth").innerHTML = "Happy August";
    }
}

//ELSE statement to verify age greater than/equal to 18
function myAgeFunc() {
    Age = document.getElementById("age").value;
    if (Age >= 18) {
        Vote = "You're old enough to vote!!  Here's your ballot";
    } else {
        Vote = "You aren't old enough to vote yet, Please come back when you're 18";
    }
    document.getElementById("howOldRU").innerHTML = Vote;
}

//ELSE IF statement to show proper greeting per time of day.. gets the current hour you're in
function myTimeFunc() {
    var time = new Date().getHours();
    var reply;
    if (time < 12 == time > 0) {
        reply = "00 hours, Good Morning";
    } else if (time > 12 == time < 18) {
        reply = "00 hours, Good Afternoon";
    } else {
        reply = "00 hours, Good Night!!";
    }
    document.getElementById("TimeOfDay").innerHTML = "It's " + (new Date().getHours()) + reply;
}