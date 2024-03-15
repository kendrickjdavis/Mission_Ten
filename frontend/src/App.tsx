import React from "react";
import Header from "./Header";
import "./App.css";
import BowlerList from "./BowlerList/BowlerList";

function App() {
  return (
    <div className="App">
      <Header title="Bowling Maniacs"></Header>
      <BowlerList></BowlerList>
    </div>
  );
}

export default App;
