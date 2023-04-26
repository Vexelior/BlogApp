import React, { useState, useEffect } from 'react';
import Constants from '../../utilities/constants';

export default function PostIndex() {
  const [posts, setPosts] = useState([]);
  const url = Constants.API_URL_GET_ALL_POSTS;

  useEffect(() => {
    getPosts();
  }, []);

  function getPosts() {
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
        <li key={post.id}>{post.title}</li>
      );
    });
  }

  return (
    <>
      <div className="container">
        <div className="row justify-content-center">
          <div className="col">
            <h1>Posts</h1>
            <p>Here are all of my posts.</p>
            <ul>
              {renderPosts()}
            </ul>
          </div>
        </div>
      </div>
    </>
  );
};
