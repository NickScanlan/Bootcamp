const JokesController = require("../controllers/jokes.controller");

module.exports = app => {
    app.get("/api/jokes", JokesController.findAllJokes);
    app.get("/api/jokes/:id", JokesController.findOneJoke);
    app.put("/api/jokes/:id", JokesController.updateJoke);
    app.post("/api/jokes", JokesController.createNewJoke);
    app.delete("/api/jokes/:id", JokesController.deleteOne)
}