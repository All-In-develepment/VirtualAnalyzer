import { observer } from "mobx-react-lite";
import { Table, TableHeader } from "semantic-ui-react";

interface Props {
  semMarcadorAtual: number;
  semMarcadorMaxima: number;
  centroAvanteCasaAtual: number;
  centroAvanteCasaMaxima: number;
  centroAvanteVisitanteAtual: number;
  centroAvanteVisitanteMaxima: number;
  pontaDireitaCasaAtual: number;
  pontaDireitaCasaMaxima: number;
  pontaDireitaVisitanteAtual: number;
  pontaDireitaVisitanteMaxima: number;
  pontaEsquerdaCasaAtual: number;
  pontaEsquerdaCasaMaxima: number;
  pontaEsquerdaVisitanteAtual: number;
  pontaEsquerdaVisitanteMaxima: number;
  meiaAtacanteCasaAtual: number;
  meiaAtacanteCasaMaxima: number;
  meiaAtacanteVisitanteAtual: number;
  meiaAtacanteVisitanteMaxima: number;
  outroJogadorCasaAtual: number;
  outroJogadorCasaMaxima: number;
  outroJogadorVisitanteAtual: number;
  outroJogadorVisitanteMaxima: number;
}

export default observer(function TableResultadoHT({semMarcadorAtual,
  semMarcadorMaxima,
  centroAvanteCasaAtual,
  centroAvanteCasaMaxima,
  centroAvanteVisitanteAtual,
  centroAvanteVisitanteMaxima,
  pontaDireitaCasaAtual,
  pontaDireitaCasaMaxima,
  pontaDireitaVisitanteAtual,
  pontaDireitaVisitanteMaxima,
  pontaEsquerdaCasaAtual,
  pontaEsquerdaCasaMaxima,
  pontaEsquerdaVisitanteAtual,
  pontaEsquerdaVisitanteMaxima,
  meiaAtacanteCasaAtual,
  meiaAtacanteCasaMaxima,
  meiaAtacanteVisitanteAtual,
  meiaAtacanteVisitanteMaxima,
  outroJogadorCasaAtual,
  outroJogadorCasaMaxima,
  outroJogadorVisitanteAtual,
  outroJogadorVisitanteMaxima } : Props) {
  return (
    <Table textAlign={"center"}>
      <TableHeader>
        <Table.Row>
          <Table.Cell colSpan='2' className="table_detail_header">PRIMEIRO A MARCAR</Table.Cell>
        </Table.Row>
      </TableHeader>
      <Table.Body>
        <Table.Row  className="table_detail_body">
          <Table.Cell width={8}>CASA</Table.Cell>
          <Table.Cell width={8}>VISITANTE</Table.Cell>
        </Table.Row>
        <Table.Row>
          <Table.Cell colSpan='2' className="table_detail_body">
            SEM MARCADOR<br />
            <span className="span_max">MÁX: {semMarcadorAtual} / {semMarcadorMaxima}</span>
          </Table.Cell>
        </Table.Row>
        <Table.Row className="table_detail_body">
          <Table.Cell width={8}>
            CENTRO AVANTE CASA<br />
            <span className="span_max">MÁX: {centroAvanteCasaAtual} / {centroAvanteCasaMaxima}</span>
          </Table.Cell>
          <Table.Cell width={8}>
            CENTRO AVANTE VISITANTE<br />
            <span className="span_max">MÁX: {centroAvanteVisitanteAtual} / {centroAvanteVisitanteMaxima}</span>
          </Table.Cell>
        </Table.Row>
        <Table.Row  className="table_detail_body">
          <Table.Cell>
            PONTA DIREITA CASA<br />
            <span className="span_max">MÁX: {pontaDireitaCasaAtual} / {pontaDireitaCasaMaxima}</span>
          </Table.Cell>
          <Table.Cell>
            PONTA DIREITA VISITANTE<br />
            <span className="span_max">MÁX: {pontaDireitaVisitanteAtual} / {pontaDireitaVisitanteMaxima}</span>
          </Table.Cell>
        </Table.Row>
        <Table.Row  className="table_detail_body">
          <Table.Cell>
            PONTA ESQUERDA CASA<br />
            <span className="span_max">MÁX: {pontaEsquerdaCasaAtual} / {pontaEsquerdaCasaMaxima}</span>
          </Table.Cell>
          <Table.Cell>
            PONTA ESQUERDA VISITANTE<br />
            <span className="span_max">MÁX: {pontaEsquerdaVisitanteAtual} / {pontaEsquerdaVisitanteMaxima}</span>
          </Table.Cell>
        </Table.Row>
        <Table.Row  className="table_detail_body">
          <Table.Cell>
            MEIA ATACANTE CASA<br />
            <span className="span_max">MÁX: {meiaAtacanteCasaAtual} / {meiaAtacanteCasaMaxima}</span>
          </Table.Cell>
          <Table.Cell>
            MEIA ATACANTE VISITANTE<br />
            <span className="span_max">MÁX: {meiaAtacanteVisitanteAtual} / {meiaAtacanteVisitanteMaxima}</span>
          </Table.Cell>
        </Table.Row>
        <Table.Row  className="table_detail_body">
          <Table.Cell>
            OUTRO JOGADOR CASA<br />
            <span className="span_max">MÁX: {outroJogadorCasaAtual} / {outroJogadorCasaMaxima}</span>
          </Table.Cell>
          <Table.Cell>
            OUTRO JOGADOR VISITANTE<br />
            <span className="span_max">MÁX: {outroJogadorVisitanteAtual} / {outroJogadorVisitanteMaxima}</span>
          </Table.Cell>
        </Table.Row>
      </Table.Body>
    </Table>
  )
});