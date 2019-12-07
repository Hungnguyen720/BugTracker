import React, { Component } from 'react';
import { Checkbox, Table } from 'semantic-ui-react';
import axios from 'axios';


export class BugsDashboardComponent extends Component {
    constructor() {
        super()
        this.state = { bugsList: [] }
    }

    componentDidMount() {
        this.populateBugs()
    }

    static renderBugsTable(bugsList) {
        return (
                <Table compact celled definition>
                    <Table.Header>
                        <Table.Row>
                            <Table.HeaderCell />
                            <Table.HeaderCell>Bug</Table.HeaderCell>
                            <Table.HeaderCell>Reporter</Table.HeaderCell>
                            <Table.HeaderCell>Created</Table.HeaderCell>
                            <Table.HeaderCell>Status</Table.HeaderCell>
                            <Table.HeaderCell>Assigned To</Table.HeaderCell>
                        </Table.Row>
                    </Table.Header>
                    <Table.Body>
                        {bugsList.map(bug => 
                            <Table.Row>
                                <Table.Cell collapsing>
                                    <Checkbox slider />
                                </Table.Cell>
                                <Table.Cell>{bug.title}</Table.Cell>
                                <Table.Cell>{bug.reporter}</Table.Cell>
                                <Table.Cell>{bug.dateCreated}</Table.Cell>
                                <Table.Cell>{bug.status}</Table.Cell>
                                <Table.Cell>{bug.assignedTo}</Table.Cell>
                            </Table.Row>
                        )}
                    </Table.Body>
                </Table>
        );
    }



    render() {
        let contents = this.state.loading
            ? <p><em>Loading...</em></p>
            : BugsDashboardComponent.renderBugsTable(this.state.bugsList);

        return (
            <div>
                {contents}
            </div>
        );
    }


    async populateBugs() {
        const response = await fetch('api/bugs')
        const data = await response.json()
        console.log(data)
        this.setState({ bugsList: data })
    }
}