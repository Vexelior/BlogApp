import React, { useState, useEffect } from 'react';
import { useParams } from 'react-router-dom';
import Constants from '../../../utilities/constants';
import Layout from '../../Layout/Layout';
import './PostDetails.css';

export default function PostDetails() {
    const [post, setPost] = useState(null);
    const { postId } = useParams();
    const url = `${Constants.API_URL_GET_POSTS_BY_ID}/${postId}`;

    useEffect(() => {
        if (postId) {
            getPost(postId);
        }
    }, [postId]);

    function getPost() {
        fetch(url, {
            method: 'GET',
        })
            .then(response => response.json())
            .then(postFromServer => {
                setPost(postFromServer);
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
        .then(() => {
            console.log('Post deleted successfully!');
            onPostDeleted(postId);
        })
        .catch((error) => {
            console.log(error);
            alert(error);
        });
    }

    function onPostDeleted(deletedPostId) {
        if (post.postId === deletedPostId) {
            setPost(null);
        }
        
        alert('Post deleted successfully!');
        window.location.href = '/posts';
    }

    if (!post) {
        return null;
    }

    const createdDate = new Date(post.createdAt);
    const updatedDate = new Date(post.updatedAt);

    post.createdAt = createdDate.toLocaleDateString();
    post.updatedAt = updatedDate.toLocaleDateString();

    return (
        <>
            <Layout>
                <div className='container mt-2'>
                    <div className="row justify-content-center">
                        <div className="col">
                            <div className='card' key={post.postId}>
                                <div className='card-body'>
                                    <h5 className='card-title'><u>{post.title}</u></h5>
                                    <p className='card-text'>{post.content}</p>
                                </div>
                                <div className='card-footer'>
                                    <small className='text-muted'>Posted: {post.createdAt}</small>
                                    <small className='text-muted updated-text'> Updated: {post.updatedAt}</small>
                                </div>
                            </div>
                            <a className='btn btn-secondary' href='/posts'>Back</a>
                            <a className='btn btn-primary' href={`/posts/update/${post.postId}`}>Edit</a>
                            <button className='btn btn-danger' onClick={() => {if (window.confirm(`Are you sure you want to delete the post '${post.title}'?`)) deletePost(post.postId)}}>Delete</button>
                        </div>
                    </div>
                </div>
            </Layout>
        </>
    );
};
