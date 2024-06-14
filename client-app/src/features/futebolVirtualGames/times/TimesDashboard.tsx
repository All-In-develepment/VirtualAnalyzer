import { observer } from "mobx-react-lite";
import { useStore } from "../../../app/stores/store";
import { useEffect, useState } from "react";
import { GameTimes } from "../../../app/models/gameTimes";

import Paper from "@mui/material/Paper";
import Table from "@mui/material/Table";
import TableBody from "@mui/material/TableBody";
import TableCell from "@mui/material/TableCell";
import TableContainer from "@mui/material/TableContainer";
import TableHead from "@mui/material/TableHead";

import { Grid, TableRow, ThemeProvider, styled } from "@mui/material";
import GridRow from "semantic-ui-react/dist/commonjs/collections/Grid/GridRow";
import { Card, CardContent, Grid as GridSemantic } from "semantic-ui-react";
import { GridColumn } from "semantic-ui-react";

import Box from "@mui/material/Box";
import InputLabel from "@mui/material/InputLabel";
import MenuItem from "@mui/material/MenuItem";
import FormControl from "@mui/material/FormControl";
import Select, { SelectChangeEvent } from "@mui/material/Select";

export default observer(function TimesDashboard() {
  var keyLine = 0;
  var keyCell = 0;
  const { FutebolVirtualStore } = useStore();
  const { loadFutebolVirtualGames } = FutebolVirtualStore;

  const [selectedHours, setSelectedHours] = useState("12");
  const [selectedMarket, setSelectedMarket] = useState("OVER25");
  const [selectedTournament, setSelectedTournament] = useState("20700663");
  const [games, setGames] = useState<GameTimes>();

  async function handleTournamentButtonClick() {
    const gamesData = await loadFutebolVirtualGames(
      selectedTournament,
      selectedMarket,
      selectedHours
    );
    gamesData ? setGames(gamesData) : console.log("ihh rapaz");
  }

  const handleChangeTime = (event: SelectChangeEvent) => {
    setSelectedHours(event.target.value);
  };

  // const handleChangeMarket = (event: SelectChangeEvent) => {
  //   setSelectedMarket(event.target.value);
  // };

  useEffect(
    () => {
      handleTournamentButtonClick();
    },
    // eslint-disable-next-line react-hooks/exhaustive-deps
    [selectedTournament, selectedMarket, selectedHours]
  );

  const Item = styled(Paper)(({ theme }) => ({
    ...theme.typography.body2,
    textAlign: "center",
    color: theme.palette.text.secondary,
    height: 40,
    lineHeight: "40px",
  }));

  return (
    <>
      <Box sx={{ flexGrow: 1 }} justifyContent="center" alignItems="center">
        <Grid
          container
          columns={{ xs: 4, sm: 12, md: 12 }}
          justifyContent="center"
          alignItems="center"
          item
        >
          <Grid
            xs={2}
            sm={3}
            md={3}
            justifyContent="center"
            alignItems="center"
            onClick={() => setSelectedTournament("20700663")}
            className="bannerEuroCopa"
          >
            <img
              src="/assets/banners/euro_cup.jpg"
              alt="Euro Cup"
              className="leagues_buton"
            />
          </Grid>

          <Grid
            xs={2}
            sm={3}
            md={3}
            justifyContent="center"
            alignItems="center"
            onClick={() => setSelectedTournament("20120650")}
            className="bannerCopaDoMundo"
          >
            <img
              src="/assets/banners/copa_do_mundo.jpg"
              alt="Copa do Mundo"
              className="leagues_buton"
            />
          </Grid>

          <Grid
            xs={2}
            sm={3}
            md={3}
            justifyContent="center"
            alignItems="center"
            onClick={() => setSelectedTournament("20120653")}
            className="bannerPremierShip"
          >
            <img
              src="/assets/banners/premiership.jpg"
              alt="Premier League"
              className="leagues_buton"
            />
          </Grid>

          <Grid
            xs={2}
            sm={3}
            md={3}
            justifyContent="center"
            alignItems="center"
            onClick={() => setSelectedTournament("20849528")}
            className="bannerSuperLeague"
          >
            <img
              src="/assets/banners/superleague.jpg"
              alt="Sul-Americana"
              className="leagues_buton"
            />
          </Grid>
        </Grid>
      </Box>

      <GridSemantic>
        <GridRow>
          <GridColumn md={16} sm={16}>
            <Box sx={{ minWidth: 120 }}>
              <FormControl fullWidth>
                <InputLabel id="time-analyzer">Tempo de Analise</InputLabel>
                <Select
                  labelId="time-analyzer"
                  id="time-analyzer"
                  value={selectedHours}
                  label="Tempo de Analise"
                  onChange={handleChangeTime}
                  className="selectTempo"
                >
                  {/* <MenuItem value={3}>3 horas</MenuItem>
                  <MenuItem value={6}>6 horas</MenuItem> */}
                  <MenuItem value={9}>9 horas</MenuItem>
                  <MenuItem value={12}>12 horas</MenuItem>
                  <MenuItem value={24}>24 horas</MenuItem>
                  {/* <MenuItem value={72}>72 horas</MenuItem>
                  <MenuItem value={96}>96 horas</MenuItem> */}
                </Select>
              </FormControl>
            </Box>
          </GridColumn>

          {/* <GridColumn md={8}>
            <Box sx={{ minWidth: 120 }}> */}
          {/* LEGENDA
              <Box sx={{ display: 'flex', justifyContent: 'center', alignItems: 'center' }}>
                <Item>Green</Item>
                <Item>Red</Item>
                <Item>Futuros Jogos</Item>
              </Box> */}
          {/* <FormControl fullWidth>
                <InputLabel id="market-analyzer">Mercado</InputLabel>
                <Select
                  labelId="market-analyzer"
                  id="market-analyzer"
                  value={selectedMarket}
                  label="Mercado"
                  onChange={handleChangeMarket}
                >
                  <MenuItem value={"GOLSPAR"}>GOLS PAR</MenuItem>
                  <MenuItem value={"GOLSIMPAR"}>GOLS IMPAR</MenuItem>
                  <MenuItem value={"OVER05"}>OVER 0,5</MenuItem>
                  <MenuItem value={"OVER15"}>OVER 1,5</MenuItem>
                  <MenuItem value={"OVER25"}>OVER 2,5</MenuItem>
                  <MenuItem value={"OVER35"}>OVER 3,5</MenuItem>
                  <MenuItem value={"UNDER05"}>UNDER 0,5</MenuItem>
                  <MenuItem value={"UNDER15"}>UNDER 1,5</MenuItem>
                  <MenuItem value={"UNDER25"}>UNDER 2,5</MenuItem>
                  <MenuItem value={"UNDER35"}>UNDER 3,5</MenuItem>
                </Select>
              </FormControl> */}
          {/* </Box>
          </GridColumn> */}
        </GridRow>
      </GridSemantic>
      <br />

      {games && FutebolVirtualStore.loadingInitial === false ? (
        <GridSemantic container spacing={2}>
          {games.lines.map((line, index) => (
            <GridSemantic centered item xs={3} key={index}>
              <GridRow xs={16} centered>
                <Box
                  sx={{
                    p: 2,
                    borderRadius: 2,
                    display: "flex",
                    gridTemplateColumns: { md: "1fr 1fr" },
                    gap: 1,
                    textAlign: "center",
                    flexWrap: "wrap",
                    backgroundColor: "rgba(25, 73, 63, 1)",
                    width: "100%",
                  }}
                >
                  <Box width="100%" className="gray cellHorario">
                    <h3>Hora {line.hora}</h3>
                  </Box>
                  <br />
                  <GridSemantic item xs={12}>
                    <GridRow centered>
                      <Box
                        sx={{
                          p: 2,
                          borderRadius: 2,
                          display: "flex",
                          gridTemplateColumns: { md: "1fr 1fr" },
                          gap: 1,
                          flexWrap: "wrap",
                          textAlign: "center",
                        }}
                      >
                        {line.cells.map((cell, index) => (
                          <>
                            {cell.tooltip !== null ? (
                              <Box
                                sx={{
                                  p: 2,
                                  borderRadius: 2,
                                  display: "flex",
                                  gridTemplateColumns: { md: "1fr 1fr" },
                                  gap: 1,
                                  flexWrap: "wrap",
                                  textAlign: "center",
                                }}
                                key={index}
                                className={
                                  cell.isGreen === true
                                    ? "green cellHorario"
                                    : (cell.tooltip !== null &&
                                        cell.sumScore > 0) ||
                                      cell.result === "0-0"
                                    ? "red cellHorario"
                                    : "gray cellHorario"
                                }
                              >
                                {games.minutes[index].number} min
                                <br />
                                {cell.result}
                              </Box>
                            ) : (
                              <></>
                            )}
                          </>
                        ))}
                      </Box>
                    </GridRow>
                  </GridSemantic>
                </Box>
              </GridRow>
            </GridSemantic>
          ))}
        </GridSemantic>
      ) : (
        <></>
      )}
      <Paper sx={{ width: "100%", overflow: "hidden" }}>
        <TableContainer>
          {games && FutebolVirtualStore.loadingInitial === false ? (
            <Table aria-label="sticky tabel" className="tableHorarios">
              <TableHead>
                <TableRow>
                  <TableCell></TableCell>
                  {games.minutes.map((minute) => {
                    return (
                      <TableCell
                        className="table_header cellHorario"
                        key={keyLine++}
                        align="center"
                      >
                        {minute.number}
                      </TableCell>
                    );
                  })}
                </TableRow>
              </TableHead>
              <TableBody>
                {games.lines.map((line) => {
                  return (
                    <TableRow>
                      <TableCell className="coluna_esquerda" key={keyLine++}>
                        {line.hora}
                      </TableCell>
                      {line.cells.map((cell) => {
                        return (
                          <TableCell
                            key={keyCell++}
                            className={
                              cell.isGreen === true
                                ? "green cellHorario"
                                : (cell.tooltip !== null &&
                                    cell.sumScore > 0) ||
                                  cell.result === "0-0"
                                ? "red cellHorario"
                                : "gray cellHorario"
                            }
                          >
                            {cell.result}
                          </TableCell>
                        );
                      })}
                    </TableRow>
                  );
                })}
              </TableBody>
            </Table>
          ) : (
            <></>
          )}
        </TableContainer>
      </Paper>
    </>
  );
});
