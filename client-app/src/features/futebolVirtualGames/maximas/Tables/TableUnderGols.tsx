import { observer } from "mobx-react-lite";
import { Table, TableHeader } from "semantic-ui-react";

interface Props {
  under05Atual: number;
  under05Maxima: number;
  under15Atual: number;
  under15Maxima: number;
  under25Atual: number;
  under25Maxima: number;
  under35Atual: number;
  under35Maxima: number;
}

export default observer(function TableUnderGols({ under05Atual, under05Maxima, under15Atual, under15Maxima, under25Atual, under25Maxima, under35Atual, under35Maxima }: Props) {
  return (
    <Table textAlign={"center"}>
      <TableHeader>
        <Table.Row>
          <Table.Cell colSpan='4' className="table_detail_header">UNDER GOLS</Table.Cell>
        </Table.Row>
      </TableHeader>
      <Table.Body>
        <Table.Row>
          <Table.Cell>
            <Table textAlign="center">
              <Table.Body>
                <Table.Row>
                  <Table.Cell className="table_detail_header">
                    UNDER 0.5
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_body">
                    {under05Atual}
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_header">MÁXIMA: {under05Maxima}</Table.Cell>
                </Table.Row>
              </Table.Body>
            </Table>
          </Table.Cell>
          <Table.Cell>
            <Table textAlign="center">
              <Table.Body>
                <Table.Row>
                  <Table.Cell className="table_detail_header">
                    UNDER 1.5
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_body">
                    {under15Atual}
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_header">MÁXIMA: {under15Maxima}</Table.Cell>
                </Table.Row>
              </Table.Body>
            </Table>
          </Table.Cell>
          <Table.Cell>
            <Table textAlign="center">
              <Table.Body>
                <Table.Row>
                  <Table.Cell className="table_detail_header">
                    UNDER 2.5
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_body">
                    {under25Atual}
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_header">MÁXIMA: {under25Maxima}</Table.Cell>
                </Table.Row>
              </Table.Body>
            </Table>
          </Table.Cell>
          <Table.Cell>
            <Table textAlign="center">
              <Table.Body>
                <Table.Row>
                  <Table.Cell className="table_detail_header">
                    UNDER 3.5
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_body">
                    {under35Atual}
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_header">MÁXIMA: {under35Maxima}</Table.Cell>
                </Table.Row>
              </Table.Body>
            </Table>
          </Table.Cell>
        </Table.Row>
      </Table.Body>
    </Table>
  )
});