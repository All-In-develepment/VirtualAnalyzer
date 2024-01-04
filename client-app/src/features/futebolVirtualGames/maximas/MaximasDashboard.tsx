import { observer } from "mobx-react-lite";
import { Grid } from "semantic-ui-react";

export default observer(function MaximasDashboard() {
    return (
        <>
            <h1>Maximas</h1>
            <Grid
                textAlign="center"
                alignItems="center"
            >
                <Grid.Column width='4' >
                    <h2>Item 1</h2>
                </Grid.Column>
                <Grid.Column width='4'>
                    <h2>Item 2</h2>
                </Grid.Column>
                <Grid.Column width='4'>
                    <h2>Item 3</h2>
                </Grid.Column>
                <Grid.Column width='4'>
                    <h2>Item 4</h2>
                </Grid.Column>
            </Grid>
        </>
    )
});