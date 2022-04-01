import MUIDataTable from "mui-datatables";
import styled from "styled-components";
import Typescript from "../icons/TypescriptIcon";

const columns = ["Domain", "Description", "Snippet"];

const CodeSnippet = styled.code`
  background-color: lightgrey;
`;

const data = [
  [
    <Typescript />,
    <i>Functional component boilerplate</i>,
    <CodeSnippet>{`export default = (): JSX.Element => {
        return (
        )
    }`}</CodeSnippet>,
  ],
  ["C#", "Test Corp", "Hartford"],
  ["Powershell", "Test Corp", "Tampa"],
];

export default () => {
  return (
    <MUIDataTable
      options={{
        selectableRows: undefined,
      }}
      title={"Employee List"}
      data={data}
      columns={columns}
    />
  );
};
