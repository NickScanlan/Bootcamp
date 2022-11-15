const express = require ('express');

const {
    handleCreatePirate,
    handleGetAllPirates,
    handleGetPirateById,
    handleDeletePirateById,
} = require('../controllers/pirate.controller')





const router = express.Router();

router.get('/', handleGetAllPirates)
router.post('/new', handleCreatePirate)
router.get('/:id', handleGetPirateById)
router.delete('/:id', handleDeletePirateById)

module.exports = {pirateRouter: router} 