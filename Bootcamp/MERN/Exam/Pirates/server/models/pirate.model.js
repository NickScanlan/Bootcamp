const mongoose = require('mongoose');
 
const PirateSchema = new mongoose.Schema({
    name:{ 
        type: String,
        required: [true, "{PATH} is required"]
    },
    
    url:{
        type: String,
        required: [true, "{PATH} is required"]
    },
    
    treasures:{
        type: Number,
        required: [true, "{PATH} is required"]    
    },
    
    phrase:{
        type: String,
        required: [true, "{PATH} is required"]    
    }, 
    
    position:{
        type: String,
        default: "Captain",
        required: [true, "{PATH} is required"]
    }, 
    
    peg:{
        type: Boolean,
    }, 
    
    patch:{
        type: Boolean,

    }, 
    
    hook:{
        type: Boolean,
    }, 

}, {timestamps: true});
 
const Pirate = mongoose.model('Pirate', PirateSchema);
 
module.exports = {Pirate: Pirate};