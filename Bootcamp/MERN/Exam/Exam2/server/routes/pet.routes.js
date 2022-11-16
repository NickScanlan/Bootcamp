const express = require ('express');

const{
    handleCreatePet, handleGetAllPets, handleGetPetById, handleDeletePetById, handleUpdatePetById
} = require ('../controllers/pet.controller')

const router = express.Router();

router.post('/', handleCreatePet)
router.get('/', handleGetAllPets)
router.get('/:id', handleGetPetById)
router.delete('/:id', handleDeletePetById)
router.put('/:id', handleUpdatePetById)

module.exports = {petRouter: router}