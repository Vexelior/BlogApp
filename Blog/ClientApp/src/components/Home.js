import React, { Component } from 'react';
import 'bootstrap/dist/css/bootstrap.min.css';

export class Home extends Component {
  static displayName = Home.name;

  render() {
    return (
      <div className='container'>
        <div className='text-center'>
          <h1>Blog</h1>
        </div>
      <div className='container'>
        <div className='row'>
          <div className='col-sm-12 text-center mt-2'>
            <p>Blog is a simple blog application built with ASP.NET Core and React.</p>
          </div>
        </div>
      </div>
    </div>
    );
  }
}
