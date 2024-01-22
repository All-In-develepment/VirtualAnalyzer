import { observer } from "mobx-react-lite";
import { Table, TableHeader } from "semantic-ui-react";

interface Props {
  over05Atual: number;
  over05Maxima: number;
  over15Atual: number;
  over15Maxima: number;
  over25Atual: number;
  over25Maxima: number;
  over35Atual: number;
  over35Maxima: number;
}

export default observer(function TableOverGols({ over05Atual, over05Maxima, over15Atual, over15Maxima, over25Atual, over25Maxima, over35Atual, over35Maxima }: Props) {
  return (
    <Table textAlign={"center"}>
      <TableHeader>
        <Table.Row>
          <Table.Cell colSpan='4' className="table_detail_header">OVER GOLS</Table.Cell>
        </Table.Row>
      </TableHeader>
      <Table.Body>
        <Table.Row>
          <Table.Cell>
            <Table textAlign="center">
              <Table.Body>
                <Table.Row>
                  <Table.Cell className="table_detail_header" width={4}>
                    OVER 0.5
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_body">
                    {over05Atual}
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_header">MÁXIMA: {over05Maxima}</Table.Cell>
                </Table.Row>
              </Table.Body>
            </Table>
          </Table.Cell>
          <Table.Cell>
            <Table textAlign="center">
              <Table.Body>
                <Table.Row>
                  <Table.Cell className="table_detail_header" width={4}>
                    OVER 1.5
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_body">
                    {over15Atual}
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_header">MÁXIMA: {over15Maxima}</Table.Cell>
                </Table.Row>
              </Table.Body>
            </Table>
          </Table.Cell>
          <Table.Cell>
            <Table textAlign="center">
              <Table.Body>
                <Table.Row>
                  <Table.Cell className="table_detail_header" width={4}>
                    OVER 2.5
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_body">
                    {over25Atual}
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_header">MÁXIMA: {over25Maxima}</Table.Cell>
                </Table.Row>
              </Table.Body>
            </Table>
          </Table.Cell>
          <Table.Cell>
            <Table textAlign="center">
              <Table.Body>
                <Table.Row>
                  <Table.Cell className="table_detail_header" width={4}>
                    OVER 3.5
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_body">
                    {over35Atual}
                  </Table.Cell>
                </Table.Row>
                <Table.Row>
                  <Table.Cell className="table_detail_header">MÁXIMA: {over35Maxima}</Table.Cell>
                </Table.Row>
              </Table.Body>
            </Table>
          </Table.Cell>
        </Table.Row>
      </Table.Body>
    </Table>
  )
});