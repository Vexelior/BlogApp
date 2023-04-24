import './App.css';

export default function App() {
  return (
    <div className='container'>
      <div className='row min-vh-100'>
        <div className='col d-flex flex-column justify-content-center align-items-center'>
          <h1>Hello Bootstrap!</h1>
          
          {renderPostsTable()}
        </div>
      </div>
    </div>
  );

  function renderPostsTable() {
    return (
      <div className='table-responsive mt-5'>
        <table className='table table-bordered border-dark'>
          <thead className='thead-dark'>
            <tr>
              <th scope='col'>PostId (PK)</th>
              <th scope='col'>Title</th>
              <th scope='col'>Content</th>
              <th scope='col'>CreatedAt</th>
              <th scope='col'>UpdatedAt</th>
              <th scope='col'>CRUD Operations</th>
            </tr>
          </thead>
          <tbody>
            <tr>
              <th scope='row'>1</th>
                <td>Post 1 Title</td>
                <td>Post 1 Content</td>
                <td className='text-nowrap'>2021-01-01 00:00:00</td>
                <td className='text-nowrap'>2021-01-01 00:00:00</td>
                <td>
                  <button className='btn btn-dark btn-lg mx-3 my-3'>Update</button>
                  <button className='btn btn-secondary btn-lg mx-3'>Delete</button>
                </td>
            </tr>
          </tbody>
        </table>
      </div>
    );
  }
}
