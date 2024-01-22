import { observer } from "mobx-react-lite";
import { Table, TableHeader } from "semantic-ui-react";

interface Props {
  ambasMarcamMaxima: number;
  ambasMarcamAtual: number;
  ambasNaoMarcamMaxima: number;
  ambasNaoMarcamAtual: number;
}

export default observer(function TableAmbasMarcam({ ambasMarcamMaxima, ambasMarcamAtual, ambasNaoMarcamMaxima, ambasNaoMarcamAtual }: Props) {
  return (
    <Table textAlign={"center"}>
      <TableHeader>
        <Table.Row>
          <Table.Cell colSpan='2' className="table_detail_header">AMBAS MARCAM</Table.Cell>
        </Table.Row>
      </TableHeader>
      <Table.Body>
        <Table.Row>
          <Table.Cell>
            <Table textAlign="center">
              <Table.Body>
                <Table.Row>
                  <Table.Cell className="table_detail_header" width={4}>
                    SIM
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_body">
                    {ambasMarcamAtual}
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_header">MÁXIMA: {ambasMarcamMaxima}</Table.Cell>
                </Table.Row>
              </Table.Body>
            </Table>
          </Table.Cell>
          <Table.Cell>
            <Table textAlign="center">
              <Table.Body>
                <Table.Row>
                  <Table.Cell className="table_detail_header" width={4}>
                    NÃO
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_body">
                    {ambasNaoMarcamAtual}
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_header">MÁXIMA: {ambasNaoMarcamMaxima}</Table.Cell>
                </Table.Row>
              </Table.Body>
            </Table>
          </Table.Cell>
        </Table.Row>
      </Table.Body>
    </Table>
  )
});