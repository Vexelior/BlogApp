import React, { useState } from 'react'
import Constants from '../../../utilities/constants'
import { useParams } from 'react-router-dom';
import './PostUpdateForm.css';

export default function PostUpdateForm() {
    const [formData, setFormData] = useState({});
    const { postId } = useParams();
    const url = `${Constants.API_URL_UPDATE_POST}/${formData.postId}`;

    function handleChange(event) {
        setFormData({
            ...formData,
            [event.target.name]: event.target.value
        });
    }

    function handleSubmit(event) {
        event.preventDefault();

        const data = {
            title: formData.title,
            content: formData.content
        };

        fetch(url, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(data),
        })
        .then(response => response.json())
        .then(data => {
            console.log('Success:', data);
            alert('Post updated successfully!');
        })
        .catch((error) => {
            console.error('Error:', error);
            alert(error);
        });
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
