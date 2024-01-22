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

export default observer(function TablePrimerioTimeAMarcar({ casaAtual, casaMaxima, empateAtual, empateMaxima, foraAtual, foraMaxima }: Props) {
  return (
    <Table textAlign={"center"}>
      <TableHeader>
        <Table.Row>
          <Table.Cell colSpan='3' className="table_detail_header">PRIMEIRO TIME A MARCAR</Table.Cell>
        </Table.Row>
        <Table.Row className="table_exact_score_row">
          <Table.Cell>CASA</Table.Cell>
          <Table.Cell>EMPATE</Table.Cell>
          <Table.Cell>VISITANTE</Table.Cell>
        </Table.Row>
      </TableHeader>
      <Table.Body>
        <Table.Row className="table_exact_score_row">
          <Table.Cell>
            MÁX: {casaAtual} / {casaMaxima}
          </Table.Cell>
          <Table.Cell>
            MÁX: {empateAtual} / {empateMaxima}
          </Table.Cell>
          <Table.Cell>
            MÁX: {foraAtual} / {foraMaxima}
          </Table.Cell>
        </Table.Row>
      </Table.Body>
    </Table>
  )
});