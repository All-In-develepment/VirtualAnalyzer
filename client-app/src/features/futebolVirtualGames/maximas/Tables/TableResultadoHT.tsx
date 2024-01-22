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

export default observer(function TableResultadoHT({ casaAtual, casaMaxima, empateAtual, empateMaxima, foraAtual, foraMaxima }: Props) {
  return (
    <Table textAlign={"center"}>
      <TableHeader>
        <Table.Row>
          <Table.Cell colSpan='3' className="table_detail_header">RESULTADO INTERVALO / HT</Table.Cell>
        </Table.Row>
      </TableHeader>
      <Table.Body>
        <Table.Row>
          <Table.Cell>
            <Table textAlign="center">
              <Table.Body>
                <Table.Row>
                  <Table.Cell className="table_detail_header" width={4}>
                    CASA
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_body">
                    {casaAtual}
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_header">MÁXIMA: {casaMaxima}</Table.Cell>
                </Table.Row>
              </Table.Body>
            </Table>
          </Table.Cell>
          <Table.Cell>
            <Table textAlign="center">
              <Table.Body>
                <Table.Row>
                  <Table.Cell className="table_detail_header" width={4}>
                    EMPATE
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_body">
                    {empateAtual}
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_header">MÁXIMA: {empateMaxima}</Table.Cell>
                </Table.Row>
              </Table.Body>
            </Table>
          </Table.Cell>
          <Table.Cell>
            <Table textAlign="center">
              <Table.Body>
                <Table.Row>
                  <Table.Cell className="table_detail_header" width={4}>
                    FORA
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_body">
                    {foraAtual}
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_header">MÁXIMA: {foraMaxima}</Table.Cell>
                </Table.Row>
              </Table.Body>
            </Table>
          </Table.Cell>
        </Table.Row>
      </Table.Body>
    </Table>
  )
});