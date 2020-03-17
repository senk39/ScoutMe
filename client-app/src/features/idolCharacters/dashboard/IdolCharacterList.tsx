import React from "react";
import { Grid, Image, Item, Header, Segment } from "semantic-ui-react";
import { IIdolCharacter } from "../../../app/modules/idolCharacter";

const colors = [
  "red",
  "orange",
  "yellow",
  "olive",
  "green",
  "teal",
  "blue",
  "violet",
  "purple",
  "pink",
  "brown",
  "grey",
  "black"
];


interface IProps {
  idolCharacters: IIdolCharacter[];
}

export const IdolCharacterList: React.FC<IProps> = ({ idolCharacters }) => {
  return (
    <div className="IdolListGrid">
      <div className="ui huge pink header">µ's</div>

      <Grid columns={1}>
        <Grid.Row>
          <Grid.Column>
            {idolCharacters.map(idolCharacter => (
              <Segment>
                <div className="ui link items">
                  <div className="item">
                    <div className="ui image">
                    <img src={`././././assets/idolCharactersProfilePics/inCircle/${idolCharacter.group}/${idolCharacter.nameEng}.png`}></img>

                    
                    </div>

                    <Item.Group divider>
                      <Item key={idolCharacter.id}>
                        <Item.Content>
                          <Item.Header as="a">
                            {idolCharacter.nameDefault}
                          </Item.Header>
                          <Item.Meta as="a">
                            {" "}
                            {idolCharacter.bustSize}
                          </Item.Meta>
                          <div className="description">Eluwina, jestem {idolCharacter.nameEng}</div>
                          <div className="description2">Grupa: {idolCharacter.group}</div>
                          <b><p className="idolDescr">Opis: {idolCharacter.description}</p></b>
                        </Item.Content>
                      </Item>
                    </Item.Group>

                    {/* <div className="header">{idolCharacter.defaultName}</div> */}
                  </div>
                  
                </div>

               
              </Segment>
            ))}
          </Grid.Column>
        </Grid.Row>
      </Grid>
      <Grid columns={3}>
        <Grid.Row>
          <Grid.Column>
            <div>
              <Image
                className="idolImage"
                src="././././assets/idolCharactersProfilePics/inCircle/Muse/Eli.png"
              />{" "}
            </div>
          </Grid.Column>
          <Grid.Column>
            <div>
              <Image
                className="idolImage"
                src="././././assets/idolCharactersProfilePics/inCircle/Muse/Hanayo.png"
              />{" "}
            </div>
          </Grid.Column>
        </Grid.Row>

        <Grid.Row>
          <Grid.Column>
            <div>
              <Image
                className="idolImage"
                src="././././assets/idolCharactersProfilePics/inCircle/Muse/Kotori.png"
              />{" "}
            </div>
          </Grid.Column>
          <Grid.Column>
            <div>
              <Image
                className="idolImage"
                src="././././assets/idolCharactersProfilePics/inCircle/Muse/Maki.png"
              />{" "}
            </div>
          </Grid.Column>
          <Grid.Column>
            <div>
              <Image
                className="idolImage"
                src="././././assets/idolCharactersProfilePics/inCircle/Muse/Nico.png"
              />
            </div>
          </Grid.Column>
        </Grid.Row>

        <Grid.Row>
          <Grid.Column>
            <div>
              <Image
                className="idolImage"
                src="././././assets/idolCharactersProfilePics/inCircle/Muse/Nozomi.png"
              />{" "}
            </div>
          </Grid.Column>
          <Grid.Column>
            <div>
              <Image
                className="idolImage"
                src="././././assets/idolCharactersProfilePics/inCircle/Muse/Rin.png"
              />{" "}
            </div>
          </Grid.Column>
          <Grid.Column>
            <div>
              <Image
                className="idolImage"
                src="././././assets/idolCharactersProfilePics/inCircle/Muse/Umi.png"
              />{" "}
            </div>
          </Grid.Column>
        </Grid.Row>

        <div className="ui huge pink header">Aqours</div>
        <Grid.Row>
          <Grid.Column>
            <div>
              <Image
                className="idolImage"
                src="././././assets/idolCharactersProfilePics/inCircle/Aqours/Chika.png"
              />{" "}
            </div>
          </Grid.Column>
          <Grid.Column>
            <div>
              <Image
                className="idolImage"
                src="././././assets/idolCharactersProfilePics/inCircle/Aqours/Dia.png"
              />{" "}
            </div>
          </Grid.Column>
          <Grid.Column>
            <div>
              <Image
                className="idolImage"
                src="././././assets/idolCharactersProfilePics/inCircle/Aqours/Hanamaru.png"
              />{" "}
            </div>
          </Grid.Column>
        </Grid.Row>

        <Grid.Row>
          <Grid.Column>
            <div>
              <Image
                className="idolImage"
                src="././././assets/idolCharactersProfilePics/inCircle/Aqours/Kanan.png"
              />{" "}
            </div>
          </Grid.Column>
          <Grid.Column>
            <div>
              <Image
                className="idolImage"
                src="././././assets/idolCharactersProfilePics/inCircle/Aqours/Mari.png"
              />{" "}
            </div>
          </Grid.Column>
          <Grid.Column>
            <div>
              <Image
                className="idolImage"
                src="././././assets/idolCharactersProfilePics/inCircle/Aqours/Riko.png"
              />{" "}
            </div>
          </Grid.Column>
        </Grid.Row>

        <Grid.Row>
          <Grid.Column>
            <div>
              <Image
                className="idolImage"
                src="././././assets/idolCharactersProfilePics/inCircle/Aqours/Ruby.png"
              />{" "}
            </div>
          </Grid.Column>
          <Grid.Column>
            <div>
              <Image
                className="idolImage"
                src="././././assets/idolCharactersProfilePics/inCircle/Aqours/Yoshiko.png"
              />{" "}
            </div>
          </Grid.Column>
          <Grid.Column>
            <div>
              <Image
                className="idolImage"
                src="././././assets/idolCharactersProfilePics/inCircle/Aqours/You.png"
              />{" "}
            </div>
          </Grid.Column>
        </Grid.Row>

        <div className="ui huge pink header">
          Nijigasaki High School Idol Club
        </div>
        <Grid.Row>
          <Grid.Column>
            <div>
              <Image
                className="idolImage"
                src="././././assets/idolCharactersProfilePics/inCircle/Nijigasaki/Ai.png"
              />{" "}
            </div>
          </Grid.Column>
          <Grid.Column>
            <div>
              <Image
                className="idolImage"
                src="././././assets/idolCharactersProfilePics/inCircle/Nijigasaki/Ayumu.png"
              />{" "}
            </div>
          </Grid.Column>
          <Grid.Column>
            <div>
              <Image
                className="idolImage"
                src="././././assets/idolCharactersProfilePics/inCircle/Nijigasaki/Emma.png"
              />{" "}
            </div>
          </Grid.Column>
        </Grid.Row>

        <Grid.Row>
          <Grid.Column>
            <div>
              <Image
                className="idolImage"
                src="././././assets/idolCharactersProfilePics/inCircle/Nijigasaki/Kanata.png"
              />{" "}
            </div>
          </Grid.Column>
          <Grid.Column>
            <div>
              <Image
                className="idolImage"
                src="././././assets/idolCharactersProfilePics/inCircle/Nijigasaki/Karin.png"
              />{" "}
            </div>
          </Grid.Column>
          <Grid.Column>
            <div>
              <Image
                className="idolImage"
                src="././././assets/idolCharactersProfilePics/inCircle/Nijigasaki/Kasumi.png"
              />{" "}
            </div>
          </Grid.Column>
        </Grid.Row>

        <Grid.Row>
          <Grid.Column>
            <div>
              <Image
                className="idolImage"
                src="././././assets/idolCharactersProfilePics/inCircle/Nijigasaki/Rina.png"
              />{" "}
            </div>
          </Grid.Column>
          <Grid.Column>
            <div>
              <Image
                className="idolImage"
                src="././././assets/idolCharactersProfilePics/inCircle/Nijigasaki/Setsuna.png"
              />{" "}
            </div>
          </Grid.Column>
          <Grid.Column>
            <div>
              <Image
                className="idolImage"
                src="././././assets/idolCharactersProfilePics/inCircle/Nijigasaki/Shizuku.png"
              />{" "}
            </div>
          </Grid.Column>
        </Grid.Row>
      </Grid>
    </div>
  );
};

export default IdolCharacterList;
