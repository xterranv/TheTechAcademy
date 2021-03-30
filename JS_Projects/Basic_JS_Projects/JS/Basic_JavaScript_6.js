//Ternary Operator assignment
function Ride_Function() {
    var Height, Can_ride;
    Height = document.getElementById("Height").value;
    Can_ride = (Height < 52) ? "You are too short" : "You are tall enough to ride.";
    document.getElementById("Ride").innerHTML = Can_ride + " Enjoy the ride.";
}

//ternary operator Challenge assignment. 
function AgeFunction() {
    var Age, CanVote;
    Age = document.getElementById("Age").value;
    CanVote = (Age < 18) ? "You are too young to vote" : "You are old enough to vote.";
    document.getElementById("vote").innerHTML = CanVote;
}

//Example using the "this" keyword
function Vehicle(Make, Model, Year, Color) {
    this.Vehicle_Make = Make;
    this.Vehicle_Model = Model;
    this.Vehicle_Year = Year;
    this.Vehicle_Color = Color;
}
var Jack = new Vehicle("Dodge", "Viper", 2020, "Red");
var Emily = new Vehicle("Jeep", "Trail Hawk", 2019, "White and Black");
var Erik = new Vehicle("Ford", "Pinto", 1971, "Mustard");

function myKeywordFunc() {
    document.getElementById("Keywords_and_Constructors").innerHTML = "Erik drives a " +
        Erik.Vehicle_Color + "-colored " + Erik.Vehicle_Model + " manufactured in " + Erik.Vehicle_Year;
}

//Example using the "new" keyword
function Animal(Species, Breed, Color) {
    this.Animal_Species = Species;
    this.Animal_Breed = Breed;
    this.Animal_Color = Color;
}
var Finley = new Animal("Dog", "Shephard Mix", "Black and White");
var Maliki = new Animal("Dog", "Husky", "Black Grey and White");
var Sofia = new Animal("Cat", "Blue Russian", "Grey");

function myKeywordFunc2() {
    document.getElementById("New_and_This").innerHTML = "Sofia is a " +
        Sofia.Animal_Color + " " + Sofia.Animal_Breed + " " + Sofia.Animal_Species +
        " with very silky fur, which is a trait of all " + Sofia.Animal_Breed + " " + Sofia.Animal_Species + "s.";
}

//var var = "variable";

//Example using the "new" keyword
function Pet(Species, Breed, Age) {
    this.Pet_Species = Species;
    this.Pet_Breed = Breed;
    this.Pet_Age = Age;
}
var Finley = new Pet("Dog", "Shephard Mix", 1);
var Maliki = new Pet("Dog", "Husky", 8);
var Sofia = new Pet("Cat", "Blue Russian", 10);

function myAnimalAges() {
    document.getElementById("pet_ages").innerHTML = "Sofia is a " + Sofia.Pet_Age + " year old " + Sofia.Pet_Species + ".<br>" +
        "Maliki is an " + Maliki.Pet_Age + " year old " + Maliki.Pet_Species + ".<br>" +
        "Finley is a " + Finley.Pet_Age + " year old " + Finley.Pet_Species + ".";
}

function countFunc() {
    document.getElementById("NestedFunction").innerHTML = "the new number is: " + Count();

    function Count() {
        var startingPoint = 2;

        function addEm() { startingPoint += 5; }
        addEm();
        return startingPoint;
    }
}