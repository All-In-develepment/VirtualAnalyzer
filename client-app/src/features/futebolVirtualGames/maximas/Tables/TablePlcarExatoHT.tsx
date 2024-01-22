import { observer } from "mobx-react-lite";
import { Table, TableHeader } from "semantic-ui-react";

interface Props {
  score1x0Atual: number;
  score1x0Maxima: number;
  score0x0Atual: number;
  score0x0Maxima: number;
  score0x1Atual: number;
  score0x1Maxima: number;
  score2x0Atual: number;
  score2x0Maxima: number;
  score1x1Atual: number;
  score1x1Maxima: number;
  score0x2Atual: number;
  score0x2Maxima: number;
}

export default observer(function TablePlcarExatoHT({ score1x0Atual,
  score1x0Maxima,
  score0x0Atual,
  score0x0Maxima,
  score0x1Atual,
  score0x1Maxima,
  score2x0Atual,
  score2x0Maxima,
  score1x1Atual,
  score1x1Maxima,
  score0x2Atual,
  score0x2Maxima }: Props) {
  return (
    <Table textAlign={"center"}>
      <TableHeader>
        <Table.Row>
          <Table.Cell colSpan='3' className="table_detail_header">PLACAR EXATO HT</Table.Cell>
        </Table.Row>
        <Table.Row className="table_detail_body">
          <Table.Cell>CASA</Table.Cell>
          <Table.Cell>EMPATE</Table.Cell>
          <Table.Cell>VISITANTE</Table.Cell>
        </Table.Row>
      </TableHeader>
      <Table.Body>
        <Table.Row>
          <Table.Cell className="table_exact_score_row">
            1x0<br />
            <span className="span_max">MÁX: {score1x0Atual} / {score1x0Maxima}</span>
          </Table.Cell>
          <Table.Cell className="table_exact_score_row">
            0x0<br />
            <span className="span_max">MÁX: {score0x0Atual} / {score0x0Maxima}</span>
          </Table.Cell>
          <Table.Cell className="table_exact_score_row">
            0x1<br />
            <span className="span_max">MÁX: {score0x1Atual} / {score0x1Maxima}</span>
          </Table.Cell>
        </Table.Row>
        <Table.Row>
          <Table.Cell className="table_exact_score_row">
            2x0<br />
            <span className="span_max">MÁX: {score2x0Atual} / {score2x0Maxima}</span>
          </Table.Cell>
          <Table.Cell className="table_exact_score_row">
            1x1<br />
            <span className="span_max">MÁX: {score1x1Atual} / {score1x1Maxima}</span>
          </Table.Cell>
          <Table.Cell className="table_exact_score_row">
            0x2<br />
            <span className="span_max">MÁX: {score0x2Atual} / {score0x2Maxima}</span>
          </Table.Cell>
        </Table.Row>
      </Table.Body>
    </Table>
  )
});