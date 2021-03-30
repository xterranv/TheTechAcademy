function my_dictionary() {
    var animals = {
        Species: "Dog",
        Color: "Black",
        Breed: "Lab",
        Age: 5,
        Sound: "Bark",
    };
    delete animals.Sound;
    document.getElementById("Dictionary").innerHTML = animals.Sound;
}