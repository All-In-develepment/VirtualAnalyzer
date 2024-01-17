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
import MainLineChart from "../../../app/common/chart/mainLineChart";

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

      {dataTournament && (
        <MainLineChart 
          over15={dataTournament.chart.over15}
          over25={dataTournament.chart.over25}
          under25={dataTournament.chart.under25}
          ambasMarcam={dataTournament.chart.ambasMarcam}
          casaHT={dataTournament.chart.casaHT}
          empateHT={dataTournament.chart.empateHT}
          visitanteHT={dataTournament.chart.visitanteHT}
          casaFT={dataTournament.chart.casaFT}
          empateFT={dataTournament.chart.empateFT}
          visitanteFT={dataTournament.chart.visitanteFT}
          empateOuCasa={dataTournament.chart.empateOuCasa}
          visitanteOuCasa={dataTournament.chart.visitanteOuCasa}
          empateOuVisitante={dataTournament.chart.empateOuVisitante}
        />
      )}

      <Grid>
        <GridRow columns={2} textAlign="center">
          {/* Primeir Coluna */}
          <GridColumn></GridColumn>

          {/* Segunda Coluna */}
          <GridColumn size={16}>
            <Label size="large" color="blue">
              GOLS IMPAR / PAR 
            </Label>
            {/* Sessão PAR / IMPAR */}
            <Grid>
              <GridRow columns={2} >
                <GridColumn size={8}>
                  IMPAR(sem sair)<br />
                  {dataTournament?.listMaximas[100].nome}<br />
                  {dataTournament?.listMaximas[100].atual}<br />
                  {dataTournament?.listMaximas[100].maxima}
                </GridColumn>
                <GridColumn>
                  PAR(sem sair)<br />
                  {dataTournament?.listMaximas[101].nome}<br />
                  {dataTournament?.listMaximas[101].atual}<br />
                  {dataTournament?.listMaximas[101].maxima}
                </GridColumn>
              </GridRow>
            </Grid>

            {/* Sessão OVER GOLS */}
            <Label size="large" color="blue">
              OVER GOLS
            </Label>
            <Grid>
              <GridRow columns={4}>
                <GridColumn>
                  OVER 0.5<br />
                  {dataTournament?.listMaximas[0].nome}<br />
                  {dataTournament?.listMaximas[0].atual}<br />
                  {dataTournament?.listMaximas[0].maxima}
                </GridColumn>
                <GridColumn>
                  OVER 1.5<br />
                  {dataTournament?.listMaximas[1].nome}<br />
                  {dataTournament?.listMaximas[1].atual}<br />
                  {dataTournament?.listMaximas[1].maxima}
                </GridColumn>
                <GridColumn>
                  OVER 2.5<br />
                  {dataTournament?.listMaximas[2].nome}<br />
                  {dataTournament?.listMaximas[2].atual}<br />
                  {dataTournament?.listMaximas[2].maxima}
                </GridColumn>
                <GridColumn>
                  OVER 3.5<br />
                  {dataTournament?.listMaximas[3].nome}<br />
                  {dataTournament?.listMaximas[3].atual}<br />
                  {dataTournament?.listMaximas[3].maxima}
                </GridColumn>
              </GridRow>
            </Grid>

            {/* Sessão UNDER GOLS */}
            <Label size="large" color="blue">
              UNDER GOLS
            </Label>
            <Grid>
              <GridRow columns={4}>
                <GridColumn>
                  UNDER 0.5<br />
                  {dataTournament?.listMaximas[4].nome}<br />
                  {dataTournament?.listMaximas[4].atual}<br />
                  {dataTournament?.listMaximas[4].maxima}
                </GridColumn>
                <GridColumn>
                  UNDER 1.5<br />
                  {dataTournament?.listMaximas[5].nome}<br />
                  {dataTournament?.listMaximas[5].atual}<br />
                  {dataTournament?.listMaximas[5].maxima}
                </GridColumn>
                <GridColumn>
                  UNDER 2.5<br />
                  {dataTournament?.listMaximas[6].nome}<br />
                  {dataTournament?.listMaximas[6].atual}<br />
                  {dataTournament?.listMaximas[6].maxima}
                </GridColumn>
                <GridColumn>
                  UNDER 3.5<br />
                  {dataTournament?.listMaximas[7].nome}<br />
                  {dataTournament?.listMaximas[7].atual}<br />
                  {dataTournament?.listMaximas[7].maxima}
                </GridColumn>
              </GridRow>
            </Grid>

            {/* Sessão GOLS Exatos */}
            <Label size="large" color="blue">
              GOLS EXATOS
            </Label>
            <Grid>
              <GridRow columns={6}>
                <GridColumn>
                  0 GOLS<br />
                  {dataTournament?.listMaximas[79].nome}<br />
                  {dataTournament?.listMaximas[79].atual}<br />
                  {dataTournament?.listMaximas[79].maxima}
                </GridColumn>
                <GridColumn>
                  1 GOLS<br />
                  {dataTournament?.listMaximas[8].nome}<br />
                  {dataTournament?.listMaximas[8].atual}<br />
                  {dataTournament?.listMaximas[8].maxima}
                </GridColumn>
                <GridColumn>
                  2 GOLS<br />
                  {dataTournament?.listMaximas[9].nome}<br />
                  {dataTournament?.listMaximas[9].atual}<br />
                  {dataTournament?.listMaximas[9].maxima}
                </GridColumn>
                <GridColumn>
                  3 GOLS<br />
                  {dataTournament?.listMaximas[10].nome}<br />
                  {dataTournament?.listMaximas[10].atual}<br />
                  {dataTournament?.listMaximas[10].maxima}
                </GridColumn>
                <GridColumn>
                  4 GOLS<br />
                  {dataTournament?.listMaximas[11].nome}<br />
                  {dataTournament?.listMaximas[11].atual}<br />
                  {dataTournament?.listMaximas[11].maxima}
                </GridColumn>
                <GridColumn>
                  5 GOLS<br />
                  {dataTournament?.listMaximas[135].nome}<br />
                  {dataTournament?.listMaximas[135].atual}<br />
                  {dataTournament?.listMaximas[135].maxima}
                </GridColumn>
              </GridRow>
            </Grid>

            {/* Sessão AMBAS MARCAM */}
            <Label size="large" color="blue">
              AMBAS MARCAM
            </Label>
            <Grid>
              <GridRow columns={2}>
                <GridColumn>
                  SIM<br />
                  {dataTournament?.listMaximas[35].nome}<br />
                  {dataTournament?.listMaximas[35].atual}<br />
                  {dataTournament?.listMaximas[35].maxima}
                </GridColumn>
                <GridColumn>
                  NÃO<br />
                  {dataTournament?.listMaximas[36].nome}<br />
                  {dataTournament?.listMaximas[36].atual}<br />
                  {dataTournament?.listMaximas[36].maxima}
                </GridColumn>
              </GridRow>
            </Grid>

            {/* Sessão Resultado Intervalo / HT */}
            <Label size="large" color="blue">
              RESULTADO INTERVALO / HT
            </Label>
            <Grid>
              <GridRow columns={3}>
                <GridColumn>
                  CASA<br />
                  {dataTournament?.listMaximas[94].nome}<br />
                  {dataTournament?.listMaximas[94].atual}<br />
                  {dataTournament?.listMaximas[94].maxima}
                </GridColumn>
                <GridColumn>
                  EMPATE<br />
                  {dataTournament?.listMaximas[95].nome}<br />
                  {dataTournament?.listMaximas[95].atual}<br />
                  {dataTournament?.listMaximas[95].maxima}
                </GridColumn>
                <GridColumn>
                  VISITANTE<br />
                  {dataTournament?.listMaximas[96].nome}<br />
                  {dataTournament?.listMaximas[96].atual}<br />
                  {dataTournament?.listMaximas[96].maxima}
                </GridColumn>
              </GridRow>
            </Grid>

            {/* Sessão Resultado Final / FT */}
            <Label size="large" color="blue">
              RESULTADO FINAL / FT
            </Label>
            <Grid>
              <GridRow columns={3}>
                <GridColumn>
                  CASA<br />
                  {dataTournament?.listMaximas[97].nome}<br />
                  {dataTournament?.listMaximas[97].atual}<br />
                  {dataTournament?.listMaximas[97].maxima}
                </GridColumn>
                <GridColumn>
                  EMPATE<br />
                  {dataTournament?.listMaximas[98].nome}<br />
                  {dataTournament?.listMaximas[98].atual}<br />
                  {dataTournament?.listMaximas[98].maxima}
                </GridColumn>
                <GridColumn>
                  VISITANTE<br />
                  {dataTournament?.listMaximas[99].nome}<br />
                  {dataTournament?.listMaximas[99].atual}<br />
                  {dataTournament?.listMaximas[99].maxima}
                </GridColumn>
              </GridRow>
            </Grid>

            {/* Sessão Placar Exato FT */}
            <Label size="large" color="blue">
              PLACAR EXATO FT
            </Label>
            <Grid>
              <GridRow columns={3}>
                <GridColumn>Casa</GridColumn>
                <GridColumn>Empate</GridColumn>
                <GridColumn>Visitante</GridColumn>
              </GridRow>
              <GridRow columns={3}>
                <GridColumn>
                  {dataTournament?.listMaximas[23].nome}<br />
                  {dataTournament?.listMaximas[23].atual}<br />
                  {dataTournament?.listMaximas[23].maxima}
                </GridColumn>
                <GridColumn>
                  {dataTournament?.listMaximas[13].nome}<br />
                  {dataTournament?.listMaximas[13].atual}<br />
                  {dataTournament?.listMaximas[13].maxima}
                </GridColumn>
                <GridColumn>
                  {dataTournament?.listMaximas[14].nome}<br />
                  {dataTournament?.listMaximas[14].atual}<br />
                  {dataTournament?.listMaximas[14].maxima}
                </GridColumn>
              </GridRow>
              <GridRow columns={3}>
                <GridColumn>
                  {dataTournament?.listMaximas[24].nome}<br />
                  {dataTournament?.listMaximas[24].atual}<br />
                  {dataTournament?.listMaximas[24].maxima}
                </GridColumn>
              </GridRow>
              <GridRow columns={3}>
                <GridColumn>
                  {dataTournament?.listMaximas[25].nome}<br />
                  {dataTournament?.listMaximas[25].atual}<br />
                  {dataTournament?.listMaximas[25].maxima}
                </GridColumn>
              </GridRow>
              <GridRow columns={3}>
                <GridColumn>
                  {dataTournament?.listMaximas[26].nome}<br />
                  {dataTournament?.listMaximas[26].atual}<br />
                  {dataTournament?.listMaximas[26].maxima}
                </GridColumn>
              </GridRow>
              <GridRow columns={3}>
                <GridColumn>
                  {dataTournament?.listMaximas[27].nome}<br />
                  {dataTournament?.listMaximas[27].atual}<br />
                  {dataTournament?.listMaximas[27].maxima}
                </GridColumn>
              </GridRow>
              <GridRow columns={3}>
                <GridColumn>
                  {dataTournament?.listMaximas[28].nome}<br />
                  {dataTournament?.listMaximas[28].atual}<br />
                  {dataTournament?.listMaximas[28].maxima}
                </GridColumn>
              </GridRow>
              <GridRow columns={3}>
                <GridColumn>
                  {dataTournament?.listMaximas[29].nome}<br />
                  {dataTournament?.listMaximas[29].atual}<br />
                  {dataTournament?.listMaximas[29].maxima}
                </GridColumn>
              </GridRow>
            </Grid>
          </GridColumn>
          {/* Fim Segunda Coluna */}
        </GridRow>
      </Grid>

      {/* {dataTournament?.listMaximas.map((listMaxima) => {
        return (
          <>
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
          </>
        );
      })} */}
    </>
  );
});
