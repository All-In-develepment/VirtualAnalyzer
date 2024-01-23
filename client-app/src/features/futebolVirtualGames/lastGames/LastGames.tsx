import { useEffect, useState } from "react";
import { useStore } from "../../../app/stores/store";
import { observer } from "mobx-react-lite";
import { ILastGames } from "../../../app/models/lastGames";
import moment from "moment-timezone";
import { Accordion, AccordionContent, AccordionTitle, Grid, GridColumn, GridRow, Table } from "semantic-ui-react";

export default observer(function LastGames() {
  type AccordionData = {
    title: string;
    content: string;
  };

  type AccordionProps = {
    data: AccordionData[]; // Um array de objetos com título e conteúdo
  };
  
  const { LastGames } = useStore();
  const { loadLastGames } = LastGames;

  const [data, setData] = useState<ILastGames[]>();

  async function handleEffect() {
    const date = moment().format("YYYY-MM-DD");

    const lastGamesData = await loadLastGames(date);

    lastGamesData ? setData(lastGamesData) : console.log("ihh rapaz");
  }

  useEffect(
    () => {
      handleEffect();
    },
    // eslint-disable-next-line react-hooks/exhaustive-deps
    []
  );

  return (
    <>
      <Grid textAlign="center">
        <GridRow columns={4}>
          {data &&
            data.map((game) => (
              <GridColumn key={game.id}>
                <div className="table_detail_header">
                  {game.competition}
                </div>

                <Table textAlign="center">
                  {game.matches.map((match, index) => (

                    <Table.Row key={index} className="table_detail_body">

                      <Table.Cell>
                        <GridRow width={16}>
                          <img src={`/assets/flags/${match.homeImg}`} alt={match.homeImg} width={60}/>
                        </GridRow>
                        <GridRow width={16}>
                          {match.teamHome}
                        </GridRow>
                      </Table.Cell>

                      <Table.Cell>
                        {match.finalTimeResult}
                      </Table.Cell>

                      <Table.Cell>
                        <GridRow width={16}>
                          <img src={`/assets/flags/${match.awayImg}`} alt={match.awayImg} width={60}/>
                        </GridRow>
                        <GridRow width={16}>
                          {match.teamAway}
                        </GridRow>
                      </Table.Cell>
                      
                    </Table.Row>
                  ))}
                </Table>
              </GridColumn>
            ))
          }
        </GridRow>
      </Grid>
    </>
  );
});
