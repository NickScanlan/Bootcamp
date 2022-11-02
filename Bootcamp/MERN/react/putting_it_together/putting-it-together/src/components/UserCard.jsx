import React from "react"
import { useState } from "react";

export const UserCard = (props) => {
    const {oneUser: user} = props; 
    const [userProfile, setUserProfile] = useState(user)
    const {userName, age, hair} = userProfile
    
    
    return (
        <div>
            <h3>{userName}</h3>
            <p>Age: {age}</p>
            <p>Hair Color: {hair}</p>
            
            <button className="btn btn-danger"
            onClick={(e => {
                setUserProfile({
                    ...userProfile,
                    age: age + 1
                })

            })}
            >Birthday Button
            </button>
        </div> 
    )
}
