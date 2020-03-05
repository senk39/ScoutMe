import React, {Component} from 'react';
import logo from './logo.svg';
import './App.css';
import axios from 'axios';
import { Header, Icon } from 'semantic-ui-react'

class App extends Component {

  state = {
    values: []
  }

  componentDidMount(){
    axios.get('http://localhost:5000/api/values')
    .then((response) => {
      console.log(response);
      this.setState({
        values: response.data

      })
    })

  }

  render(){
    return (
      <div className="App">
        <header className="App-header">
          <Header idols="h2" icon>
            <Icon name="users" />
            ScoutMe
            <Header.Subheader>
              Idolkowy serwis społecznościowy. I Ty możesz uratować swoją szkołę!
            </Header.Subheader>
          </Header>
         
        </header>
          <div>
            <ul>
              {this.state.values.map((value: any) => (
                <h3><li key={value.id}>{value.name}</li></h3>
              ))}
            </ul>
          </div>
      </div>
    );
  }

}

export default App;
