import {useEffect, useState} from 'react'
import {Link} from 'react-router-dom'
import { getAllPets } from '../services/internalApiService'



export const AllPets = (props) => {
    const[pets, setPets] = useState([])

    useEffect(() =>{
        getAllPets()
            .then((data) => {
                setPets(data);
            })
            .catch((error) => {
                console.log(error);
            })
    },[])
        
    

    return(
        <div>
        
        
        {pets.map((pet, i) => {
            const {_id, name, type} = pet;
       
        return(
            <table className='table'>
                    <tr>
                        <th>Name</th>
                        <th>Type</th>
                        <th>Actions</th>
                    </tr>
                    
                    
                    <tr>
                        <td>{name}</td>
                        <td>{type}</td>
                        <td><Link to={`/pets/${_id}`}>Details</Link> | <Link to={`/pets/${_id}/edit`}>Edit</Link> </td>
                    </tr>
                        
                        
                 </table>
            )
            
         })}
         </div>
    )
    
}