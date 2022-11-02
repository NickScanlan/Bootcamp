import logo from './logo.svg';
import './App.css';
import { UserCard } from './components/UserCard';

function App() {
  
  const users = [
    {
      userName: "Doe, Jane",
      age: 45 ,
      hair: "Black"
    },
    {
      userName: "Smith, John",
      age: 88 ,
      hair: "Brown"
    }
  ]
  return (
  <>
    {
      users.map((oneUser) => {
        return <UserCard oneUser = {oneUser}/>
      })
    }
  </>
  );
}

export default App;
