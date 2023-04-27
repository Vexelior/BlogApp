import React from "react";
import { useParams } from "react-router-dom";
import Constants from "../../../utilities/constants";
import "./PostDelete.css";

export default function PostDelete() {
    const { postId } = useParams();
    const url = `${Constants.API_URL_GET_POSTS_BY_ID}/${postId}`;
    
    function deletePost() {
        fetch(url, {
        method: "DELETE",
        })
        .then((response) => response.json())
        .then((postFromServer) => {
            console.log(postFromServer);
        })
        .catch((error) => {
            console.log(error);
            alert(error);
        });
    }
    
    return (
        <>
            <div className="modal fade" id="deletePostModal" tabIndex="-1" aria-labelledby="deletePostModalLabel" aria-hidden="true">
                <div className="modal-dialog">
                    <div className="modal-content">
                    <div className="modal-header">
                        <h5 className="modal-title" id="deletePostModalLabel">Delete Post</h5>
                        <button type="button" className="btn-close" data-bs-dismiss="modal" aria-label="Close"></button>
                    </div>
                        <div className="modal-body">
                            <p>
                                Are you sure you want to delete this post?</p>
                        </div>
                        <div className="modal-footer">
                            <button type="button" className="btn btn-secondary" data-bs-dismiss="modal">No</button>
                            <button type="button" className="btn btn-primary" onClick={deletePost}>Yes</button>
                        </div>
                    </div>
                </div>
            </div>
        </>
    );
    }