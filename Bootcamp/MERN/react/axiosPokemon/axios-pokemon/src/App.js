import './App.css';
import {useState} from 'react'


function App() {
  const[pokemons, setPokemon] = useState([])
   
  const fetchPokemon = () => {
    fetch("https://pokeapi.co/api/v2/pokemon?limit=100000&offset=0")
    .then(response => {
      return response.json();
    })
    .then(response => {
      console.log(response);
      setPokemon(response)
    })
    .catch(err=>{
      console.log(err)
    })
  }
  
  return (
  <div>
    <button onClick ={fetchPokemon}>Fetch Pokemon</button>
    <hr/>
    {JSON.stringify(pokemons)}
    {/* {
      pokemons.map((poke, i) => {
        return(
          <h3>{poke.name}</h3>
        )
      })
    } */}

  </div>
  );
}

export default App;
