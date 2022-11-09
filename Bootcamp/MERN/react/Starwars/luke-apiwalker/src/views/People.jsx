import React, {useEffect, useState} from "react";
import {useParams} from "react-router-dom"
import axios from 'axios'
import { Form } from "./Form";


export const People = (props) => {
    const { peopleId } = useParams();
    const [people, setPeople] = useState({})
    
    
    useEffect(() => {
        axios.get(`https://swapi.dev/api/people/${peopleId}`)
            .then( (apiResponse) => {
                console.log(apiResponse.data);
                setPeople(apiResponse.data)
            })
            .catch(err => console.log(err))
    }, [])

    return(    
    <>
    <Form/>
    <h1>{people.name}</h1>
    <div>
        <h5>Height: {people.height}</h5>
        <h5>Mass: {people.mass}</h5>
        <h5>Hair Color: {people.hair_color}</h5>
        <h5>Skin Color: {people.skin_color}</h5>
    </div>
    </>
    )
}