import { observer } from "mobx-react-lite";
import { Table, TableHeader } from "semantic-ui-react";

interface Props {
  casaAtual: number;
  casaMaxima: number;
  empateAtual: number;
  empateMaxima: number;
  foraAtual: number;
  foraMaxima: number;
}

export default observer(function TableUltimoTimeAMarcar({ casaAtual, casaMaxima, empateAtual, empateMaxima, foraAtual, foraMaxima }: Props) {
  return (
    <Table textAlign={"center"}>
      <TableHeader>
        <Table.Row>
          <Table.Cell colSpan='3' className="table_detail_header">ÚLTIMO TIME A MARCAR</Table.Cell>
        </Table.Row>
        <Table.Row className="table_detail_body">
          <Table.Cell>CASA</Table.Cell>
          <Table.Cell>EMPATE</Table.Cell>
          <Table.Cell>VISITANTE</Table.Cell>
        </Table.Row>
      </TableHeader>
      <Table.Body>
        <Table.Row className="table_exact_score_row">
          <Table.Cell>
            <span className="span_max">MÁX: {casaAtual} / {casaMaxima}</span>
          </Table.Cell>
          <Table.Cell>
            <span className="span_max">MÁX: {empateAtual} / {empateMaxima}</span>
          </Table.Cell>
          <Table.Cell>
            <span className="span_max">MÁX: {foraAtual} / {foraMaxima}</span>
          </Table.Cell>
        </Table.Row>
      </Table.Body>
    </Table>
  )
});