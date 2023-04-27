import React, { useState, useEffect } from 'react';
import { useParams } from 'react-router-dom';
import Constants from '../../../utilities/constants';
import Layout from '../../Layout/Layout';
import './PostDetails.css';

export default function PostDetails() {
    const [post, setPost] = useState([]);
    const { postId } = useParams();
    const url = `${Constants.API_URL_GET_POSTS_BY_ID}/${postId}`;

    useEffect(() => {
        if (postId) {
            getPost(postId);
        }
    }, [postId]);

    function getPost(postId) {
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

    const date = new Date(post.createdAt);
    const options = { year: 'numeric', month: 'long', day: 'numeric' };
    post.createdAt = date.toLocaleDateString('en-US', options);
    post.updatedAt = date.toLocaleDateString('en-US', options);

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
                            <button className='btn btn-danger' value={post.postId}>Delete</button>
                        </div>
                    </div>
                </div>
            </Layout>
        </>
    );
};
