import { observer } from "mobx-react-lite";
import { useStore } from "../../../app/stores/store";

import {
  Grid,
  GridColumn,
  GridRow,
  Label,
  Table,
  TableBody,
  TableCell,
  TableHeader,
  TableHeaderCell,
} from "semantic-ui-react";
import { useEffect, useState } from "react";
import { Maximas } from "../../../app/models/maximas";

export default observer(function MaximasDashboard() {
  const { MaximasStore } = useStore();

  const { loadMaximas } = MaximasStore;

  const [selectedTournament, setSelectedTournament] = useState("20700663");
  const [dataTournament, setDataTournament] = useState<Maximas>();

  async function handleEffect() {
    const maximasData = await loadMaximas(selectedTournament);

    maximasData ? setDataTournament(maximasData) : console.log("ihh rapaz");
  }

  useEffect(
    () => {
      handleEffect();
    },
    // eslint-disable-next-line react-hooks/exhaustive-deps
    [selectedTournament]
  );

  return (
    <>
      <Grid>
        <GridRow columns={4} textAlign="center">
          <GridColumn onClick={() => setSelectedTournament("20700663")}>
            Euro Cup
          </GridColumn>
          <GridColumn onClick={() => setSelectedTournament("20120650")}>
            Copa do Mundo
          </GridColumn>
          <GridColumn onClick={() => setSelectedTournament("20120653")}>
            Premier Ship
          </GridColumn>
          <GridColumn onClick={() => setSelectedTournament("20849528")}>
            Super League
          </GridColumn>
        </GridRow>
      </Grid>

      {dataTournament?.listMaximas.map((listMaxima) => {
        return (
          <Table>
            <TableHeader key={listMaxima.id}>
              <TableHeaderCell key={listMaxima.id}>
                {listMaxima.nome}
              </TableHeaderCell>
            </TableHeader>
            <TableBody>
              <TableCell key={listMaxima.id++} textAlign="center" size="large">
                {listMaxima.porcentagem}
              </TableCell>
            </TableBody>
          </Table>
        );
      })}
    </>
  );
});
