import React, {Component} from 'react';
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
            <Icon name="users" id="headericon" />
            <div id="headerTitle" >ScoutMe</div> 
            <Header.Subheader id="subheader">
              <div id="headerDescription">Idolkowy serwis społecznościowy. I Ty możesz uratować swoją szkołę!</div>
            </Header.Subheader>
          </Header>
         
        </header>
          <div>
            <ul>
              {this.state.values.map((value: any) => (
                <li key={value.id}>{value.name}</li>
              ))}
            </ul>
          </div>
      </div>
    );
  }

}

export default App;
