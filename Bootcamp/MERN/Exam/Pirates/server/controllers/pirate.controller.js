const {
    createPirate: createPirate,
    getAllPirates,
    getPirateById,
    deletePirateById
} = require ("../services/pirate.service")



const handleCreatePirate = async (req, res) => {
    console.log('controller: handleCreatePirate req.body:', req.body)
    try {
        const pirate = await createPirate(req.body);
        return res.json(pirate)
    } 
    catch (error) {
        return res.status(400).json(error)
    }
}

const handleGetAllPirates = async (req, res) => {
    console.log('controller: handleGetAllPirates');
    try{
        const pirates = await getAllPirates();
        console.log(pirates)
        return res.json(pirates)
    }
    catch (error) {
        console.log(error)
        return res.status(400).json (error);
    }
}

const handleGetPirateById = async (req, res) => {
    console.log('controller: handleGetPirateById req.params', req.params.id);
    try{
        const pirate = await getPirateById(req.params.id);
        return res.json(pirate)
    }
    catch(error){
        return res.status(400).json(error)
    }
}

const handleDeletePirateById = async (req, res) => {
    console.log('controller: handleDeletePirateById req.params', req.params.id);
    try{
        const pirate = await deletePirateById(req.params.id);
        return res.json(pirate)
    }
    catch(error){
        return res.status(400).json(error);
    }

}

module.exports = {
    handleCreatePirate: handleCreatePirate,
    handleGetAllPirates,
    handleGetPirateById,
    handleDeletePirateById
}

