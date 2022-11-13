const mongoose = require('mongoose');



const JokeSchema = new mongoose.Schema({
    setup : {
        type: String, 
        required: [true, "setup is required"],
        minlength: [10, "Setup must be at least 10 characters long"]
    },

    punchline : {
        type: String, 
        required: [true, "Punchline is required"],
        minlength: [3, "Punchline must at least be 3 characters long"]
    }    
});

const Joke = mongoose.model('Joke', JokeSchema);

module.exports = {Joke: Joke};