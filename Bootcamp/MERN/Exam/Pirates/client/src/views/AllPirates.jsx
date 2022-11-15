import {useEffect, useState} from 'react'
import {Link} from "react-router-dom"
import { getAllPirates, deletePirate } from '../services/internalApiService'




export const AllPirates = (props) => {
    const [pirates, setPirates] = useState([])

    useEffect(() =>{
        getAllPirates()
            .then((data) => {
                setPirates(data);
            })
            .catch((error) => {
                console.log(error);
            })
    }, [])


    const handleDeleteClick = (idToDelete) => {
        deletePirate(idToDelete)
        .then((data) => {
            console.log(data)
            const filteredPirates = pirates.filter((pirate) => {
                return pirate._id !== idToDelete
            })
            setPirates(filteredPirates)
        })
        .catch((error) => {
            console.log(error)
        })
    }

    return (
        <div className='w-50 mx-auto text-center'>
            <h2>All Pirate</h2>
            {pirates.map((pirate, i ) => {
                const {_id, name, url} = pirate;

                return(
                    <div key = {i} className = 'shadow mb-4 rounded-border p-4'>
                        <p>{url}</p>
                        <Link to={`/pirates/${_id}`}>
                            <h4>{name}</h4>
                        </Link>
                        
                        <button
                        className='btn btn-sm btn-outline-danger mx-1'
                        onClick = {(e) => {
                            handleDeleteClick(_id)
                        }}
                        >
                            walk the plank
                        </button>

                        
                    </div>
                    
                )
            })}
        </div>
    )
}