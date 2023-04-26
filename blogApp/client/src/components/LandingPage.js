import React from 'react';
import { Link } from 'react-router-dom';
import Layout from './Layout/Layout';


export default function LandingPage() {
  return (
    <>
      <Layout>
        <div className="landing-page">
          <div className='container'>
            <div className="row justify-content-center">
              <div className='col'>
                <h1>Welcome to My Blog</h1>
                <p>Here you'll find my latest posts on technology, science, and more.</p>
                <Link to="/posts" className="btn btn-primary">View Posts</Link>
              </div>
            </div>
          </div>
        </div>
      </Layout>
    </>
  );
};
