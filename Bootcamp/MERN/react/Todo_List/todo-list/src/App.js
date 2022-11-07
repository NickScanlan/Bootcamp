
import React , {useState} from "react"
import './App.css';

function App() {
  const [newTodo, setNewTodo] = useState("") 
  const [todos, setTodos] = useState([])
  
  
  const handleNewTodoSubmit = (event) => {
    event.preventDefault();
    if (todos.length === 0 ){
      return;
    }

  const todoItem = {
    text: newTodo,
    complete: false

  }

    console.log(newTodo)
    setTodos([...todos, todoItem])
    setNewTodo("");
  }
  
  
  
  
  
  const handleTodoDelete = (delIdx) => {
    const filteredTodos = todos.filter((todo, i) =>{
      return  i !== delIdx;
    });
    setTodos(filteredTodos);

  }

  return (
    <div style={{textAlign:"center"}}>
      <form onSubmit={(event) => {
          handleNewTodoSubmit(event);
        }}>
        <input onChange={(event) => {
        setNewTodo(event.target.value)
        }}
          type="text"/>
        <div>
          <button>Add</button>
        </div>
      </form>

      {todos.map( (todo, i) => {
          return(
          <div key={i}>
          <span>{todo.text}</span>
          <button onClick={(event) => {
            handleTodoDelete(i);
          }}
          >Delete</button>
          </div>
      );
      })}
    
    </div>
  );
}

export default App;
