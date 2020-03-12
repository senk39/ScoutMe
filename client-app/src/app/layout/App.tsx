import React, { useState, useEffect, Fragment } from "react";
import "./styles.css";
import axios from "axios";
import { Header, Container } from "semantic-ui-react";
import { IIdolCharacter } from "../modules/idolCharacter";
import { NavBar } from "../../features/nav/NavBar";
import { IdolCharacterDashboard } from "../../features/idolCharacters/dashboard/IdolCharacterDashboard";

const App = () => {
  const [idolCharacters, setIdolCharacters] = useState<IIdolCharacter[]>([]);

  useEffect(() => {
    axios
      .get<IIdolCharacter[]>("http://localhost:5000/api/idolCharacters")
      .then(response => {
        setIdolCharacters(response.data);
      });
  }, []);

  return (
    <Fragment>
        <header className="App-header">
          <NavBar />
        </header>
        <p className="backgroundBox">
          <div className="contentContainer">
            <Container>
              <IdolCharacterDashboard idolCharacters={idolCharacters} />
            </Container>
          </div>
        </p>
      
    </Fragment>
  );
};

export default App;
