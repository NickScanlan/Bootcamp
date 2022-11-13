const mongoose = require("mongoose");

const dbName = "JokesAPI";

mongoose
.connect(`mongodb://127.0.0.1:27017/${dbName}`)
.then(() => {
    console.log(`successfully connected to ${dbName}`)
})
.catch((error) => {
    console.log(`mongoose connecrtion to ${dbName} failed `, error)
})