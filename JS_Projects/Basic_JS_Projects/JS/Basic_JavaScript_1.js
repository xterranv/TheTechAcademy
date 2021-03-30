//defining a variable and using the window.alert method to display a popup window msg
var d = "Stay calm and play with your Dog";
window.alert(d)

//Examples using the document.write method
document.write("Lisa told Bart, \"Knock it off, Bart! Or I'll tell dad!\"<br>\"Eat my shorts!\" Bart responded.");
document.write("<br><br>");

document.write("Be who you are and say what you feel," + "because those who mind don\'t matter and those that matter don\'t mind\"" + "-Dr. Seuss");
document.write("<br><br>");

//displaying a concatenated variable
var B = "Sunny" + " day"
document.write(B);
document.write("<br><br>"); //adding space

//defining two variables with string values
var a = "My dog"
var b = " Finley"
    //concatenating two variables and displaying
document.write(a + b);
document.write("<br><br>"); //adding space

//setting the font color of each variable
var Family = "The Munsters",
    Family = Family.fontcolor("red"),
    Dad = "Herman Munster",
    Dad = Dad.fontcolor("green"),
    Mom = "Lily Munster",
    Mom = Mom.fontcolor("purple"),
    Neice = "Marilyn Munster",
    Neice = Neice.fontcolor("yellow"),
    Son = "Eddie Munster",
    Son = Son.fontcolor("blue"),
    Grandparent = "Grandpa Munster";
Grandparent = Grandparent.fontcolor("orange");
document.write(Grandparent);
document.write("<br><br>"); //adding space

//defining an expression, displaying the result
var x = 44 + 55
document.write(x);
document.write("<br><br>"); //adding space

function My_First_Function() {
    //defining a function and naming it

    var str = "This text is green!";
    //defining a variable and string value

    var result = str.fontcolor("green");
    //using the fontcolor method on the string value

    document.getElementById("Green_Text").innerHTML = result;
    //putting the value of the Result string into an HTML Element with the green_text id
}

//displays datetime when the html button element is clicked
function displayDate() {
    document.getElementById("showdate").innerHTML = Date();
}