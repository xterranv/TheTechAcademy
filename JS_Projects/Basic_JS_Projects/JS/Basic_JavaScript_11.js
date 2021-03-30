//Switch statement
function colorFunction() {
    var color_output;
    var colors = document.getElementById("ColorInput").value;
    var color_String = " is a great color!!";
    switch (colors) {
        case "Red":
            color_output = "Red" + color_String;
            break;
        case "Yellow":
            color_output = "Yellow" + color_String;
            break;
        case "Green":
            color_output = "Green" + color_String;
            break;
        case "Blue":
            color_output = "Blue" + color_String;
            break;
        case "Pink":
            color_output = "Pink" + color_String;
            break;
        case "Purple":
            color_output = "Purple" + color_String;
            break;
        default:
            color_output = "Please enter a color exactly as written in the above list.";
    }
    document.getElementById("output").innerHTML = color_output;
}