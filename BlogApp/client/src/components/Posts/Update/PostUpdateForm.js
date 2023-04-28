import React, { useState, useEffect } from 'react'
import Constants from '../../../utilities/constants'
import { useParams } from 'react-router-dom';
import './PostUpdateForm.css';
import Layout from '../../Layout/Layout';

export default function PostUpdateForm() {
    const [formData, setFormData] = useState([]);
    const [isLoading, setIsLoading] = useState(true);
    const { postId } = useParams();
    const url = Constants.API_URL_UPDATE_POST;

    const getPostDetails = async () => {
        const response = await fetch(`${Constants.API_URL_GET_POSTS_BY_ID}/${postId}`);
        const post = await response.json();
        
        if (post !== null) {
            setTimeout(() => {
                setIsLoading(false);
            }, 500);
        }

        setFormData(post);
    }

    useEffect(() => {
        getPostDetails();
    }, []);

    const handleChange = (e) => {
        setFormData({ ...formData, [e.target.name]: e.target.value });
    }

    const handleSubmit = async (e) => {
        e.preventDefault();

        const postToUpdate = {
            postId: formData.postId,
            title: formData.title,
            content: formData.content,
            createdAt: formData.createdAt,
            updatedAt: new Date()
        }

        const response = await fetch(url, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(postToUpdate)
        });

        if (response.ok) {
            alert('Post updated successfully!');
            window.location.href = `/posts/details/${postId}`;
        }
    }

    return (
        <Layout>
            <div className='container'>
                <div className='update-post-container'>
                    {isLoading ? (
                        <div className="loading-icon text-center" style={{ opacity: 0.5 }}>
                            <i className="fa fa-spinner fa-spin"></i>
                        </div>
                    ) : (
                        <form className='w-100 px-5'>
                            <h1 className='mt-3 text-center'>Edit</h1>
                            <div className='mt-3'>
                                <label className='h3 form-label'>Title</label>
                                <input className='form-control' value={formData.title} name='title' type="text" onChange={handleChange} />
                            </div>
                            <div className='mt-3'>
                                <label className='h3 form-label'>Content</label>
                                <textarea className='form-control' value={formData.content} name='content' type="text" onChange={handleChange} rows="10" />
                            </div>
                            <button onClick={handleSubmit} className='btn btn-primary w-100 mt-3'>Update</button>
                            <a href={`/posts/details/${postId}`} className='btn btn-secondary w-100 mt-3'>Cancel</a>
                        </form>
                    )}
                </div>
            </div>
        </Layout>
    )
}
