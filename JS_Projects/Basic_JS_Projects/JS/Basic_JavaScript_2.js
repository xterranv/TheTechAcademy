//change the button color to purple when clicked
function My_First_Function() {
    var str = "The color of this is Purple";
    var result = str.fontcolor("purple");
    document.getElementById("PurpleTxt").innerHTML = result;
}

//concatenate using += 
function myFunction() {
    var sentence = "I am learning";
    sentence += " a lot from this book.";
    document.getElementById("concatenate").innerHTML = sentence;
}

//function to convert fahrenheit to celcius
function toCelsius(f) {
    return (5 / 9) * (f - 32);
}