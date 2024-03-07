import React from 'react';
import logo from './logo.svg';
import 'bootstrap/dist/css/bootstrap.min.css';
import './App.css';

function App() {
  return (
    <div className="App">
      {/* Sticky top div*/}
      <header className="bg-white border-bottom border-black sticky-top" style={{borderWidth: '5px !important'}}>
        <div className="container">
          <h1 className="text-left font-weight-bold">Damask HR Concept</h1>
        </div>
      </header>
    </div>
  );
}

export default App;
