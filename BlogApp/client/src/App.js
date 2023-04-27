import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import Home from './components/Home/Home';
import Layout from './components/Layout/Layout';
import PostCreateForm from './components/Posts/Create/PostCreateForm';
import PostDetails from './components/Posts/Details/PostDetails';
import PostIndex from './components/Posts/Index/PostIndex';
import PostUpdateForm from './components/Posts/Update/PostUpdateForm';

export default function App() {
  return (
    <>
    <Router>
      <Routes>
        <Route path='/' element={<Layout />} />
        <Route index element={<Home />} />
        <Route path='posts' element={<PostIndex />} />
        <Route path='create' element={<PostCreateForm />} />
        <Route path='posts/details/:postId' element={<PostDetails />} />
        <Route path='posts/update/:postId' element={<PostUpdateForm />} />
      </Routes>
    </Router>
    </>
  );
}
