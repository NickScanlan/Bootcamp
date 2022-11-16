import {useParams} from 'react-router-dom'
export const OneAuthor = (props) => {
    const {id} = useParams();
    return <h2>OneAuthor Id: {id}</h2>
}