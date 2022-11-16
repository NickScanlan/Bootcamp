const mongoose = require('mongoose')

const PetSchema = new mongoose.Schema(
    {
        name: {
            type: String,
            required: [true, '{PATH} is required'],            
        },
        type: {
            type: String,
            required: [true, '{PATH} is required'],            
        },
        description: {
            type: String,
            required: [true, '{PATH} is required'],            
        },
        skill1: {
            type: String,
        },
        skill2: {
            type: String,
        },
        skill3: {
            type: String,
        },

        
    },
    {timestamps: true}
);

const Pet = mongoose.model("Pet", PetSchema);

module.exports = {Pet: Pet};
