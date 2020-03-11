import React, {useState, useEffect} from 'react';
import './styles.css';
import axios from 'axios';
import { Header, Icon } from 'semantic-ui-react'
import { IIdolCharacter } from '../modules/idolCharacter';



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
          <Header idols="h2" icon>
            <Icon name="users" id="headericon" />
            <div id="headerTitle" >ScoutMe</div> 
            <Header.Subheader id="subheader">
              <div id="headerDescription">Idolkowy serwis społecznościowy. I Ty możesz uratować swoją szkołę!</div>
            </Header.Subheader>
          </Header>
         
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
