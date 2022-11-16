import { useParams } from "react-router-dom"
export const EditAuthor = (props) => {
    const {id} = useParams();
    return <h2>Edit Author with {id}</h2>
}