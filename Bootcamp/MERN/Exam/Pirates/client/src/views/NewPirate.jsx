import { useState } from 'react'
import { useNavigate } from 'react-router-dom'

import { createPirate } from '../services/internalApiService'


export const NewPirate = (props) => {
    const [formData, setFormData] = useState({
        name: "",
        url: "",
        treasures: null,
        phrase: "",
        postition: "Captain",
        peg: true,
        patch: true,
        hook: true

    })

    const [peg, setPeg] = useState(true)
    const [patch, setPatch] = useState(true)
    const [hook, setHook] = useState(true)
    
    const [errors, setErrors] = useState(null);

    const navigate = useNavigate()

    const handleSubmit = (e) => {
        e.preventDefault();
        createPirate(formData)
            .then((data) => {
                console.log('new pirate data:', data)
                navigate(`/pirates/${data._id}`)
            })
            .catch((error) =>{
                console.log(error.response?.data?.errors);
                setErrors(error.response?.data?.errors)
            })
        }

    
    const handleFormChanges = (e) => {
        if(e.target.type === 'checkbox'){
            setFormData({
                ...formData,
                [e.target.name]: e.target.checked,
            })
            return null;
        }
        setFormData({
            ...formData, 
            [e.target.name]: e.target.value
        })
    }
    return (
        <div className='w-50 p-4 rounded mx-auto shadow'>
            <h3 className='text-center'>Add Pirate</h3>

            <form onSubmit={(e) => {
                handleSubmit(e);
            }}>
            
                <div>
                    <label className='hG'>Name:</label>
                    <input 
                        onChange={handleFormChanges}
                        type="text" 
                        name='name'
                        value={formData.name}
                        className='form-control'
                    />
                {
                    errors?.name && (
                        <span className='text-danger'>{errors.name?.message}</span>
                    )
                }    
                </div>

                
                
                <div className='form-group'>
                <label className='hG'>URL:</label>
                    <input 
                        onChange={handleFormChanges}
                        type="text" 
                        name='url'
                        value={formData.url}
                        className='form-control'
                    />
                {
                    errors?.url && (
                        <span className='text-danger'>{errors.url?.message}</span>
                    )
                }
                </div>

                <div className='form-group'>
                <label className='hG'>Catch Phrase:</label>
                    <input 
                        onChange={handleFormChanges}
                        type="text" 
                        name='phrase'
                        value={formData.phrase}
                        className='form-control'
                    />
                {
                    errors?.phrase && (
                        <span className='text-danger'>{errors.phrase?.message}</span>
                    )
                }
                </div>

                <div className='form-group'>
                    <label className='hG'>Crew Position</label>
                    <select 
                        onChange= {handleFormChanges}
                        type='text'
                        name='position'
                        >
                        <option value="Captain">Captain</option>
                        <option value="First Mate">First Mate</option>
                        <option value="Quarter Master">Quarter Master</option>
                        <option value="Bootswain">Bootswain</option>
                        <option value="Powder Monkey">Powder Monkey</option>

                    </select>

                    {
                    errors?.position && (
                        <span className='text-danger'>{errors.position?.message}</span>
                    )
                }

                </div>

                <div className='form-group'>
                <label className='hG'># of Treasure Chests</label>
                    <input 
                        onChange={handleFormChanges}
                        type="number" 
                        name='treasures'
                        value={formData.treasures}
                        className='form-control'
                    />
                {
                    errors?.treasures && (
                        <span className='text-danger'>{errors.treasures?.message}</span>
                    )
                }
                </div>                

                <div className='form-check'>
                    
                <input 
                onChange={(e) => {
                    setFormData({
                        ...formData,
                        [e.target.name]: e.target.checked
                    })
                }}
                name="peg"
                type="checkbox"
                /> <label>Peg Leg?</label>

                </div>

                <div className='form-check'>  
                <input 
                    type="checkbox" 
                    name="patch"
                    onChange={e=> setPatch(e.target.checked)} 
                    checked={patch} 
                    value={formData.patch}/> <label className='hG'>Eye Patch?</label>
                </div>  
                
                <div className='form-check'>  
                <input 
                    type="checkbox" 
                    name="hook"
                    onChange={e=> setHook(e.target.checked)} 
                    checked={hook} 
                    value={formData.hook}/> <label className='hG'>Hook Hand?</label>
                </div>  
                
            
            <button className='btn btn-small btn-outline-success'>Submit</button>
            </form>

        </div>
    )


    
}