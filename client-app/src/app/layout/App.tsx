import React, {useState, useEffect} from 'react';
import './styles.css';
import axios from 'axios';
import { Header, Icon } from 'semantic-ui-react'
import { IIdolCharacter } from '../modules/idolCharacter';
import { NavBar } from '../../features/nav/NavBar';



const App = () => {

  const [idolCharacters, setIdolCharacters] = useState<IIdolCharacter[]>([])

  useEffect(() => {
    axios
      .get<IIdolCharacter[]>('http://localhost:5000/api/idolCharacters')
      .then(response => {
      setIdolCharacters(response.data)
    });
  }, []);

  
    return (
      <div className="App">
        <header className="App-header">
          <NavBar />
            
         
        </header>
          <div>
            <ul>
              {idolCharacters.map(idolCharacter => (
                <li key={idolCharacter.id}>{idolCharacter.nameDefault}</li>
              ))}
            </ul>
          </div>
      </div>
    );
  

}


export default App;
