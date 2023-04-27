import React, { useState, useEffect } from 'react'
import Constants from '../../../utilities/constants'
import { useParams } from 'react-router-dom';
import './PostUpdateForm.css';

export default function PostUpdateForm() {
    const [formData, setFormData] = useState([]);
    const { postId } = useParams();
    const url = Constants.API_URL_UPDATE_POST;

    // Get the details of the post, populate the form with the data
    const getPostDetails = async () => {
        const response = await fetch(`${Constants.API_URL_GET_POSTS_BY_ID}/${postId}`);
        const post = await response.json();

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
            window.location.href = `/posts/details/${postId}`;
        }
    }

    return (
        <div className='container'>
            <form className='w-100 px-5'>
                <h1 className='mt-5'>Edit</h1>
                <div className='mt-5'>
                    <label className='h3 form-label'>Title</label>
                    <input className='form-control' value={formData.title} name='title' type="text" onChange={handleChange} />
                </div>
                <div className='mt-5'>
                    <label className='h3 form-label'>Content</label>
                    <textarea className='form-control' value={formData.content} name='content' type="text" onChange={handleChange} rows="10"/>
                </div>
                <button onClick={handleSubmit} className='btn btn-primary btn-lg w-100 mt-5'>Update</button>
            </form>
            <button className='btn btn-primary btn-lg mt-5' onClick={() => window.location.href = `/posts/details/${postId}`}>Back</button>
        </div>
    )
}
