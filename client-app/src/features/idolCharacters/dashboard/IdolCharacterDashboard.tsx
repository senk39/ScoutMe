import React from "react";
import { Grid, List } from "semantic-ui-react";
import { IIdolCharacter } from "../../../app/modules/idolCharacter";
import IdolCharacterList from './IdolCharacterList';

interface IProps {
    idolCharacters: IIdolCharacter[]
}

export const IdolCharacterDashboard: React.FC<IProps> = ({idolCharacters}) => {
  return (
    <Grid centered>
      <Grid.Column width={10}>
        {/* <List>
          {idolCharacters.map(idolCharacter => (
            <List.Item key={idolCharacter.id}>{idolCharacter.nameDefault}</List.Item>
          ))}
        </List> */}
        <IdolCharacterList />
      </Grid.Column>
    </Grid>
  );
};
