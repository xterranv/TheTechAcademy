//concat() Method
function FullSentence() {
    var prt1 = "This is ";
    var prt2 = "now a ";
    var prt3 = "full sentence.";
    var allTxt = prt1.concat(prt2, prt3);
    document.getElementById("connect").innerHTML = allTxt;
}

//slice() method example
function mySliceMethod() {
    var text1 = "The quick brown fox jumps over the lazy dog";
    var resultTxt = text1.slice(10, 19);
    document.getElementById("slice").innerHTML = resultTxt;
}

//toUppercase() method example
function myUpperCaseMethod() {
    var txt2 = "The quick brown fox jumps over the lazy dog";
    var resultTxt2 = txt2.toUpperCase();
    document.getElementById("upCase").innerHTML = resultTxt2;
}

//search() method example
function mySearchFunc() {
    var txt3 = "The quick brown fox jumps over the lazy dog";
    var resultTxt3 = txt3.search("fox");
    document.getElementById("searchIt").innerHTML = resultTxt3;
}

//toString() method example
function myString() {
    var nbr1 = 1000;
    document.getElementById("toString").innerHTML = nbr1.toString();
}

//toPrecision() method example
function MyNbrFormat() {
    var nbr2 = 15.123435145;
    document.getElementById("formatNbr").innerHTML = nbr2.toPrecision(4);
}

//toFixed() method example
function myFixedNbr() {
    var nbr3 = 333.5687;
    var n = nbr3.toFixed(2)
    document.getElementById("fixnbr").innerHTML = n;
}

//valueOf() method example
function myPrimValue() {
    var S2 = "Bazinga!!";
    var S2Result = S2.valueOf()
    document.getElementById("PrimValue").innerHTML = S2Result;
}