import React, { useState } from 'react'
import Constants from '../utilities/constants'

export default function PostUpdateForm(props) {
    const initialFromData = Object.freeze({
        title: props.post.title,
        content: props.post.content,
        createdAt: props.post.createdAt,
        updatedAt: props.post.updatedAt,
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

        const postToUpdate = {
            postId: props.post.postId,
            title: formData.title,
            content: formData.content,
            createdAt: formData.createdAt,
            updatedAt: formData.updatedAt,
        }

        const url = Constants.API_URL_UPDATE_POST;

        fetch(url, {
            method: 'PUT',
            headers: {
                'Content-Type': 'application/json'
            },
            body: JSON.stringify(postToUpdate),
        })
        .then(response => response.json())
        .then(responseFromServer => {
            console.log(responseFromServer);
        })
        .catch((error) => {
            console.log(error);
            alert(error);
        });

        props.onPostUpdated(postToUpdate);
    };

    return (
        <div>
            <form className='w-100 px-5'>
                <h1 className='mt-5'>Update Post</h1>

                <div className='mt-5'>
                    <label className='h3 form-label'>Post Title</label>
                    <input className='form-control' value={formData.title} name='title' type="text" onChange={handleChange} />
                </div>
                <div className='mt-5'>
                    <label className='h3 form-label'>Content</label>
                    <input className='form-control' value={formData.content} name='content' type="text" onChange={handleChange} />
                </div>
                <div className='mt-5'>
                    <input className='form-control' value={formData.createdAt} name='createdAt' type="hidden" onChange={handleChange} />
                </div>
                <div className='mt-5'>
                    <input className='form-control' value={formData.updatedAt} name='updatedAt' type="hidden" onChange={handleChange} />
                </div>
                <div className='mt-5'>
                    <input className='form-control' value={formData.authorId} name='authorId' type="hidden" onChange={handleChange} />
                </div>

                <button onClick={handleSubmit} className='btn btn-dark btn-lg w-100 mt-5'>Submit</button>
                <button onClick={() => props.onPostUpdated(null)} className='btn btn-secondary btn-lg w-100 mt-3'>Cancel</button>
            </form>
        </div>
    )
}
