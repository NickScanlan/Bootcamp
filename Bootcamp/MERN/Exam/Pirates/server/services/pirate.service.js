const {Pirate} = require("../models/pirate.model")


const createPirate = async (data) => {
    console.log('service: createPirate');
    const pirate = await Pirate.create(data);
    return pirate
}

const getAllPirates = async () => {
    console.log('service: getAllPirates');
    const pirates = await Pirate.find();
    return pirates;
}

const getPirateById = async (id) => {
    console.log('service: getPirateById');
    const pirate = await Pirate.findById(id);
    return pirate;
}

const deletePirateById = async (id) => {
    console.log('service: deletePirateById')
    const pirate = await Pirate.findByIdAndDelete(id);
    return pirate;
}

module.exports = {
    createPirate: createPirate,
    getAllPirates,
    getPirateById,
    deletePirateById
};
