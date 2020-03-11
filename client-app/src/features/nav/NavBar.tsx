import React from "react";
import { Menu, Icon, Container } from "semantic-ui-react";
import logo from "../../../public/assets/logo.png";

export const NavBar = () => {
  return (
    <Menu stackable color='pink'>
      <Menu.Item>
        <Icon name="users" id="headericon" />
      </Menu.Item>

      <Menu.Item>
      <div>
        <img src="/assets/logo.png" />
      </div>
      </Menu.Item>
      <Container>
        <Menu.Item name="features">Mapa</Menu.Item>

        <Menu.Item name="testimonials">Idolki</Menu.Item>

        <Menu.Item name="sign-in">Serie</Menu.Item>
      </Container>
    </Menu>
  );
};
