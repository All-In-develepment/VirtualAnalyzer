import { observer } from "mobx-react-lite";
import { useStore } from "../../../app/stores/store";
import { useEffect, useState } from "react";
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
  TableRow,
} from "semantic-ui-react";
import {
  GameTimes,
  LoadGamesResult,
  TournamentNames,
} from "../../../app/models/gameTimes";

export default observer(function MultiTimesDashboard() {
  var keyLine = 0;
  var keyCell = 0;
  const { FutebolVirtualStore } = useStore();
  const { loadFutebolVirtualGames } = FutebolVirtualStore;

  const [selectedHours, setSelectedHours] = useState("12");
  const [selectedMarket, setSelectedMarket] = useState("GOLSPAR");

  const initialGamesData: Record<keyof TournamentNames, GameTimes | undefined> =
    {
      "Euro Cup": undefined,
      "Copa do Mundo": undefined,
      "Premier League": undefined,
      "Sul-Americana": undefined,
    };

  const [games, setGames] =
    useState<Record<keyof TournamentNames, GameTimes | undefined>>(
      initialGamesData
    );

  const tournamentNames: TournamentNames = {
    "Euro Cup": "20700663",
    "Copa do Mundo": "20120650",
    "Premier League": "20120653",
    "Sul-Americana": "20849528",
  };

  const loadGamesForTournament = async (
    tournament: string,
    market: string,
    hours: string
  ) => {
    return await loadFutebolVirtualGames(tournament, market, hours);
  };

  async function handleTournamentButtonClick() {
    const gamesData = await loadAllGames();

    gamesData ? setGames(gamesData) : console.log("ihh rapaz");
  }

  const loadAllGames = async () => {
    try {
      const promises = Object.entries(tournamentNames).map(
        ([name, tournament]) =>
          loadGamesForTournament(tournament, selectedMarket, selectedHours)
            .then((result) => ({ name, result } as LoadGamesResult))
            .catch((error) => {
              console.error(
                `Erro ao carregar jogos para o torneio ${name}:`,
                error
              );
              return { name, error } as LoadGamesResult;
            })
      );

      const results = await Promise.allSettled(promises);

      const consolidatedGamesData: Record<
        keyof TournamentNames,
        GameTimes | undefined
      > = results.reduce((acc, result) => {
        if (result.status === "fulfilled" && result.value.result) {
          const { name, result: games } = result.value;
          acc[name] = games;
        } else if (result.status === "rejected") {
          const { name, error } = result.reason;
          console.error(
            `Erro ao carregar jogos para o torneio ${name}:`,
            error
          );
        }
        return acc;
      }, {} as Record<keyof TournamentNames, GameTimes | undefined>);

      console.log(consolidatedGamesData);
      return consolidatedGamesData;
    } catch (error) {
      console.error("Erro ao carregar jogos:", error);
    }
  };

  const handleChangeTime = (event: React.ChangeEvent<HTMLSelectElement>) => {
    setSelectedHours(event.target.value);
  };

  const handleChangeMarket = (event: React.ChangeEvent<HTMLSelectElement>) => {
    setSelectedMarket(event.target.value);
  };

  useEffect(
    () => {
      handleTournamentButtonClick();
    },
    // eslint-disable-next-line react-hooks/exhaustive-deps
    [selectedMarket, selectedHours]
  );

  return (
    <>
      <Grid>
        <GridRow>
          <Label htmlFor="timeChoese">Escolha uma opção:</Label>
          <select
            id="timeChoese"
            value={selectedHours}
            onChange={handleChangeTime}
          >
            <option value="3">3 horas</option>
            <option value="6">6 horas</option>
            <option value="9">9 horas</option>
            <option value="12">12 horas</option>
            <option value="24">24 horas</option>
            <option value="72">72 horas</option>
            <option value="96">96 horas</option>
          </select>

          <Label htmlFor="marketChoese">Escolha uma opção:</Label>
          <select
            id="marketChoese"
            value={selectedMarket}
            onChange={handleChangeMarket}
          >
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

      <Grid>
        <GridRow columns={2}>
          {Object.entries(games).map(([tournament, gameData]) => (
            <GridColumn md={8} sm={16}>
              <h2>{tournament}</h2>
              {gameData && FutebolVirtualStore.loadingInitial === false ? (
                <Table key={tournament}>
                  <TableHeader>
                    <TableRow>
                      <TableHeaderCell></TableHeaderCell>
                      {gameData.minutes.map((minute) => (
                        <TableHeaderCell key={keyLine++}>
                          {minute.number}
                        </TableHeaderCell>
                      ))}
                    </TableRow>
                  </TableHeader>

                  {gameData.lines.map((line) => (
                    <TableBody key={keyLine++}>
                      <TableRow>
                        <TableHeaderCell>{line.hora}</TableHeaderCell>
                        {line.cells.map((cell) => (
                          <TableCell
                            key={keyCell++}
                            className={
                              cell.isGreen === true
                                ? "positive"
                                : cell.tooltip !== null
                                ? "negative"
                                : "gray"
                            }
                            textAlign="center"
                            size="large"
                          >
                            {cell.result}
                          </TableCell>
                        ))}
                      </TableRow>
                    </TableBody>
                  ))}
                </Table>
              ) : (
                <></>
              )}
            </GridColumn>
          ))}
        </GridRow>
      </Grid>
    </>
  );
});
