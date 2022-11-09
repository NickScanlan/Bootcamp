import React, {useState} from 'react'
import { useNavigate } from 'react-router-dom'

export const Form = (props) => {
    
    const [num, setNum] = useState(1)
    const [cate, setCate] = useState("People")
    const navigate = useNavigate();
    
    const submitHandler = (e) => {
        e.preventDefault();
        console.log(num, cate)
        navigate('/' + cate + '/' + num)
    }

return (
    <div>
        <form onSubmit={submitHandler}>

            <span>search for:  </span>
    
            <select onChange={e => setCate(e.target.value)}>
            <option>People</option>
            <option>Planets</option>
            </select>
                                
            <input type="number" onChange={e => setNum(e.target.value)}/>

            <button>Search</button>
        </form>   
    </div>
)
}

