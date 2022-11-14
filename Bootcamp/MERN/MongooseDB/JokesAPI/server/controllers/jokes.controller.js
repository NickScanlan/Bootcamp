const {Joke} = require("../models/jokes.model")

//GET ALL JOKES
module.exports.findAllJokes = (req, res) => {
    Joke.find()
        .then(allDaJokes => res.json({jokes: allDaJokes}))
        .catch(err => res.json({ message: "something went wrong", error: err}));
}

//GET ONE JOKE
module.exports.findOneJoke = (req, res) => {
    Joke.findOne({ _id: req.params.id})
        .then(oneJoke => res.json({ user: oneJoke}))
        .catch(err => res.json({ message: "something went wrong", error: err}))
}

//CREATE JOKE
module.exports.createNewJoke = (req, res) => {
    Joke.create(req.body)
        .then(newlyCreatedJoke => res.json({joke: newlyCreatedJoke}))
        .catch(err => res.json ({message: "something went wrong", error:err}))
    }

//UPDATE JOKE
module.exports.updateJoke = (req, res) => {
    Joke.findOneAndUpdate(
        {_id: req.params.id },
        req.body,
        {new: true, runValidators: true}
    )
        .then(updatedJoke => res.json({joke: updatedJoke}))
        .catch(err => res.json({message: "something went wrong", error: err}))
}

//DELETE ONE JOKE
module.exports.deleteOne = (req, res) => {
    Joke.deleteOne({ _id: req.params.id })
        .then(result => res.json({result: result}))
        .catch(err => res.json({message: "something went wrong", error: err}))
}

