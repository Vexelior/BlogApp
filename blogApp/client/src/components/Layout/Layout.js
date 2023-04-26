
export default function Layout({children}) {

    function getYear() {
        return new Date().getFullYear();
    }

  return (
    <>
        <nav className="navbar navbar-expand-lg navbar-dark bg-dark">
            <a className="navbar-brand" href="/">Blog App</a>
            <button className="navbar-toggler" type="button" data-toggle="collapse" data-target="#navbarNavAltMarkup"
                aria-controls="navbarNavAltMarkup"
                aria-expanded="false"
                aria-label="Toggle navigation">
                <span className="navbar-toggler-icon"></span>
            </button>
        </nav>

        <div className="container">
            {children}
        </div>

        <footer className="footer bg-dark" style={{ bottom: 0, position: 'fixed', width: '100%', height: '50px' }}>
            <div className="container">
                <p style={{ color: 'white', textAlign: 'center', marginTop: '10px' }}>Blog App &copy; {getYear()}</p>
            </div>
        </footer>
    </>
  );
}