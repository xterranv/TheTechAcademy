function validateForm() {
    var x = document.forms["myForm"]["phone", "fname", "lname"].value;
    if (x == "") {
        alert("Please fill out all Required fields (*)");
    }
}