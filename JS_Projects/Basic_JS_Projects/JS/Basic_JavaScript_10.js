//while loop
function CallLoop() {
    var digit = "";
    var X = 1;
    while (X < 11) {
        digit += "<br>" + X;
        X++;
    }
    document.getElementById("Loop").innerHTML = digit;
}

//for loop
var Instruments = ["Guitar", "Drums", "Piano", "Violin", "Trumpet"];
var Content = "";
var Y;

function myForLoop() {
    for (Y = 0; Y < Instruments.length; Y++) {
        Content += Instruments[Y] + "<br>";
    }
    document.getElementById("ListInstruments").innerHTML = Content;
}

//array example
function LOTRpics() {
    var lotrImg = [];
    lotrImg[0] = "Gates";
    lotrImg[1] = "Journey";
    lotrImg[2] = "Scenary";
    document.getElementById("Array").innerHTML = "Lord of the Rings: The " + lotrImg[0] + " of Argonath.";
}

//str example
function myStrCount() {
    var str = "The quick brown fox jumped over the lazy dog.";
    var resultStr = str.length;
    document.getElementById("HowManyChars").innerHTML = "There are " + resultStr + " chars in the above sentence (not including the quotes :)";
}

//scope
function myFunctionScope() {
    var car1 = "Tacoma TRD Pro";
    document.getElementById("myCar").innerHTML = car1;
}

//const example
function myInstruments() {
    const musicInstrument = { type: "guitar", brand: "Fender", color: "black" };
    musicInstrument.color = "blue";
    musicInstrument.brand = "Gibson";
    musicInstrument.price = "$900";
    document.getElementById("instrument").innerHTML = "The cost of the " + musicInstrument.type + " is " +
        musicInstrument.price + " for the " + musicInstrument.color + " " + musicInstrument.brand;
}

//let examples
var X = 155;
document.write("Let and Var examples:" + "<br><br>" + X); {
    let X = 57;
    document.write("<br>" + X);
}
document.write("<br>" + X + "<br>");

var Y = 199;
document.write("<br>" + Y); {
    var Y = 157;
    document.write("<br>" + Y);
}
document.write("<br>" + Y);

//Return statement
function ReturnPie() {
    return Math.PI;
}

//Objects 
let animal = {
    species: "Dog",
    breed: "Border Collie",
    color: "black and white",
    type: "Herding",
    description: function() {
        return "This " + this.species + " is a " + this.color + " " + this.breed + "." + " They're known for " + this.type + ".<br>";
    }
};

var nbr = "";
var n;
for (n = 0; n < 10; n++) {
    if (n === 5) { break; }
    nbr += "Now Serving: " + n + "<br><br>";
}
for (n = 0; n < 10; n++) {
    if (n === 5) { continue; }
    nbr += "Now Serving: " + n + "<br>";
}