import {useEffect, useState} from 'react'
import {useParams} from "react-router-dom"
import { getPirateById } from '../services/internalApiService';

export const OnePirate = () => {
    const {id} = useParams();
    
        const [pirate, setPirate] = useState(null)
        

        useEffect(() => {
            getPirateById(id)
                .then((data) => {
                    setPirate(data);
                })
                .catch((error) => {
                    console.log(error);
                })
        },[id])
        
        if (pirate === null){
            return null;
        }
        
        const {name, url, treasures, phrase, position, peg, patch, hook} = pirate
        

    return (
        
        <div className='w-100 mx-auto shadow mb-4 rouinded border p-4 text-center'>
            <h2>{name}</h2>
            <h2>{url}</h2>
            <h2>{phrase}</h2>
            <h4>position: {position}</h4>
            <h4>treasures: {treasures}</h4>
            <p>{
                pirate.peg == 1 ? (
                    <p>peg: Yes</p> 
                ) : (
                    <p>peg: No</p>
                )
            }
            </p>
            <p>{
                pirate.patch == 1 ? (
                    <p>patch: Yes</p> 
                ) : (
                    <p>p: No</p>
                )
            }
            </p>
            <p>{
                pirate.hook == 2 ? (
                    <p>hook: Yes</p> 
                ) : (
                    <p>hook: No</p>
                )
            }
            </p>
            

        </div>
    )
}