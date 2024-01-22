import { observer } from "mobx-react-lite";
import { Grid, Table, TableHeader } from "semantic-ui-react";

interface Props {
  parAtual: number;
  parMaxima: number;
  imparAtual: number;
  imparMaxima: number;
}

export default observer(function TableImparPar({ parAtual, parMaxima, imparAtual, imparMaxima }: Props) {
  return (
    <Table textAlign={"center"}>
      <TableHeader>
        <Table.Row>
          <Table.Cell className="table_detail_header" colSpan='2'>GOLS IMPAR / PAR</Table.Cell>
        </Table.Row>
      </TableHeader>

      <Table.Body>
        <Table.Row>
          <Table.Cell width={8}>
            <Table textAlign="center">
              <Table.Body>
                <Table.Row>
                  <Table.Cell className="table_detail_header">
                    IMPAR<span className="span_detail"> (sem sair) </span>
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_body">
                    {imparAtual}
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_header">MÁXIMA: {imparMaxima}</Table.Cell>
                </Table.Row>
              </Table.Body>
            </Table>
          </Table.Cell>
          <Table.Cell width={8}>
            <Table textAlign="center">
              <Table.Body>
                <Table.Row>
                  <Table.Cell className="table_detail_header">
                    PAR<span className="span_detail"> (sem sair) </span>
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_body">
                    {parAtual}
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_header">MÁXIMA: {parMaxima}</Table.Cell>
                </Table.Row>
              </Table.Body>
            </Table>
          </Table.Cell>
        </Table.Row>
      </Table.Body>
    </Table>
  )
});