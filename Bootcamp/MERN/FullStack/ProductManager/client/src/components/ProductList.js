import React from 'react'
import axios from 'axios';
import {Link} from 'react-router-dom'




const ProductList = (props) => {
    const { removeFromDom } = props;
    
    const deleteProduct = (productId) => {
        axios.delete('http://localhost:8000/api/products/' + productId)
            .then(res => {
                removeFromDom(productId)
            })
            .catch(err => console.error(err));
    }
    return (
        <div>
           {props.product.map( (product, i) =>
                <Link to = {`/products/${product._id}`}><p key={i}> Title: {product.title} </p></Link>
            )}
                
            
            {props.product.map( (product) =>
                <button onClick={(e)=>{deleteProduct(product._id)}}>Delete</button>
            )}
            
        </div>
    )
}
    
export default ProductList;

