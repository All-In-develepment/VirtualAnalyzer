import { observer } from "mobx-react-lite";
import { useStore } from "../../../app/stores/store";

import {
  Grid,
  GridColumn,
  GridRow,
  Label,
  Table,
  TableCell,
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
        <Grid textAlign="center">
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
        </Grid>
      )}

      <Grid>
        <GridRow columns={2} textAlign="center">
          {/* Primeir Coluna */}
          <GridColumn >
            <Table>
              <Table.Header textAlign="center">
                <Table.Cell></Table.Cell>
                <Table.Cell>Hora</Table.Cell>
                <Table.Cell></Table.Cell>
                <TableCell>Casa</TableCell>
                <TableCell>Placar</TableCell>
                <TableCell>Visitante</TableCell>
                <TableCell></TableCell>
              </Table.Header>
              <Table.Body>
                {dataTournament?.matches.map((match) => (
                  <Table.Row key={match.data.id}>
                    <Table.Cell>ODDS</Table.Cell>
                    <Table.Cell>{match.data.date.split("T")[1]}</Table.Cell>
                    <Table.Cell>
                      {match.homeTop3.map((homeTop) => (
                        homeTop.idTeamWinner === homeTop.idTeamHome ? <Label color="green">V</Label> : homeTop.finalTimeDraw === true ? <Label color="yellow">E</Label> : <Label color="red">D</Label>
                      ))}
                    </Table.Cell>
                    <Table.Cell><img src={`/assets/flags/${match.data.homeImg}`} width={60} />{match.data.teamHome}</Table.Cell>
                    <Table.Cell>{match.data.finalTimeResult}</Table.Cell>
                    <Table.Cell><img src={`/assets/flags/${match.data.awayImg}`} width={60} />{match.data.teamAway}</Table.Cell>
                    <Table.Cell>
                      {match.awayTop3.map((awayTop) => (
                        awayTop.idTeamWinner === awayTop.idTeamAway ? 
                          <Label color="green">V</Label> : 
                          awayTop.finalTimeDraw === true ? 
                            <Label color="yellow">E</Label> : 
                            <Label color="red">D</Label>
                      ))}
                    </Table.Cell>
                  </Table.Row>
                ))}
              </Table.Body>
            </Table>
          </GridColumn>
          
          {/* Segunda Coluna */}
          {selectedTournament === "20849528" ? "Condição Super Liga" : 
            <GridColumn >
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
                  {dataTournament?.listMaximas[29].nome}<br />
                  {dataTournament?.listMaximas[29].atual}<br />
                  {dataTournament?.listMaximas[29].maxima}
                </GridColumn>
                <GridColumn>
                  {dataTournament?.listMaximas[80].nome}<br />
                  {dataTournament?.listMaximas[80].atual}<br />
                  {dataTournament?.listMaximas[80].maxima}
                </GridColumn>
              </GridRow>
              <GridRow columns={3}>
                <GridColumn>
                  {dataTournament?.listMaximas[24].nome}<br />
                  {dataTournament?.listMaximas[24].atual}<br />
                  {dataTournament?.listMaximas[24].maxima}
                </GridColumn>
                <GridColumn>
                  {dataTournament?.listMaximas[30].nome}<br />
                  {dataTournament?.listMaximas[30].atual}<br />
                  {dataTournament?.listMaximas[30].maxima}
                </GridColumn>
                <GridColumn>
                  {dataTournament?.listMaximas[81].nome}<br />
                  {dataTournament?.listMaximas[81].atual}<br />
                  {dataTournament?.listMaximas[81].maxima}
                </GridColumn>
              </GridRow>
              <GridRow columns={3}>
                <GridColumn>
                  {dataTournament?.listMaximas[25].nome}<br />
                  {dataTournament?.listMaximas[25].atual}<br />
                  {dataTournament?.listMaximas[25].maxima}
                </GridColumn>
                <GridColumn>
                  {dataTournament?.listMaximas[31].nome}<br />
                  {dataTournament?.listMaximas[31].atual}<br />
                  {dataTournament?.listMaximas[31].maxima}
                </GridColumn>
                <GridColumn>
                  {dataTournament?.listMaximas[82].nome}<br />
                  {dataTournament?.listMaximas[82].atual}<br />
                  {dataTournament?.listMaximas[82].maxima}
                </GridColumn>
              </GridRow>
              <GridRow columns={3}>
                <GridColumn>
                  {dataTournament?.listMaximas[26].nome}<br />
                  {dataTournament?.listMaximas[26].atual}<br />
                  {dataTournament?.listMaximas[26].maxima}
                </GridColumn>
                <GridColumn>
                  {dataTournament?.listMaximas[136].nome}<br />
                  {dataTournament?.listMaximas[136].atual}<br />
                  {dataTournament?.listMaximas[136].maxima}
                </GridColumn>
                <GridColumn>
                  {dataTournament?.listMaximas[83].nome}<br />
                  {dataTournament?.listMaximas[83].atual}<br />
                  {dataTournament?.listMaximas[83].maxima}
                </GridColumn>
              </GridRow>
              <GridRow columns={3}>
                <GridColumn>
                  {dataTournament?.listMaximas[27].nome}<br />
                  {dataTournament?.listMaximas[27].atual}<br />
                  {dataTournament?.listMaximas[27].maxima}
                </GridColumn>
                <GridColumn>
                  {dataTournament?.listMaximas[137].nome}<br />
                  {dataTournament?.listMaximas[137].atual}<br />
                  {dataTournament?.listMaximas[137].maxima}
                </GridColumn>
                <GridColumn>
                  {dataTournament?.listMaximas[84].nome}<br />
                  {dataTournament?.listMaximas[84].atual}<br />
                  {dataTournament?.listMaximas[84].maxima}
                </GridColumn>
              </GridRow>
              <GridRow columns={3}>
                <GridColumn>
                  {dataTournament?.listMaximas[138].nome}<br />
                  {dataTournament?.listMaximas[138].atual}<br />
                  {dataTournament?.listMaximas[138].maxima}
                </GridColumn>
                <GridColumn></GridColumn>
                <GridColumn>
                  {dataTournament?.listMaximas[139].nome}<br />
                  {dataTournament?.listMaximas[139].atual}<br />
                  {dataTournament?.listMaximas[139].maxima}
                </GridColumn>
              </GridRow>
              
              <GridRow columns={3}>
                <GridColumn>
                  {dataTournament?.listMaximas[28].nome}<br />
                  {dataTournament?.listMaximas[28].atual}<br />
                  {dataTournament?.listMaximas[28].maxima}
                </GridColumn>
                <GridColumn></GridColumn>
                <GridColumn>
                  {dataTournament?.listMaximas[85].nome}<br />
                  {dataTournament?.listMaximas[85].atual}<br />
                  {dataTournament?.listMaximas[85].maxima}
                </GridColumn>
              </GridRow>
            </Grid>

            {/* Sessão Placar Exato HT */}
            <Label size="large" color="blue">
              PLACAR EXATO HT
            </Label>
            <Grid>
              <GridRow columns={3}>
                <GridColumn>Casa</GridColumn>
                <GridColumn>Empate</GridColumn>
                <GridColumn>Visitante</GridColumn>
              </GridRow>
              <GridRow columns={3}>
                <GridColumn>
                  {dataTournament?.listMaximas[19].nome}<br />
                  {dataTournament?.listMaximas[19].atual}<br />
                  {dataTournament?.listMaximas[19].maxima}
                </GridColumn>
                <GridColumn>
                  {dataTournament?.listMaximas[21].nome}<br />
                  {dataTournament?.listMaximas[21].atual}<br />
                  {dataTournament?.listMaximas[21].maxima}
                </GridColumn>
                <GridColumn>
                  {dataTournament?.listMaximas[86].nome}<br />
                  {dataTournament?.listMaximas[86].atual}<br />
                  {dataTournament?.listMaximas[86].maxima}
                </GridColumn>
              </GridRow>
              <GridRow columns={3}>
                <GridColumn>
                  {dataTournament?.listMaximas[20].nome}<br />
                  {dataTournament?.listMaximas[20].atual}<br />
                  {dataTournament?.listMaximas[20].maxima}
                </GridColumn>
                <GridColumn>
                  {dataTournament?.listMaximas[22].nome}<br />
                  {dataTournament?.listMaximas[22].atual}<br />
                  {dataTournament?.listMaximas[22].maxima}
                </GridColumn>
                <GridColumn>
                  {dataTournament?.listMaximas[87].nome}<br />
                  {dataTournament?.listMaximas[87].atual}<br />
                  {dataTournament?.listMaximas[87].maxima}
                </GridColumn>
              </GridRow>
            </Grid>

            {/* Sessão Primeiro a Marcar */}
            <Label size="large" color="blue">
              PRIMEIRO A MARCAR
            </Label>
            <Grid>
              <GridRow columns={2}>
                <GridColumn>
                  Casa
                </GridColumn>
                <GridColumn>
                  Visitante
                </GridColumn>
              </GridRow>
              <GridRow columns={1}>
                <GridColumn>
                  {dataTournament?.listMaximas[150].nome}<br />
                  {dataTournament?.listMaximas[150].atual}<br />
                  {dataTournament?.listMaximas[150].maxima}
                </GridColumn>
              </GridRow>
              <GridRow columns={2}>
                <GridColumn>
                  {dataTournament?.listMaximas[140].nome}<br />
                  {dataTournament?.listMaximas[140].atual}<br />
                  {dataTournament?.listMaximas[140].maxima}
                </GridColumn>
                <GridColumn>
                  {dataTournament?.listMaximas[145].nome}<br />
                  {dataTournament?.listMaximas[145].atual}<br />
                  {dataTournament?.listMaximas[145].maxima}
                </GridColumn>
              </GridRow>
              <GridRow columns={2}>
                <GridColumn>
                  {dataTournament?.listMaximas[141].nome}<br />
                  {dataTournament?.listMaximas[141].atual}<br />
                  {dataTournament?.listMaximas[141].maxima}
                </GridColumn>
                <GridColumn>
                  {dataTournament?.listMaximas[146].nome}<br />
                  {dataTournament?.listMaximas[146].atual}<br />
                  {dataTournament?.listMaximas[146].maxima}
                </GridColumn>
              </GridRow>
              <GridRow columns={2}>
                <GridColumn>
                  {dataTournament?.listMaximas[142].nome}<br />
                  {dataTournament?.listMaximas[142].atual}<br />
                  {dataTournament?.listMaximas[142].maxima}
                </GridColumn>
                <GridColumn>
                  {dataTournament?.listMaximas[147].nome}<br />
                  {dataTournament?.listMaximas[147].atual}<br />
                  {dataTournament?.listMaximas[147].maxima}
                </GridColumn>
              </GridRow>
              <GridRow columns={2}>
                <GridColumn>
                  {dataTournament?.listMaximas[143].nome}<br />
                  {dataTournament?.listMaximas[143].atual}<br />
                  {dataTournament?.listMaximas[143].maxima}
                </GridColumn>
                <GridColumn>
                  {dataTournament?.listMaximas[148].nome}<br />
                  {dataTournament?.listMaximas[148].atual}<br />
                  {dataTournament?.listMaximas[148].maxima}
                </GridColumn>
              </GridRow>
              <GridRow columns={2}>
                <GridColumn>
                  {dataTournament?.listMaximas[144].nome}<br />
                  {dataTournament?.listMaximas[144].atual}<br />
                  {dataTournament?.listMaximas[144].maxima}
                </GridColumn>
                <GridColumn>
                  {dataTournament?.listMaximas[149].nome}<br />
                  {dataTournament?.listMaximas[149].atual}<br />
                  {dataTournament?.listMaximas[149].maxima}
                </GridColumn>
              </GridRow>
            </Grid>

            {/* Sessão Primeiro Time a Marcar */}
            <Label size="large" color="blue">
              PRIMEIRO TIME A MARCAR
            </Label>
            <Grid>
              <GridRow columns={3}>
                <GridColumn>
                  Casa
                </GridColumn>
                <GridColumn>
                  Nenhum
                </GridColumn>
                <GridColumn>
                  Visitante
                </GridColumn>
              </GridRow>
              <GridRow columns={3}>
                <GridColumn>
                  {dataTournament?.listMaximas[151].nome}<br />
                  {dataTournament?.listMaximas[151].atual}<br />
                  {dataTournament?.listMaximas[151].maxima}
                </GridColumn>
                <GridColumn>
                  {dataTournament?.listMaximas[153].nome}<br />
                  {dataTournament?.listMaximas[153].atual}<br />
                  {dataTournament?.listMaximas[153].maxima}
                </GridColumn>
                <GridColumn>
                  {dataTournament?.listMaximas[152].nome}<br />
                  {dataTournament?.listMaximas[152].atual}<br />
                  {dataTournament?.listMaximas[152].maxima}
                </GridColumn>
              </GridRow>
            </Grid>

            {/* Sessão Ultimo Time a Marcar */}
            <Label size="large" color="blue">
              ULTIMO TIME A MARCAR
            </Label>
            <Grid>
              <GridRow columns={3}>
                <GridColumn>
                  Casa
                </GridColumn>
                <GridColumn>
                  Nenhum
                </GridColumn>
                <GridColumn>
                  Visitante
                </GridColumn>
              </GridRow>
              <GridRow columns={3}>
                <GridColumn>
                  {dataTournament?.listMaximas[154].nome}<br />
                  {dataTournament?.listMaximas[154].atual}<br />
                  {dataTournament?.listMaximas[154].maxima}
                </GridColumn>
                <GridColumn>
                  {dataTournament?.listMaximas[156].nome}<br />
                  {dataTournament?.listMaximas[156].atual}<br />
                  {dataTournament?.listMaximas[156].maxima}
                </GridColumn>
                <GridColumn>
                  {dataTournament?.listMaximas[155].nome}<br />
                  {dataTournament?.listMaximas[155].atual}<br />
                  {dataTournament?.listMaximas[155].maxima}
                </GridColumn>
              </GridRow>
            </Grid>

          </GridColumn>
          }
          
          {/* Fim Segunda Coluna */}
        </GridRow>
      </Grid>
    </>
  );
});
