import React, { useState } from 'react';
import Constants from "./utilities/constants";
import PostCreateForm from './components/PostCreateForm'
import PostUpdateForm from './components/PostUpdateForm'
import './App.css';

export default function App() {
  const [posts, setPosts] = useState([]);
  const [showingCreateNewPostForm, setShowingCreateNewPostForm] = useState(false);
  const [postCurrentlyBeingUpdated, setPostCurrentlyBeingUpdated] = useState(null);

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

  function deletePost(postId) {
    const url = `${Constants.API_URL_DELETE_POST_BY_ID}/${postId}`;

    fetch(url, {
      method: 'DELETE',
    })
      .then(response => response.json())
      .then(responseFromServer => {
        console.log(responseFromServer);
        onPostDeleted(postId);
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
          {(showingCreateNewPostForm === false && postCurrentlyBeingUpdated === null) && (
            <div>
              <h1 className='text-center'>BlogApp</h1>

              <div className='mt-5'>
                <button className='btn btn-dark btn-lg w-100' onClick={getPosts}>Get Posts From Server</button>
                <button className='btn btn-secondary btn-lg w-100 mt-4' onClick={() => setShowingCreateNewPostForm(true)}>Create New Post</button>
              </div>
            </div>
          )}

          {(posts.length > 0 && showingCreateNewPostForm === false && postCurrentlyBeingUpdated === null) && renderPostsTable()}

          {showingCreateNewPostForm && <PostCreateForm onPostCreated={onPostCreated} />}

          {postCurrentlyBeingUpdated !== null && <PostUpdateForm post={postCurrentlyBeingUpdated} onPostUpdated={onPostUpdated} />}
        </div>
      </div>
    </div>
  );

  function renderPostsTable() {
    return (
      <div className='table-responsive mt-5 mb-5'>
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
                  <button onClick={() => setPostCurrentlyBeingUpdated(post)} className='btn btn-dark btn-lg mx-3 my-3'>Update</button>
                  <button onClick={() => { if(window.confirm(`Are you sure you want to delete the post '${post.title}'?`)) deletePost(post.postId) }} className='btn btn-secondary btn-lg mx-3'>Delete</button>
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

  function onPostUpdated(updatedPost) {
    setPostCurrentlyBeingUpdated(null);

    if (updatedPost === null) {
      return;
    }

    let postsCopy = [...posts];
    const index = postsCopy.findIndex((postsCopyPost, currentIndex) => {
      if (postsCopyPost.postId === updatedPost.postId) {
        return true;
      }
    });

    if (index !== -1) {
      postsCopy[index] = updatedPost;
    }

    setPosts(postsCopy);

    alert(`Post successfully updated. After clicking 'OK', look for the post with the title '${updatedPost.title}' in the table below to see the updates.`);
  }

  function onPostDeleted(deletedPostId) {
    let postsCopy = [...posts];
    const index = postsCopy.findIndex((postsCopyPost, currentIndex) => {
      if (postsCopyPost.postId === deletedPostId) {
        return true;
      }
    });

    if (index !== -1) {
      postsCopy.splice(index, 1);
    }

    setPosts(postsCopy);

    alert(`Post successfully deleted. After clicking 'OK', look for the post with the id '${deletedPostId}' in the table below to see that it has been deleted.`);
  }
}
