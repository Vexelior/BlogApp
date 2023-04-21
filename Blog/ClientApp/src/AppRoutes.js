import ApiAuthorzationRoutes from './components/api-authorization/ApiAuthorizationRoutes';
import { Home } from "./components/Home";
import { BlogPostIndex } from "./components/BlogPosts/BlogPostIndex";}

const AppRoutes = [
    {
        index: true,
        element: <Home />
    },
    {
        path: "/blogs",
        element: <BlogPostIndex />
    },
    ...ApiAuthorzationRoutes
];

export default AppRoutes;
