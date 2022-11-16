import './App.css';
import {Link, Navigate, Route, Routes} from 'react-router-dom'
import {AllPets} from './views/AllPets'
import { EditPet } from './views/EditPet';
import { OnePet } from './views/OnePet';
import { NewPet } from './views/NewPet';
import { NotFound } from './views/NotFound';

function App() {
  return (
    <div className="Container">
      <nav className='navbar navbar-expand-lg navbar-light bg-light sticky-top justify-content-center mb-4'>
        <div className='justify-content-between '>
        <h1>Pet Shelter</h1>
        <div className="navbar-nav justify-content-between">
        <Link
        to='./pets/new'
        className='btn btn-sm btn-outline-primary mx-1'>
          add pet to shelter
        </Link>
        <Link
        to='./pets'
        className='btn btn-sm btn-outline-primary mx-1'>
          Home
        </Link>
        </div>
        </div>
      </nav>
      <Routes>
        <Route path='/' element={<Navigate to = '/pets' replace/>}/>
        <Route path='/pets' element={<AllPets/>}/>
        <Route path='/pets/:id/edit' element={<EditPet/>}/>
        <Route path='/pets/:id' element={<OnePet/>}/>
        <Route path='/pets/new' element={<NewPet/>}/>
        <Route path='*' element={<NotFound/>}/>
      </Routes>
        
    </div>
  );
}

export default App;
