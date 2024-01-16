import { observer } from "mobx-react-lite";
import { useStore } from "../../../app/stores/store";
import { useEffect, useState } from "react";
import { Grid, GridColumn, GridRow, Label, Table, TableBody, TableCell, TableHeader, TableHeaderCell } from "semantic-ui-react";
import { GameTimes } from "../../../app/models/gameTimes";

export default observer(function TimesDashboard() {
  var keyLine = 0;
  var keyCell = 0;
  const { FutebolVirtualStore } = useStore();
  const { loadFutebolVirtualGames } = FutebolVirtualStore;

  const [selectedHours, setSelectedHours] = useState("12");
  const [selectedMarket, setSelectedMarket] = useState("GOLSPAR");
  const [selectedTournament, setSelectedTournament] = useState("20700663");
  const [games, setGames] = useState<GameTimes>();

  async function handleTournamentButtonClick(){
    const gamesData = await loadFutebolVirtualGames(
      selectedTournament,
      selectedMarket,
      selectedHours
    );
    // console.log(`gamesData: ${gamesData}`)
    gamesData ? setGames(gamesData) : console.log("ihh rapaz");
    console.log(games)
  };

  
  const handleChangeTime = (event: React.ChangeEvent<HTMLSelectElement>) => {
    setSelectedHours(event.target.value);
  };
  
  const handleChangeMarket = (event: React.ChangeEvent<HTMLSelectElement>) => {
    setSelectedMarket(event.target.value);
  };

  useEffect(() => {
    handleTournamentButtonClick();
  }, [
    selectedTournament,
    selectedMarket,
    selectedHours,
  ]);

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

      <Grid>
        <GridRow>
          <Label htmlFor="timeChoese">Escolha uma opção:</Label>
          <select id="timeChoese" value={selectedHours} onChange={handleChangeTime}>
            <option value="3">3 horas</option>
            <option value="6">6 horas</option>
            <option value="9">9 horas</option>
            <option value="12">12 horas</option>
            <option value="24">24 horas</option>
            <option value="72">72 horas</option>
            <option value="96">96 horas</option>
          </select>

          <Label htmlFor="marketChoese">Escolha uma opção:</Label>
          <select id="marketChoese" value={selectedMarket} onChange={handleChangeMarket}>
            <option value="GOLSPAR">GOLS PAR</option>
            <option value="GOLSIMPAR">GOLS IMPAR</option>
            <option value="OVER05">OVER 0,5</option>
            <option value="OVER15">OVER 1,5</option>
            <option value="OVER25">OVER 2,5</option>
            <option value="OVER35">OVER 3,5</option>
            <option value="UNDER05">UNDER 0,5</option>
            <option value="UNDER15">UNDER 1,5</option>
            <option value="UNDER25">UNDER 2,5</option>
            <option value="UNDER35">UNDER 3,5</option>
          </select>
        </GridRow>
      </Grid>

      {games && FutebolVirtualStore.loadingInitial === false ? (
        <Table>
          <TableHeader>
            <TableHeaderCell></TableHeaderCell>
            {games.minutes.map((minute) => {
              return (
                <TableHeaderCell key={keyLine++}>{minute.number}</TableHeaderCell>
              )
            })}
          </TableHeader>
          {games.lines.map((line) => {
            return (
                  <TableBody>
                    <TableHeaderCell key={keyLine++}>{line.hora}</TableHeaderCell>
                    {
                      line.cells.map((cell) => {
                        return (
                          <TableCell key={keyCell++} className={cell.isGreen === true ? "positive" : (cell.tooltip !== null ? "negative" : "gray")} textAlign="center" size="large">
                            {cell.result}
                          </TableCell>
                        )
                      })
                    }
                  </TableBody>
            )
          })}
        </Table>
      ) : (
        <></>
      )}
    </>
  );
});
