import './Layout.css';


export default function Layout({ children }) {
    function getYear() {
        return new Date().getFullYear();
    }

    return (
        <>
            <nav className="navbar navbar-expand-lg navbar-dark bg-dark">
                <div className="collapse navbar-collapse" id="navbarSupportedContent">
                    <ul className="navbar-nav mr-auto">
                        <li className="nav-item active">
                            <a className="nav-link" href="/">Home</a>
                        </li>
                        <li className="nav-item">
                            <a className="nav-link" href="/posts">Posts</a>
                        </li>
                        <li className="nav-item">
                            <a className="nav-link" href="/create">New Post</a>
                        </li>
                    </ul>
                </div>
            </nav>
            <div className="app-container">
                {children}
            </div>
        </>
    );
}