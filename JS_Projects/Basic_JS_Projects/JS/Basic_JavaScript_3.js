function myAddition() {
    var a = 4 + 4;
    document.getElementById("Math").innerHTML = "4 + 4 = " + a + "<br>";
}

function mySubtraction() {
    var b = 95 - 45;
    document.getElementById("Math").innerHTML = "95 - 45 = " + b + "<br>";
}

function myDivision() {
    var c = 375 / 5;
    document.getElementById("Math").innerHTML = "375 / 5 = " + c + "<br>";
}

function myMultiply() {
    var d = 5 * 5;
    document.getElementById("Math").innerHTML = "5 * 5 = " + d + "<br>";
}

function myAllMath() {
    var all_math = (28 + 7) * 15 / 2 - 7;
    document.getElementById("Math").innerHTML = "28 + 7, Multiplied by 15 Divided by 2 and then subtracted by 7 equals ---> " + all_math + "<br>";
}

function myModulus() {
    var remaining = 25 % 6;
    document.getElementById("Math").innerHTML = "<br><br>" + "When you divide 25 by 6 you get a remainder of: " + remaining + "<br>";
}

function negationOp() {
    var x = 10;
    document.getElementById("Math").innerHTML = -x;
}

window.alert(Math.random())