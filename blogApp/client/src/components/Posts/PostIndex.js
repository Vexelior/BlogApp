import React, { useState, useEffect } from 'react';
import Constants from '../../utilities/constants';
import Layout from '../Layout/Layout';

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

  function renderPosts() {
    return posts.map((post) => {
      return (
        <li key={post.postId}><a href={`/posts/${post.postId}`}>{post.title}</a></li>
      );
    });
  }

  return (
    <>
      <Layout>
        <h1>Posts</h1>
        <p>Here are all of my posts.</p>
        <ul>
          {renderPosts()}
        </ul>
      </Layout>
    </>
  );
};
