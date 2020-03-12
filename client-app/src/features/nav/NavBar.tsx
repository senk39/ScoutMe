import React from "react";
import { Menu, Container } from "semantic-ui-react";
//import logo from "../../../public/assets/logo.png";

export const NavBar = () => {
  return (
    <Menu fixed='top' stackable  color="pink">
      <Menu.Item className="logoPadding">
        <div>
          <img src="/assets/logo.png" />
        </div>
      </Menu.Item>

      <div className="emptySpaceInTopMenu" ></div>
      
        <Container>
        
          <Menu.Item name="features">Mapa</Menu.Item>
          
          <Menu.Item name="testimonials">Idolki</Menu.Item>

          <Menu.Item name="sign-in">Serie</Menu.Item>
          
        </Container>
     
    </Menu>
  );
};
