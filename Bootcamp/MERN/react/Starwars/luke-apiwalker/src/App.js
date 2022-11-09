import './App.css';
import {Routes, Route} from "react-router-dom";
import {People} from "./views/People"
import {Planets} from "./views/Planets"
import {Form} from './views/Form'
import {Error} from './views/NotFound'

function App() {
  return (
  <div>
    <h2>APIwalker</h2>
    
  <Routes>
    
    <Route path="/people/:peopleId" element={<People/>}/>
    <Route path="/planets/:planetId" element={<Planets/>}/>
    <Route path="/" element={<Form/>}/>
    <Route path="*" element={<Error/>}/>

    
    
  </Routes>
  </div>
  );
}

export default App;
