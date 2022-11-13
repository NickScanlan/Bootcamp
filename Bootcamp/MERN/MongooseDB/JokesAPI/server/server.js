const express = require('express');
const app = express();
const cors = require('cors');
const port = 8000;
require('./config/mongoose.config');
app.use(cors());

app.use(express.json(), express.urlencoded({ extended: true }));

const AllJokesRoutes = require("./routes/joke.route")
AllJokesRoutes(app);

app.listen(port, () => console.log(`listening on port ${port} for requests to respond to`))