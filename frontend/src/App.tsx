import './App.css';
import BowlersList from './Bowling/BowlersList';
import Header from './Header';

function Welcome() {
  return <h1>Keep it 300 Bowling</h1>;
}

function App() {
  return (
    <div className="App">
      <Welcome />
      <Header title="Members on the Marlins and Sharks" />
      <BowlersList />
    </div>
  );
}

export default App;
