import React, { useState } from 'react'
import Constants from '../../../utilities/constants'
import Layout from '../../Layout/Layout';
import './PostCreateForm.css'

export default function PostCreateForm(props) {
    const [posts, setPosts] = useState([]);
    const initialFromData = Object.freeze({
        title: '',
        content: '',
        createdAt: new Date().toISOString(),
        updatedAt: new Date().toISOString(),
    });

    const [formData, setFormData] = useState(initialFromData);

    const handleChange = (e) => {
        setFormData({
            ...formData,
            [e.target.name]: e.target.value,
        });
    };

    const handleSubmit = (e) => {
        e.preventDefault();

        const postToCreate = {
            postId: 0,
            title: formData.title,
            content: formData.content,
            createdAt: formData.createdAt,
            updatedAt: formData.updatedAt,
        }

        if (postToCreate.title === '' || postToCreate.content === '') {
            alert('Please fill out all fields.');
            return;
        }

        const url = Constants.API_URL_CREATE_POST;

        fetch(url, {
            method: 'POST',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(postToCreate),
        })
            .then(response => response.json())
            .then(responseFromServer => {
                console.log(responseFromServer);
                alert('Post created successfully.');
                window.location.href = '/posts';
            })
            .catch((error) => {
                console.log(error);
                alert(error);
            });
    };

    return (
        <Layout>
            <div className='container'>
                <div className='create-form-container mt-3'>
                    <form className='w-100'>
                        <h2 className='mt-3 text-center'>Create New Post</h2>
                        <div className='mt-3'>
                            <label className='h3 form-label'>Title</label>
                            <input className='form-control' value={formData.title} name='title' type="text" onChange={handleChange} />
                        </div>
                        <div className='mt-3'>
                            <label className='h3 form-label'>Content</label>
                            <textarea className='form-control' value={formData.content} name='content' rows='10' type="text" onChange={handleChange} />
                        </div>
                        <input className='form-control' value={formData.createdAt} name='createdAt' type="hidden" onChange={handleChange} />
                        <input className='form-control' value={formData.updatedAt} name='updatedAt' type="hidden" onChange={handleChange} />
                        <div className='mt-3'>
                            <button className='btn btn-primary w-100' onClick={handleSubmit}>Create</button>
                        </div>
                    </form>
                    <button className='btn btn-secondary w-100 mt-3' onClick={() => window.history.back()}>Cancel</button>
                </div>
            </div>
        </Layout>
    )
}
