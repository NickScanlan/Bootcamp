import { faker } from '@faker-js/faker';
const express = require("express");
const app = express();
const port = 8000;
app.use( express.json() );
app.use( express.urlencoded({ extended: true }) );




app.get('/api/user/new') = (req,res) => {
    const newUser ={
        name: faker.commerce.productName(),
        price: "$" + faker.commerce.price(),
        department: faker.commerce.department()
    };
    return newUser
}

app.get('/api/companies/new') = (req,res) => {
    const newCompany ={
        name: faker.commerce.productName(),
        price: "$" + faker.commerce.price(),
        department: faker.commerce.department()
    };
    return newCompany
}
app.get('/api/company') = (req,res) => {
    
    return (newCompany, newUser)
}




app.post('/api/user/new', (req,res) =>{
    console.log(req.body);
})


app.listen(port, () => {
    console.log(`Listening on ${port} for requests to respond to`)
})