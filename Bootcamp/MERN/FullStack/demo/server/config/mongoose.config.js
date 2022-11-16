const mongoose = require('mongoose')

const dbName = 'authorsDB';

mongoose
    .connect(`mongodb://127.0.0.1:27017/${dbName}`)
    .then(() =>{
        console.log(`success... connected to ${dbName}`)
    })
    .catch((error) => {
        console.log(`mongoose connection to ${dbName} failed:`, error)
    })