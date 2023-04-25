import React, { useState } from 'react';
import PostCreateForm from './components/PostCreateForm'
import Constants from "./utilities/constants";
import './App.css';

export default function App() {
  const [posts, setPosts] = useState([]);
  const [showingCreateNewPostForm, setShowingCreateNewPostForm] = useState(false);

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

  return (
    <div className='container'>
      <div className='row min-vh-100'>
        <div className='col d-flex flex-column justify-content-center align-items-center'>
          {showingCreateNewPostForm === false && (
            <div>
              <h1>BlogApp</h1>

              <div className='mt-5'>
                <button className='btn btn-dark btn-lg w-100' onClick={getPosts}>Get Posts From Server</button>
                <button className='btn btn-secondary btn-lg w-100 mt-4' onClick={() => setShowingCreateNewPostForm(true)}>Create New Post</button>
              </div>
            </div>
          )}

          {(posts.length > 0 && showingCreateNewPostForm === false) && renderPostsTable()}

          {showingCreateNewPostForm && <PostCreateForm onPostCreated={onPostCreated} />}
        </div>
      </div>
    </div>
  );

  function renderPostsTable() {
    return (
      <div className='table-responsive mt-5'>
        <table className='table table-bordered border-dark'>
          <thead className='thead-dark'>
            <tr>
              <th scope='col'>PostId (PK)</th>
              <th scope='col'>Title</th>
              <th scope='col'>Content</th>
              <th scope='col'>CreatedAt</th>
              <th scope='col'>UpdatedAt</th>
              <th scope='col'>CRUD Operations</th>
            </tr>
          </thead>
          <tbody>
            {posts.map((post) => (
              <tr key={post.postId}>
                <th scope='row'>{post.postId}</th>
                <td>{post.title}</td>
                <td>{post.content}</td>
                <td className='text-nowrap'>{post.createdAt}</td>
                <td className='text-nowrap'>{post.updatedAt}</td>
                <td>
                  <button className='btn btn-dark btn-lg mx-3 my-3'>Update</button>
                  <button className='btn btn-secondary btn-lg mx-3'>Delete</button>
                </td>
              </tr>
            ))}
          </tbody>
        </table>

        <button className='btn btn-dark btn-lg w-100' onClick={() => setPosts([])}>Reset Posts</button>
      </div>
    );
  }

  function onPostCreated(createdPost) {
    setShowingCreateNewPostForm(false);

    if (createdPost === null) {
      return;
    } else {
      alert(`Post successfully created. After clicking 'OK', your new post titled '${createdPost.title}' will show up in the table below.`);
      getPosts();
    }
  }
}
