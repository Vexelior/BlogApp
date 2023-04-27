import React from 'react';
import { Link } from 'react-router-dom';
import Layout from '../Layout/Layout';
import './Home.css';


export default function Home() {
  return (
    <>
      <Layout>
        <div className="landing-page">
          <div className='container'>
            <div className="row justify-content-center">
              <div className='col'>
                <div className='landing-info'>
                  <h1>Welcome to my Blog!</h1>
                  <p>Here you'll find my latest posts on technology, science, and more.</p>
                  <Link to="/posts" className="btn btn-primary">View Posts</Link>
                </div>
              </div>
            </div>
          </div>
        </div>
      </Layout>
    </>
  );
};
