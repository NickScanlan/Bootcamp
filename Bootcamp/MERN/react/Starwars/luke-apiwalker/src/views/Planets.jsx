import React, {useEffect, useState} from "react";
import {useParams} from "react-router-dom"
import axios from 'axios'


export const Planets = (props) => {
    const { planetId } = useParams();
    const [planet, setPlanet] = useState({})
    
    
    
    useEffect(() => {
        axios.get(`https://swapi.dev/api/planets/${planetId}`)
            .then( (apiResponse) => {
                console.log(apiResponse.data);
                setPlanet(apiResponse.data)
            })
            .catch(err => console.log(err))
    }, [])

    return( 
    <>
    <h1>{planet.name}</h1>
    <div>
        <h5>Climate: {planet.climate}</h5>
        <h5>Terrain: {planet.terrain}</h5>
        
        {
            planet.surface_water ? (
            <h5>Surface Water: True</h5>
            ) : <h5>Surface Water: False</h5>

        }
        
        <h5>Population: {planet.population}</h5>
    </div>
    </>
    )


}