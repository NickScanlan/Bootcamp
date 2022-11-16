import {useState} from 'react'
import {useNavigate} from 'react-router-dom'

import {createPet} from '../services/internalApiService'

export const NewPet = (props) => {
    const [formData, setFormData] = useState({
        name: "",
        type: "",
        description: "",
        skill1: "",
        skill2: "",
        skill3: ""
    })

    const [errors, setErrors] = useState(null);
     
    const navigate = useNavigate();

    const handleSubmit = (e) => {
        e.preventDefault();
        createPet(formData)
            .then((data) => {
                console.log('new pet data:', data)
                navigate('/pets')
            })
            .catch((error) => {
                console.log(error.response?.data?.errors);
                setErrors(error.response?.data?.errors)
            })

    }
    const handleFormChanges = (e) => {
        e.preventDefault();
        setFormData({
            ...formData,
            [e.target.name] : e.target.value
        })
    }
    
    return (
        <div className="w-50 p-44 rounded mx-auto shadow">
            <h3 className='text-center'> New Pet</h3>

            <form onSubmit = {(e) => {
                handleSubmit(e)
            }}>
                <div className='form-group'>
                    <label className='h6'>Pet Name:</label>
                    <input 
                        onChange={handleFormChanges}
                        type='text'
                        name='name'
                        value={formData.name}
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
                        value={formData.type}
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
                        value={formData.description}
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
                        value={formData.skill1}
                        className='form-control'
                        />
                </div>
                
                <div className='form-group'>
                    <label className='h6'>Skill 2:</label>
                    <input 
                        onChange={handleFormChanges}
                        type='text'
                        name='skill2'
                        value={formData.skill2}
                        className='form-control'
                        />
                </div>
                <div className='form-group'>
                    <label className='h6'>Skill 3:</label>
                    <input 
                        onChange={handleFormChanges}
                        type='text'
                        name='skill3'
                        value={formData.skill3}
                        className='form-control'
                        />
                </div>
                <button>Add Pet</button>
            </form>
        </div>
    )
}