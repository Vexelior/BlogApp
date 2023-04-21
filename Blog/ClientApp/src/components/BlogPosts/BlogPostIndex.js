import React, { useState, useEffect } from 'react';
import { Link } from 'react-router-dom';
import axios from 'axios';
import 'bootstrap/dist/css/bootstrap.min.css';

const [posts, setPosts] = useState([]);

useEffect(() => {
    const fetchPosts = async () => {
        const { data } = await axios.get('/api/posts');
        setPosts(data);
    };
    fetchPosts();
}, []);

export class BlogPostIndex extends Component {
    static displayName = Home.name;

    render() {
        return (
            <div className="container">
                <h1 className="text-center my-5">Blog Posts</h1>
                <div className="row">
                    {posts.map(post => (
                        <div key={post.id} className="col-md-4 mb-4">
                            <div className="card h-100">
                                <img
                                    src={post.image}
                                    className="card-img-top"
                                    alt={post.title}
                                />
                                <div className="card-body">
                                    <h5 className="card-title">{post.title}</h5>
                                    <p className="card-text">{post.summary}</p>
                                    <Link to={`/posts/${post.id}`} className="btn btn-primary">
                                        Read More
                                    </Link>
                                </div>
                            </div>
                        </div>
                    ))}
                </div>
            </div>
        );
    }
}
