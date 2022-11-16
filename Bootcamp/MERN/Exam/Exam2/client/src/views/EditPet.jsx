import { useParams, useNavigate } from "react-router-dom"
import {useState, useEffect} from 'react'
import { updatePet, getPetById } from "../services/internalApiService";

export const EditPet = (props) => {
    const {id} = useParams();
    const [formData, setFormData] = useState({});
    const [errors, setErrors] = useState(null);
    const navigate = useNavigate()


    useEffect(() => {
        getPetById(id)
            .then((data) =>{
                setFormData(data);
            })
            .catch((error) =>{
                console.log(error)
            })
    }, [id])

    const handleSubmit = (e) => {
        e.preventDefault();
        updatePet(id, formData)
            .then((data) => {
                console.log('new pet info: ', data)
                navigate(`/pets/${id}`)
            })
            .catch((error) =>{
                console.log(error.response);
                setErrors(error.response?.data?.errors)
            })
        }

    const handleFormChanges = (e) =>{
        setFormData({
            ...formData,
            [e.target.name]: e.target.value
        })
    }

    if(formData === null){
        return null
    }

    const {name, type, description, skill1, skill2, skill3} = formData;

    return(
        <div className="w-50 p-44 rounded mx-auto shadow">
            <h3 className='text-center'>Edit Pet</h3>

            <form onSubmit = {(e) => {
                handleSubmit(e)
            }}>
                <div className='form-group'>
                    <label className='h6'>Pet Name:</label>
                    <input 
                        onChange={handleFormChanges}
                        type='text'
                        name='name'
                        value={name}
                        className='form-control'
                        />
                    {
                        errors?.name &&(
                            <span className='text-danger'>{errors.name?.message}</span>
                        )
                    }
                </div>
                
                <div className='form-group'>
                    <label className='h6'>Pet Type:</label>
                    <input 
                        onChange={handleFormChanges}
                        type='text'
                        name='type'
                        value={type}
                        className='form-control'
                        />
                
                    {
                        errors?.type &&(
                            <span className='text-danger'>{errors.type?.message}</span>
                        )
                    }
                </div>
                
                <div className='form-group'>
                    <label className='h6'>Pet Description:</label>
                    <input 
                        onChange={handleFormChanges}
                        type='text'
                        name='description'
                        value={description}
                        className='form-control'
                        />
                    {
                        errors?.description &&(
                            <span className='text-danger'>{errors.description?.message}</span>
                        )
                    }
                </div>
                
                <div className='form-group'>
                    <label className='h6'>Skill 1:</label>
                    <input 
                        onChange={handleFormChanges}
                        type='text'
                        name='skill1'
                        value={skill1}
                        className='form-control'
                        />
                </div>
                
                <div className='form-group'>
                    <label className='h6'>Skill 2:</label>
                    <input 
                        onChange={handleFormChanges}
                        type='text'
                        name='skill2'
                        value={skill2}
                        className='form-control'
                        />
                </div>
                <div className='form-group'>
                    <label className='h6'>Skill 3:</label>
                    <input 
                        onChange={handleFormChanges}
                        type='text'
                        name='skill3'
                        value={skill3}
                        className='form-control'
                        />
                </div>
                <button>Edit Pet</button>
            </form>
        </div>
    )
}