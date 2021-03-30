//GetElementByClassName()
function Hello_World_Function() {
    var A = document.getElementsByClassName("click");
    A[0].innerHTML = "The text has changed!!";
}
//canvas example
function myCanvas() {
    var c = document.getElementById("myCanvas");
    var ctx = c.getContext("2d");
    var img = document.getElementById("LOTR_journey");
    ctx.drawImage(img, 10, 10, 200, 250);
}