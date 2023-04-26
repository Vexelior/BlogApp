import React, { useState, useEffect } from 'react';
import { useParams } from 'react-router-dom';
import Constants from '../../utilities/constants';
import Layout from '../Layout/Layout';

export default function PostDetails() {
    const [post, setPost] = useState([]);
    const { postId } = useParams();
    const url = `${Constants.API_URL_GET_POSTS_BY_ID}/${postId}`;

    useEffect(() => {
        if (postId)
        {
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

    return (
        <>
            <Layout />
            <div className="row justify-content-center">
                <div className="col">
                    <div className='card' key={post.postId}>
                        <div className='card-body'>
                            <h5 className='card-title'>{post.title}</h5>
                            <p className='card-text'>{post.content}</p>
                        </div>
                        <div className='card-footer'>
                            <small className='text-muted'>Posted on {post.createdAt}</small>
                            <br />
                            <small className='text-muted'> Updated: {post.updatedAt}</small>
                        </div>
                    </div>
                    <div className='btn-group' role='group' aria-label='Basic example'>
                        <button className='btn btn-secondary' onClick={() => window.history.back()}>Back</button>
                        <button className='btn btn-primary' value={post.postId}>Edit</button>
                        <button className='btn btn-danger' value={post.postId}>Delete</button>
                    </div>
                </div>
            </div>
        </>
    );
};
