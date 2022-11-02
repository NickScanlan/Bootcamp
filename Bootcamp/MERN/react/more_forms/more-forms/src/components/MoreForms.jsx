import React, { useState } from 'react';

const Form = (props) => {
    const [FirstName, setFirstName] = useState("");
    const [LastName, setLastName] = useState("");
    const [Email, setEmail] = useState("");
    const [Password, setPassword] = useState("")
    const [ConPass, setConPass] = useState("")

    const createUser = (e) => {
        e.preventDefault();
        const newUser = {FirstName, LastName, Email, Password};
        console.log("success", newUser);
    };

    return(
        <form onSubmit = {createUser}>
            <div>
                <label>First Name: </label>
                <input type="text" onChange ={ (e) => setFirstName(e.target.value)}/>
                {FirstName.length < 2? <p>First Name must be at least 2 characters</p> : null}
            </div>
            <div>
                <label>Last Name: </label>
                <input type="text" onChange ={ (e) => setLastName(e.target.value)}/>
                {LastName.length < 2? <p>Last Name must be at least 2 characters</p> : null}
            </div>
            <div>
                <label>Email: </label>
                <input type="text" onChange ={ (e) => setEmail(e.target.value)}/>
                {Email.length < 2? <p>Email must be at least 2 characters</p> : null}
            </div>
            <div>
                <label>Password: </label>
                <input type="text" onChange ={ (e) => setPassword(e.target.value)}/>
                {Password.length < 8? <p>Password must be at least 8 characters</p> : null}
                {Password === ConPass? <p>Passwords don't match </p> : null}
            </div>
            <div>  
                <label>Confirm Password: </label>
                <input type="text" onChange ={ (e) => setConPass(e.target.value)}/>
             
            </div>
        </form>
    )
}





export default Form;