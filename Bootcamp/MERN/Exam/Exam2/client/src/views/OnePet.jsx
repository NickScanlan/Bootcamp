import {useEffect, useState} from 'react'
import {useParams, useNavigate} from 'react-router-dom'
import { getPetById, deletePet } from '../services/internalApiService';



export const OnePet = (props) => {
    const {id} = useParams();
    const[pet, setPet] = useState(null);
    const navigate = useNavigate();
    useEffect(() =>{
        getPetById(id)
        .then((data) =>{
            setPet(data);
        })
        .catch((error) => {
            console.log(error)
        })
    },[id])

    const handleDeleteClick = () => {
        deletePet(id)
            .then((data) =>{
                navigate('/pets')
            })
            .catch((error) => {
                console.log(error)
            })
    }

    if(pet === null){
        return null
    }

    const{name, type, description, skill1, skill2, skill3 } = pet
    return (
        <div>
            <h4>Details about: {name}</h4>
            <h5>pet type: {type}</h5>
            <h5>description: {description}</h5>
            <div className='d-flex'>
                <h5 >Skills:</h5>
                <div className='mx-5'>
                    <h5>{skill1}</h5>
                    <h5>{skill2}</h5>
                    <h5>{skill3}</h5>

                </div>
            </div>
            <button 
            onClick={handleDeleteClick}
            className='btn btn-sm btn-outline-danger mx-auto'
            >Adopt {name}
            </button>
        </div>
    )
}