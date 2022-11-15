import './App.css';
import {Link, Navigate, Route, Routes} from 'react-router-dom';
import {AllPirates} from './views/AllPirates'
import {OnePirate} from './views/OnePirate'
import {NewPirate} from './views/NewPirate'



function App() {
  return (
    <div className='container'>
      <nav className='navbar navbar=expand-lg navbar-light bg-light sticky-top justify-content-center mb-4'>
        <h1 className='navbar-brand mb-0'>Pirate Crew</h1>
        <div className='navbar-nav justify-content-between'>
          <Link
          to = '/pirates'
          className='btn btn-small btn-outline-primary mx-1'>
          Crew Board
          </Link>
          <Link
          to='/pirates/new'
          className='btn btn-small btn-outline-primary mx-1'>
          Add Pirate
          </Link>
        </div>
      </nav>

      <Routes>
        <Route path='/' element={<Navigate to='/pirates' replace/>}/>
        <Route path='/pirates' element = {<AllPirates/>}/>
        <Route path='/pirates/:id' element = {<OnePirate/>}/>
        <Route path='/pirates/new' element = {<NewPirate/>}/>
      </Routes>
    </div>
  );
}

export default App;
