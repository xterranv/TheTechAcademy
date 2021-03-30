//querySelector() method
function myFunction() {
    document.querySelector(".example").style.backgroundColor = "red";
}

function myFunction2() {
    document.querySelector("p").style.backgroundColor = "tan";
}

//parsefloat() function
function myFunction() {
    var a = parseFloat("10")
    var b = parseFloat("10.00")
    var c = parseFloat("10.33")
    var d = parseFloat("34 45 66")
    var e = parseFloat("   60   ")
    var f = parseFloat("40 years")
    var g = parseFloat("He was 40")

    document.getElementById("parseIt").innerHTML =
        a + "<br>" +
        b + "<br>" +
        c + "<br>" +
        d + "<br>" +
        e + "<br>" +
        f + "<br>" +
        g;
}