import React from 'react';

export default function LandingPage() {
  return (
    <div className="landing-page">
      <div className='container'>
        <div className="row justify-content-center">
          <div className='col'>
            <h1>Welcome to My Blog</h1>
            <p>Here you'll find my latest posts on technology, science, and more.</p>
            <button className='btn btn-primary'>
              Read the Blog
            </button>
          </div>
        </div>
      </div>
    </div>
  );
};
