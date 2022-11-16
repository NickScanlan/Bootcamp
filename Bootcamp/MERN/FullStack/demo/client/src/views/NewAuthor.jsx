import {useState} from 'react'
import {useNavigate} from 'react-router-dom'

import {createAuthor} from '../services/internalApiService'

export const NewAuthor = (props) => {
    const [formData, setFormData] = useState({
        name: "",
    })

    const [errors, setErrors] = useState(null);
     
    const navigate = useNavigate();

    const handleSubmit = (e) => {
        e.preventDefault();
        createAuthor(formData)
            .then((data) => {
                console.log('new author data:', data)
                navigate(`/authors/${data._id}`)
            })
            .catch((error) => {
                console.log(error.response);
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
            <h3 className='text-center'> New Author</h3>

            <form onSubmit = {(e) => {
                handleFormChanges(e)
            }}>
                
            </form>
        </div>
    )
}