import React, { Component } from 'react';
import { Form, TextArea } from 'semantic-ui-react';
import SemanticDatepicker from 'react-semantic-ui-datepickers';
import 'react-semantic-ui-datepickers/dist/react-semantic-ui-datepickers.css';
import { Editor } from 'react-draft-wysiwyg';
import 'react-draft-wysiwyg/dist/react-draft-wysiwyg.css';


export class ProjectCreateComponent extends Component {
    constructor() {
        super()
        this.state = {
            projectTitle: '',
            Owner: '',
            DateStarted: '',
            DateEnd: ''
        }

        this.handleChange = this.handleChange.bind(this)
    }

    handleChange(event) {
        const { name, value } = event.target

        this.setState({
            [name]: value
        })
    }


    render() {
        return (
            <div>
                <h1>Create Project</h1>
            <Form>
                <Form.Field>
                        <label>Project Title</label>
                        <input name='projectTitle' value={this.state.projectTitle} onChange={this.handleChange} />
                </Form.Field>
                <Form.Field>
                        <label>Owner</label>
                        <input name='Owner' value={this.state.Owner} onChange={this.handleChange}/>
                </Form.Field>
                    <Form.Group widths='equal' >
                        <SemanticDatepicker name='DateStarted' />
                        <SemanticDatepicker name='DateEnd' />
                </Form.Group>
                <Editor
                />
                </Form>
                </div>
        )
    }
}