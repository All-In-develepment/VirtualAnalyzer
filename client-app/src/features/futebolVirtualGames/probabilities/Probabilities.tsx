import { observer } from "mobx-react-lite";
import { useEffect, useState } from "react";
import { useStore } from "../../../app/stores/store";

import { Maximas } from "../../../app/models/maximas";
import { Box, Grid } from "@mui/material";

interface IMaximaTournament {
  [tournamentId: string]: Maximas;
}

export default observer(function Probabilities() {
  const { MaximasStore } = useStore();
  const { loadMaximas } = MaximasStore;

  const euroCopa = "20700663";
  const copaDoMundo = "20120650";
  const premierShip = "20120653";
  const superLeague = "20849528";

  const listTournament = [euroCopa, copaDoMundo, premierShip, superLeague];

  const [maxima, setMaxima] = useState<IMaximaTournament | null>(null);

  async function handleEffect() {
    const result = await Promise.all(
      listTournament.map(async (tournament) => {
        const maximasLoaded = await loadMaximas(tournament);
        return maximasLoaded ? { [tournament]: maximasLoaded } : {};
      })
    );
    const maximaObject: IMaximaTournament = result.reduce((acc, current) => {
      return { ...acc, ...current };
    }, {} as IMaximaTournament);

    setMaxima(maximaObject);
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
      <Grid container spacing={2}>
        {/* Primeira linha */}
        <Grid item xs={6}>
          <Box
            sx={{
              padding: 2,
              backgroundColor: "lightblue",
              display: "flex",
              justifyContent: "center",
              alignItems: "center",
              height: "100px",
            }}
          >
            <Box width="100%" className="gray cellHorario">
              <h3>EuroCopa</h3>
              {maxima &&
                maxima[euroCopa].listMaximas
                  .filter((filterMax) => filterMax.nome === "over_25")
                  .map((maxima) => {
                    const porcentagem =
                      maxima.porcentagem <= 10
                        ? 10
                        : maxima.porcentagem.toFixed(2);
                    return `${porcentagem}%`;
                  })}
            </Box>
          </Box>
        </Grid>
        <Grid item xs={6}>
          <Box
            sx={{
              padding: 2,
              backgroundColor: "lightgreen",
              display: "flex",
              justifyContent: "center",
              alignItems: "center",
              height: "100px",
            }}
          >
            <Box width="100%" className="gray cellHorario">
              <h3>Copa do Mundo</h3>
              {maxima &&
                maxima[copaDoMundo].listMaximas
                  .filter((filterMax) => filterMax.nome === "over_25")
                  .map((maxima) => {
                    const porcentagem =
                      maxima.porcentagem <= 10
                        ? 10
                        : maxima.porcentagem.toFixed(2);
                    return `${porcentagem}%`;
                  })}
            </Box>
          </Box>
        </Grid>

        {/* Segunda linha */}
        <Grid item xs={6}>
          <Box
            sx={{
              padding: 2,
              backgroundColor: "lightcoral",
              display: "flex",
              justifyContent: "center",
              alignItems: "center",
              height: "100px",
            }}
          >
            <Box width="100%" className="gray cellHorario">
              <h3>PremierShip</h3>
              {maxima &&
                maxima[premierShip].listMaximas
                  .filter((filterMax) => filterMax.nome === "over_25")
                  .map((maxima) => {
                    const porcentagem =
                      maxima.porcentagem <= 10
                        ? 10
                        : maxima.porcentagem.toFixed(2);
                    return `${porcentagem}%`;
                  })}
            </Box>
          </Box>
        </Grid>
        <Grid item xs={6}>
          <Box
            sx={{
              padding: 2,
              backgroundColor: "lightgrey",
              display: "flex",
              justifyContent: "center",
              alignItems: "center",
              height: "100px",
            }}
          >
            <Box width="100%" className="gray cellHorario">
              <h3>Super Liga</h3>
              {maxima &&
                maxima[superLeague].listMaximas
                  .filter((filterMax) => filterMax.nome === "over_25")
                  .map((maxima) => {
                    const porcentagem =
                      maxima.porcentagem <= 10
                        ? 10
                        : maxima.porcentagem.toFixed(2);
                    return `${porcentagem}%`;
                  })}
            </Box>
          </Box>
        </Grid>
      </Grid>
    </>
  );
});
