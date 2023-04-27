import React, { useState, useEffect } from 'react';
import Constants from '../../../utilities/constants';
import Layout from '../../Layout/Layout';
import './PostIndex.css';

export default function PostIndex() {
  const [posts, setPosts] = useState([]);

  useEffect(() => {
    getPosts();
  }, []);

  function getPosts() {
    const url = Constants.API_URL_GET_ALL_POSTS;

    fetch(url, {
      method: 'GET',
    })
      .then(response => response.json())
      .then(postsFromServer => {
        setPosts(postsFromServer);
      })
      .catch((error) => {
        console.log(error);
        alert(error);
      });
  }

  posts.forEach((post) => {
    post.createdAt = post.createdAt.split('T')[0];
    post.updatedAt = post.updatedAt.split('T')[0];

    const date = new Date(post.createdAt);
    const options = { year: 'numeric', month: 'long', day: 'numeric' };
    post.createdAt = date.toLocaleDateString('en-US', options);
    post.updatedAt = date.toLocaleDateString('en-US', options);
  });

  function renderPosts() {
    return posts.map((post) => {
      return (
        <a href={`/posts/details/${post.postId}`} className="post-link" key={post.postId} title={`Click to view '${post.title}'.`} id={`post-${post.postId}`}>
          <div className="card" key={post.id}>
            <div className="card-body">
              <h5 className="card-title">{post.title}</h5>
            </div>
            <div className="card-footer">
              <small className="text-muted">Created: {post.createdAt}</small>
              <small className="text-muted updated-text">Updated: {post.updatedAt}</small>
            </div>
          </div>
        </a>
      );
    });
  }

  return (
    <>
      <Layout>
        <div className="post-index-page">
          <div className='header'>
            <h1>Posts</h1>
          </div>
        </div>
          <div className='posts-container'>
            {renderPosts()}
          </div>
      </Layout>
    </>
  );
};
