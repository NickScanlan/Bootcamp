import './App.css';
import React from 'react';
import Main from './views/Main';
import Detail from './views/Details';
import Update from './views/Update'
import { Routes, Route } from 'react-router-dom';

function App() {
  return (
    <div className="App">
      <Routes>
        <Route element={<Main/>} path="/products/" />
        <Route element={<Detail/>} path="/products/:id" />
        <Route element={<Update/>} path="/products/:id/edit"/>
      </Routes>                   
    </div>
  )
};

export default App;
