import React from 'react'
import axios from 'axios';
import {Link} from 'react-router-dom'
const ProductList = (props) => {
    return (
        <div>
            {props.product.map( (product, i) =>
                <Link to = {`/products/${product._id}`}><p key={i}> Title: {product.title} </p></Link>
            )}
        </div>
    )
}
    
export default ProductList;

