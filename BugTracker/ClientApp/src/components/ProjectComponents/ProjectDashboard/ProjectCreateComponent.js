import React, { Component } from 'react';
import { Form, TextArea } from 'semantic-ui-react';
import SemanticDatepicker from 'react-semantic-ui-datepickers';
import 'react-semantic-ui-datepickers/dist/react-semantic-ui-datepickers.css';
import { Editor } from 'react-draft-wysiwyg';
import 'react-draft-wysiwyg/dist/react-draft-wysiwyg.css';


export class ProjectCreateComponent extends Component {
    render() {
        return (
            <div>
                <h1>Create Project</h1>
            <Form>

                <Form.Field>
                    <label>Project Title</label>
                    <input />
                </Form.Field>
                <Form.Field>
                    <label>Owner</label>
                    <input />
                </Form.Field>

                <Form.Group widths='equal' >
                    <SemanticDatepicker />
                    <SemanticDatepicker />
                </Form.Group>
                <Editor
                />

                </Form>
                </div>
        )
    }
}