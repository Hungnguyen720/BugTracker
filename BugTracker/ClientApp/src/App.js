import React, { Component } from 'react';
import { Route } from 'react-router';
import { Layout } from './components/Layout';
import { Home } from './components/Home';
import { FetchData } from './components/FetchData';
import { Counter } from './components/Counter';
import { RegisterComponent } from './components/UserComponents/RegisterComponent';
import { LoginComponent } from './components/UserComponents/LoginComponent';
import { ProjectDashboardComponent } from './components/ProjectComponents/Dashboard/ProjectDashboardComponent';
import { BugsDashboardComponent } from './components/ProjectComponents/Bugs/BugsListComponent';
import { ProjectListComponent } from './components/ProjectComponents/ProjectListComponent';
import { ProjectCreateComponent } from './components/ProjectComponents/ProjectCreateComponent';
import { ProjectUsersComponent } from './components/ProjectComponents//ProjectUsersComponent';
import { BugsCreateComponent } from './components/ProjectComponents/Bugs/BugsCreateComponent';

import './custom.css'

export default class App extends Component {
  static displayName = App.name;

  render () {
    return (
      <Layout>
        <Route exact path='/' component={Home} />
        <Route path='/counter' component={Counter} />
            <Route exact path='/fetch-data' component={FetchData} />
            <Route exact path='/register' component={RegisterComponent} />
            <Route exact path='/login' component={LoginComponent} />
            <Route exact path='/:username/project/dashboard' component={ProjectDashboardComponent} />
            <Route exact path='/:username/project/bugs' component={BugsDashboardComponent} />
            <Route exact path='/:username/project/list' component={ProjectListComponent} />
            <Route exact path='/:username/project/create' component={ProjectCreateComponent} />
            <Route exact path='/:username/project/users' component={ProjectUsersComponent} />
            <Route exact path='/:username/project/bugs/create' component={BugsCreateComponent} />

      </Layout>
    );
  }
}
