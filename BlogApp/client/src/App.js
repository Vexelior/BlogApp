import { BrowserRouter as Router, Routes, Route } from 'react-router-dom';
import LandingPage from './components/LandingPage';
import Layout from './components/Layout/Layout';
import PostIndex from './components/Posts/PostIndex';

export default function App() {
  return (
    <>
    <Router>
      <Routes>
        <Route path="/" element={<Layout />} />
        <Route index element={<LandingPage />} />
        <Route path="/posts" element={<PostIndex />} />
      </Routes>
    </Router>
    </>
  );
}
